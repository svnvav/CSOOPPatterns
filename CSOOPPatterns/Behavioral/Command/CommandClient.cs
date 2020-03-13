namespace CSOOPPatterns.Behavioral.Command
{
    public class CommandClient
    {
        public void DoStuff()
        {
            var invoker = new Invoker();
            var receiver = new Receiver();
            
            var command = new Command1(receiver, "CommandStuff 1");
            
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
            
            command = new Command1(receiver, "CommandStuff 2");
            
            invoker.SetCommand(command);
            invoker.ExecuteCommand();
        }
    }
}