using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public interface IEncryption
    {
        public string Encrypt(string text);
        public string Decrypt(string text);

        public char GetMark();
    }
}
