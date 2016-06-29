using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostApp.Utilities.PassOperations
{
  public  class PassOperations
    {
        public static string Base64Encrypt(string veri)
        {
            try
            {
                byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
                string sifrelenmisveri = System.Convert.ToBase64String(veriByteDizisi);
                return sifrelenmisveri;
            }
            catch (Exception)
            {

                return veri;
            }
        }

        public static string Base64Decrypt(string CozVeri)
        {
            try
            {
                byte[] cozByteDizi = System.Convert.FromBase64String(CozVeri);
                string orjinalveri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
                return orjinalveri;
            }
            catch (Exception)
            {

                return CozVeri;
            }
        }

    }
}
