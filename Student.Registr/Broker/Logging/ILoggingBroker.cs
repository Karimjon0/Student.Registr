//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

namespace Student.Registr.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogInformation(string message);
        void LogError(string message);
    }
}