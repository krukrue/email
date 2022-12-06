using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messages
{
    public class EmailMessage : IMessage
    {
        public string Email;
        public string Text;
        public EmailMessage()
        {

        }
        public EmailMessage(string email, string text)
        {
            Email = email;
            Text = text;
        }

        public string Serialize()
        {
            return $"{Email}:{Text}";
        }
        public void Deserialize(string textEmail)
        {
            string[] temp;
            temp = textEmail.Split(":");
            Email = temp[0];
            Text = temp[1];
        }
        public char GetMark()
        {
           
            return 'E';
        
        }


    }
}
