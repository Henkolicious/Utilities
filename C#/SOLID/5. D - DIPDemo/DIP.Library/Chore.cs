namespace DIP.Library
{
    public class Chore : IChore
    {
        private ILogger _logger;
        private IMessageSender _messageSender;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger logger, IMessageSender messageSender)
        {
            _logger = logger;
            _messageSender = messageSender;
        }

        public void PreformedWork(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"Log: Preformed work on { ChoreName }");
        }

        public void CompleteChore()
        {
            IsComplete = true;
            _logger.Log($"Logg: Completed { ChoreName }");
            _messageSender.SendMessage(Owner, $"The chore { ChoreName} is complete.");
        }
    }
}
