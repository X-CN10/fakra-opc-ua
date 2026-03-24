namespace WebApiOpcServer.Model
{
    public class res
    {
        public bool Suscess { get; set; }
        public string Message { get; set; }
    }
    public class EventParam
    {
        public UInt32 JobId { get; set; }
        public UInt32 GoodPartCount { get; set; }
        public UInt32 BadPartCount { get; set; }
    }
    
    public class BatchFinishedEventParam : EventParam
    {
        public UInt32 BatchSequenceNumber { get; set; }
    }
    public class WireFinishedEventParam : BatchFinishedEventParam
    {
        public UInt32 WireSequenceNumber { get; set; }
    }
}
