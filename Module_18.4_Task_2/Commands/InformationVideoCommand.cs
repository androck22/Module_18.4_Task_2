using System;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module_18._4_Task_2
{
    class InformationVideoCommand : YouTubeCommand
    {
        private readonly string _url;

        public InformationVideoCommand(string url)
        {
            _url = url;
        }

        public override void Run()
        {
            _ = GetVideoInformation();
        }

        public async Task GetVideoInformation()
        {
            var youtube = new YoutubeClient();

            var video = await youtube.Videos.GetAsync(_url);

            var title = video.Title;
            var description = video.Description;

            Console.WriteLine($"Название: \n\n{title}\n\n\nОписание: \n\n{description}");
        }


    }
}
