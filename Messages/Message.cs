using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class Message : IMessage
    {
        public string Text;
        public Message()
        {

        }
        public Message(string text)
        {
            Text = text;
        }

        public string Serialize()
        {
            return Text;
        }
        public void Deserialize(string text)
        {
            Text = text;
        }
        public char GetMark()
        {
            return 'T';
        }
    }
}
