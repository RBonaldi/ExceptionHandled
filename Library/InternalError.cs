using System;

namespace ExceptionsLibrary
{
    public class InternalError
    {
        public Guid LogEntryId { get; set; }
        public Exception Exception { get; set; }
    }
}
