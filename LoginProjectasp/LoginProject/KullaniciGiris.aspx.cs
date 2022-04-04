using LoginProject.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;

namespace LoginProject
{
    public partial class KullaniciGiris : System.Web.UI.Page
    {
        public string hash = "";
        public string Decrypt(string SifrelenmisDeger)
        {
            byte[] data = Convert.FromBase64String(SifrelenmisDeger);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }

        AspSiteEntities db = new AspSiteEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kayit_Click(object sender, EventArgs e)
        {
            Response.Redirect("KullaniciKayit.aspx");
        }

        protected void btn_giris_Click(object sender, EventArgs e)
        {
            var kadi = txt_kullaniciAdi.Text;
            var sifre =  Decrypt(txt_sifre.Text);
            var kullanici = db.accounts.FirstOrDefault(s => s.KullaniciAdi == kadi && s.Sifre == sifre);
            if (kullanici != null)
            {
                Response.Redirect("AnaSayfa.aspx");
            }
            else
                lbl_sonuc.Text = "Giriş Başarısız. Kullanıcı adı veya şifre hatalı!!";
        }
    }
}