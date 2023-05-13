using System;
namespace CommandExample
{
    /// <summary>
    /// Конкретная реализация команды
    /// </summary>
    class CommandOne : Command
	{
        Receiver receiver;
		public CommandOne(Receiver receiver)
		{
            this.receiver = receiver;
		}

        public override void Cancel()
        {
            
        }

        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }
    }
}

