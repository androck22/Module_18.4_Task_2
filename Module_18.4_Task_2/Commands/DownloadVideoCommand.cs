using AngleSharp;
using System;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace Module_18._4_Task_2
{
    class DownloadVideoCommand : YouTubeCommand
    {
        private readonly string _url;

        public DownloadVideoCommand(string url)
        {
            _url = url;
        }

        public override void Run()
        {
            _ = DownloadVideo();
        }

        public async Task DownloadVideo()
        {
            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(_url);
            var streamManifest = await youtube.Videos.Streams.GetManifestAsync(video.Id);
            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            await youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}");
        }
    }
}
