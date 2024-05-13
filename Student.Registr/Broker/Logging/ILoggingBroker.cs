//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

namespace Student.Registr.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogError(string v);
        void LogInformation(string v);
    }
}
