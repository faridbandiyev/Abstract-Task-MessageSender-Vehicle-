using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class EmailSender : MessageSender
    {
        public override void Send()
        {
            Console.WriteLine("Email ile mesaj gonderildi.");
        }
    }
}
