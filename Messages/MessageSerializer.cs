using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class MessageSerializer<T> : MessageSerializerBase
    where T : IMessage,
    new()
    {
        public MessageSerializer(IEncryption encryption) : base(encryption)
        {
        }

        public string Serialize(T obj) 
        {
            string temp = obj.Serialize();
            temp = Encryption.Encrypt(temp);
            return $"{obj.GetMark()}{Encryption.GetMark()} {temp}";
        }


        public T Deserialize(string text)
        {
            T instance = new T();
            if (text[0] != instance.GetMark())
            {
                throw new InvalidMessageException();
            }
            if (text[1] != Encryption.GetMark())
            {
                throw new InvalidMessageException();
            }
            text = text.Remove(0, 3);
            string temp = Encryption.Decrypt(text);
            instance.Deserialize(temp);
            return instance;
        }
    }
}
