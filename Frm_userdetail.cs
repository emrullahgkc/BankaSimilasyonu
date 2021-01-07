using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace BankaHesabi
{
    public partial class Frm_userdetail : Form
    {
        public Frm_userdetail()
        {
            InitializeComponent();
        }

        Sqlbaglantisi conn = new Sqlbaglantisi();
        BankaHesabEntitiess db = new BankaHesabEntitiess();
        tbl_kullanici user = new tbl_kullanici();
        tbl_kul_bnk kbank = new tbl_kul_bnk();
        tbl_Banka bnk = new tbl_Banka();
        tbl_kullanicihareket khrk = new tbl_kullanicihareket();
        public string bankaidnumarasi;
        public string tc;
        private void Frm_userdetail_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            var ch = db.tbl_Banka.ToList();
            cmbbnk.ValueMember = "id";
            cmbbnk.DisplayMember = "bankaad";
            cmbbnk.DataSource = ch;
            var kisilelkontrol = from tbl_kullanici in db.tbl_kullanici where tbl_kullanici.tc == tc select tbl_kullanici;
            foreach (var z in kisilelkontrol)
            {
                lblname.Text = z.ad;
                lblsname.Text = z.soyad;
                lblphone.Text = z.telefon;
            }

        }
        private void lblsend_Click(object sender, EventArgs e)
        {
            try            {
                var gonderibankontrol = db.tbl_kul_bnk.Where(p => p.hesapno == txtbankno.Text && p.iban == txtibanno.Text).FirstOrDefault();

                if (gonderibankontrol != null)
                {
                     int bnkidno = Convert.ToInt32(bankaidnumarasi);
                   var kullanicikontrol = from tbl_kul_bnk in db.tbl_kul_bnk where tbl_kul_bnk.id == bnkidno select tbl_kul_bnk;
                    foreach (var z in kullanicikontrol)
                    {
                        Decimal sayi = decimal.Parse(lblbalance.Text);
                            if (sayi<=0)
                        {
                            MessageBox.Show("Hesabınızdaki Bakiye: "+sayi,"Bakiye Yetersiz");                  
                        }
                      else if (sayi > 0)
                        {                               
                      SqlCommand komut = new SqlCommand("insert into tbl_kullanicihareket(gon_klncid ,gon_bnkid  ,miktar ,alici_bnkid,alici_klnciid,tarih) values (@p1,@p2,@p3,@p4,@p5,@p6) ", conn.baglanti());
                      komut.Parameters.AddWithValue("@p1", z.kullaniciid.ToString());
                      komut.Parameters.AddWithValue("@p2", bankaidnumarasi);
                      komut.Parameters.AddWithValue("@p3", txtquantity.Text);
                      var bnknokontrol = from tbl_kul_bnk in db.tbl_kul_bnk where tbl_kul_bnk.hesapno == txtbankno.Text select tbl_kul_bnk;
                       foreach (var knrl in bnknokontrol)
                      {
                          var gnd_hspno = knrl.id;
                          komut.Parameters.AddWithValue("@p4", gnd_hspno);
                          var gnd_kullaniciid = knrl.kullaniciid;
                          komut.Parameters.AddWithValue("@p5", gnd_kullaniciid);
                      }
                      komut.Parameters.AddWithValue("@p6", DateTime.Now.ToString());
                      komut.ExecuteNonQuery();
                      MessageBox.Show("Para Transferi Gerçekleşti.");
                      listele();
                        }                    }                }
                else
                {
                    MessageBox.Show("Lütfen Göndermek İstediğiniz Hesap no Ve İban No Kontrol Ediniz...!", "HESAP NO VEYA İBAN NO HATALI");
                }            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.ToString());
            }
        }

        void listele()
        {

            var bnknokontrol = from tbl_kul_bnk in db.tbl_kul_bnk where tbl_kul_bnk.hesapno == txtbankno.Text select tbl_kul_bnk;
            bnk.id = byte.Parse(cmbbnk.SelectedValue.ToString());
            var kisilelkontrol = from tbl_kullanici in db.tbl_kullanici where tbl_kullanici.tc == tc select tbl_kullanici;
            foreach (var z in kisilelkontrol)
            {
                var bank = byte.Parse(cmbbnk.SelectedValue.ToString());
                var bankKontrol = db.tbl_kul_bnk.Where(p => p.bankaid == bank).FirstOrDefault();
                if (bankKontrol != null)
                {

                    var hesapkontrol = from tbl_kul_bnk in db.tbl_kul_bnk where tbl_kul_bnk.kullaniciid == z.id select tbl_kul_bnk;
                    foreach (var y in hesapkontrol)
                    {
                        var bnkisim = y.bankaid;
                        var kullanici = y.kullaniciid;
                        lblaccountno.Text = y.hesapno;
                        lbliban.Text = y.iban;
                        bankaidnumarasi = y.id.ToString();
                        var bankakontrol = from tbl_Banka in db.tbl_Banka where tbl_Banka.id == bnkisim select tbl_Banka;

                        foreach (var s in bankakontrol)
                        {
                            dataGridView1.Columns.Clear();
                            if (bnk.id == s.id)
                            {
                                lblbankname.Text = s.bankaad;
                                var gecmiskontroltb = from tbl_kul_bnk in db.tbl_kul_bnk where tbl_kul_bnk.kullaniciid == y.kullaniciid || tbl_kul_bnk.hesapno == lblaccountno.Text select tbl_kul_bnk;
                                var gecmiskontrol = db.tbl_kullanicihareket.Where(p => p.alici_bnkid == y.id).ToList();
                                if (gecmiskontrol != null)
                                {
                                    SqlCommand komut3 = new SqlCommand(@"select hesapno,(ad+' '+soyad)as'GÖNDEREN KİŞİ',miktar from tbl_kullanicihareket kh inner join tbl_kul_bnk kb on kb.id = kh.gon_bnkid inner join tbl_kullanici k on k.id = kh.gon_klncid where  kh.gon_bnkid = @P2 or kh.alici_bnkid = @P2 ", conn.baglanti());

                                    komut3.Parameters.AddWithValue("@P2", y.id);
                                    SqlDataAdapter da = new SqlDataAdapter(komut3);
                                    DataTable dt = new DataTable();
                                    da.Fill(dt);
                                    SqlDataReader dreader = komut3.ExecuteReader();
                                    dataGridView1.DataSource = dt; 
                                    dataGridView1.RowHeadersVisible = false;
                                    dataGridView1.Rows[dataGridView1.NewRowIndex].Selected = true;
                                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.NewRowIndex;
                                    dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                    dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                    dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                                                                        
                                    for (int i = 0; i < dataGridView1.Rows.Count -1; i++)
                                    {
                                        while (dreader.Read())
                                        {
                                            DataGridViewCellStyle renk = new DataGridViewCellStyle();
                                            Application.DoEvents();
                                            if (Convert.ToInt32(dataGridView1.Rows[i].Cells["hesapno"].Value) == Convert.ToInt32(y.hesapno.ToString()))                                                
                                            {
                                                renk.BackColor = Color.Red;
                                                renk.ForeColor = Color.Yellow;
                                                dataGridView1.Rows[i].DefaultCellStyle = renk;
                                                i++;
                                            }
                                            else if (Convert.ToInt32(dataGridView1.Rows[i].Cells["hesapno"].Value) != Convert.ToInt32(y.hesapno.ToString()))
                                            {
                                                renk.BackColor = Color.Green;
                                                renk.ForeColor = Color.Yellow;
                                                dataGridView1.Rows[i].DefaultCellStyle = renk;
                                                i++;
                                            }
                                        }
                                    }
                                    SqlCommand komut = new SqlCommand("select sum(miktar) from tbl_kullanicihareket where alici_bnkid=@p1", conn.baglanti());
                                    komut.Parameters.AddWithValue("@p1", bankaidnumarasi);
                                    SqlCommand komut2 = new SqlCommand("select sum(miktar) from tbl_kullanicihareket where gon_bnkid=@p1", conn.baglanti());
                                    komut2.Parameters.AddWithValue("@p1", bankaidnumarasi);

                                    SqlDataReader dr = komut.ExecuteReader();
                                    SqlDataReader dr2 = komut2.ExecuteReader();

                                    while (dr.Read() && dr2.Read())
                                    {
                                        if (dr[0].ToString() == "" && dr2[0].ToString() != "")
                                        {
                                            decimal bakiye = decimal.Parse(0.ToString()) - decimal.Parse(dr2[0].ToString());
                                            lblbalance.Text = bakiye.ToString();

                                        }
                                        else if (dr2[0].ToString() == "" && dr[0].ToString() != "")
                                        {
                                            decimal bakiye = (decimal.Parse(dr[0].ToString()) - decimal.Parse(0.ToString()));
                                            lblbalance.Text = bakiye.ToString();
                                        }
                                        else if (dr2[0].ToString() == "" && dr[0].ToString() == "")
                                        {
                                            decimal bakiye = (decimal.Parse(0.ToString()) - decimal.Parse(0.ToString()));
                                            lblbalance.Text = bakiye.ToString();
                                        }
                                        else if (dr != null && dr2 != null)
                                        {
                                            decimal bakiye = (decimal.Parse(dr[0].ToString()) - decimal.Parse(dr2[0].ToString()));
                                            lblbalance.Text = bakiye.ToString();
                                        }                                 
                                    }
                                    return;
                                }   
                            }
                            if (bank != s.id)
                            {
                                lblaccountno.Text = "000000";
                                lbliban.Text = "00000";
                                lblbalance.Text = "000000";
                                lblbankname.Text = "000000";
                            }                        }                    }                }            }        }
        private void cmbbnk_SelectedIndexChanged(object sender, EventArgs e)
        {
            listele();
        }

   
    }
}
