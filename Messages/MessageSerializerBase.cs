using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    abstract public class MessageSerializerBase
    {
        public IEncryption Encryption { get; set; }
        public MessageSerializerBase(IEncryption encryption)
        {
            Encryption = encryption;
        }
    }
}
