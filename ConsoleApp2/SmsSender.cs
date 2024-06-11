using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SmsSender : MessageSender
    {
        public override void Send()
        {
            Console.WriteLine("Sms ile mesaj gonderildi.");
        }
    }
}
