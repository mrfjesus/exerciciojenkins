using System.ComponentModel.Design;

namespace Lib
{
    public class Saudacao
    {
        public static string Cumprimentar(String value, DateTime dateTime)
        {
            String result = "";
            DateTime dt = DateTime.Now;
            if(dt.Hour<=12)
            {
                result = "Bom dia" + value;
            }
            else if(dt.Hour<=20)
            {
                    result = "Boa tarde" + value;

            }
                else                
                {
                    result = "Boa noite" + value;

                }
            return result;
        }

    }
}