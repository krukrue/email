using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class PasswordBasedEncryption : IEncryption
    {
        public string password { get; set; }
        public PasswordBasedEncryption(string pas)
        {
            try
            {
                if (pas == "")
                {
                    throw new InvalidPasswordException("You entered the wrong password. Try it again.");
                }
                else
                {
                    password = pas;
                }
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public string Encrypt(string text)
        {
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i >= password.Length)
                {
                    break;
                }
                int AsciCode = (int)text[i] + (int)password[i];
                temp = temp + (char)AsciCode;
            }
            return temp;
        }

        public string Decrypt(string text)
        {
            string temp = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (i >= password.Length)
                {
                    break;
                }
                int AsciCode = (int)text[i] - (int)password[i];
                try
                {
                    if ((AsciCode < 0))
                    {
                        throw new InvalidPasswordException("Mensi nez 0", text, password);
                    }
                    temp = temp + (char)AsciCode;
                } catch 
                {

                }
            }
            return temp;
        }

        public char GetMark()
        {
            return 'P';
        }

    }
}
