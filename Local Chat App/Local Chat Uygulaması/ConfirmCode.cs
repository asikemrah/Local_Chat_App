using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Local_Chat_Uygulaması
{
    public class ConfirmCode
    {
        public string rastgele()
        {
            Random r = new Random();
            string deger = "1234567890QWERTYUIOPĞÜASDFGHJKLŞİZXCVBNMÖÇqwertyuıopğüasdfghjklşizxcvbnmöç";
            string code = "";
            for (int i = 0; i < 5; i++)
            {
                code += deger[r.Next(deger.Length)];
            }
            return code;
        }
    }
}
