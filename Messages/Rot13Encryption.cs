using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Rot13Encryption : IEncryption
    {
        public string Encrypt(string text)
        {
            string temp = "";
            foreach(char c in text)
            {
                temp = temp + Rot13(c);
            }
            return temp;
        }

        public string Decrypt(string text)
        {
            string temp = "";
            foreach (char c in text)
            {
                temp = temp + Rot13(c);
            }
            return temp;
        }

        public char GetMark()
        {
            return 'R';
        }



        private char Rot13(char letter)
        {
            if (letter >= 'A' && letter <= 'Z')
            {
                letter = (char)('A' + (letter - 'A' + 13) % 26);
            }
            else if (letter >= 'a' && letter <= 'z')
            {
                letter = (char)('a' + (letter - 'a' + 13) % 26);
            }
            return letter;
        }
    }


}


