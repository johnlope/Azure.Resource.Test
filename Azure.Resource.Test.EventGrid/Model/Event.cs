using System;

namespace Azure.Resource.Test.EventGrid.Model
{
    public class GridEvent 
    {
        public Guid Id { get; set; }
        public string Subject { get; set; }
        public string EventType { get; set; }
        public object Data { get; set; }
        public DateTime EventTime { get; set; }
    }
}
