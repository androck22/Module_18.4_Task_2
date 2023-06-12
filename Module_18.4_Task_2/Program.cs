using System;

namespace Module_18._4_Task_2
{
    class Program
    {
        static void Main()
        {
            var url ="https://www.youtube.com/watch?v=vit9ZYPl-cs";

            var informationVideoCommand = new InformationVideoCommand(url);
            var downloadVideoCommand = new DownloadVideoCommand(url);

            var sender = new Sender();

            sender.SetCommand(informationVideoCommand);
            sender.Run();
            sender.SetCommand(downloadVideoCommand);
            sender.Run();

            Console.ReadLine();
        }
    }
}
