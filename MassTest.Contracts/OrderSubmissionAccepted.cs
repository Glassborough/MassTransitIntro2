namespace MassTest.Contracts
{
    public interface OrderSubmissionAccepted
    {
        Guid OrderId { get; }
        DateTime? Timestamp { get; }
        public string CustomerNumber { get; }


    }
}
