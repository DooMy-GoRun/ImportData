using System;

namespace ImportData.IntegrationServicesClient.Exceptions
{
    public class FoundMatchesException : Exception
    {
        public FoundMatchesException(string message) : base(message) { }
    }
}
