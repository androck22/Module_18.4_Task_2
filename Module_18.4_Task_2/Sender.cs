
namespace Module_18._4_Task_2
{
    class Sender
    {
        YouTubeCommand _command;

        public void SetCommand(YouTubeCommand command)
        {
            _command = command;
        }

        public void Run()
        {
            _command.Run();
        }
    }
}
