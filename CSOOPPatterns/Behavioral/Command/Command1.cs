namespace CSOOPPatterns.Behavioral.Command
{
    public class Command1 : ICommand
    {
        private Receiver _receiver;
        private string _param;

        public Command1(Receiver receiver, string param)
        {
            _receiver = receiver;
            _param = param;
        }

        public void Execute()
        {
            _receiver.DoStuff(_param);
        }
    }
}