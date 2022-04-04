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
    public partial class KullaniciKayit : System.Web.UI.Page
    {
        public string hash = "";
        public string sifree = "";

        public string Encrypt(string sifre)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(sifre);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        AspSiteEntities db = new AspSiteEntities();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_kaydet_Click(object sender, EventArgs e)
        {
            accounts kullanici = new accounts()
            { 
                Ad = txt_adi.Text,
                Soyad = txt_soyadi.Text,
                Email = txt_email.Value, 
                KullaniciAdi = txt_kullaniciAdi.Value,
                Sifre=Encrypt(txt_sifre.Value),
            };
            db.accounts.Add(kullanici);
            db.SaveChanges();
        }
    }
}