using System;

namespace Module_18._4_Task_2
{
    class Program
    {
        static void Main()
        {
            var client = new Client("https://www.youtube.com/watch?v=vit9ZYPl-cs", "vit9ZYPl-cs");

            var informationVideoCommand = new InformationVideoCommand(client);
            var downloadVideoCommand = new DownloadVideoCommand(client);

            var sender = new Sender();

            sender.SetCommand(informationVideoCommand);
            sender.Run();
            sender.SetCommand(downloadVideoCommand);
            sender.Run();

            Console.ReadLine();
        }
    }
}
