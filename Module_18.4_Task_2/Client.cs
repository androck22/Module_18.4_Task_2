
namespace Module_18._4_Task_2
{
    class Client
    {
        public string VideoUrl { get; set; }
        public string StreamManifest { get; set; }

        public Client(string videoUrl, string streamManifest)
        {
            VideoUrl = videoUrl;
            StreamManifest = streamManifest;
        }
        
    }
}
