using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Mailbox
    {
        public MessageQueue<String> que;
        public List<MessageSerializerBase> list = new();
        public Mailbox(MessageQueue<String> temp)
        {
            que = temp;
        }
        public void SendMessage<T>(MessageSerializer<T> ms, T obj) where T : IMessage, new()
        {
            que.Enqueue(ms.Serialize(obj)); 
        }

        public void RegisterSerializer(MessageSerializerBase Obj)
        {
            list.Add(Obj);
        }

        public bool TryReceive<T>(string serzText, out T param) where T : IMessage, new()
        {
            foreach (MessageSerializerBase Obj in list)
            {
                if (Obj is MessageSerializer<T> temp)
                {
                    try
                    {
                         param = temp.Deserialize(serzText);
                         return true;


                        }
                    catch (InvalidMessageException)
                    {
                        continue;
                    }

                }
            }
            param = default;
            return false;
        }
    }
}
