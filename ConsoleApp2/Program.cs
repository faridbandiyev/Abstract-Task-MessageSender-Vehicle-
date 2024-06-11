
using ConsoleApp2;

while (true)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Send message by email");
    Console.WriteLine("2. Send message by sms");
    Console.WriteLine("0. Quit");
    Console.WriteLine();
    Console.Write("Choose a numeric command: ");
    string choice = Console.ReadLine();
    Console.Clear();

    switch (choice)
    {
        case "1":
            EmailSender emailSender = new EmailSender();
            emailSender.Send();
            break;

        case "2":
            SmsSender smsSender = new SmsSender();
            smsSender.Send();
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Present a valid numeric code!");
            break;
    }

}


//if (Choice == 1)
//{
//    EmailSender emailSender = new EmailSender();
//    emailSender.Send();
//}
//if (Choice == 2)
//{
//    SmsSender smsSender = new SmsSender();
//    smsSender.Send();
//}
//if(Choice == 0)
//    break;