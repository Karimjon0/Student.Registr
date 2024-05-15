//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------


namespace Student.Registr.Broker.Logging
{
    internal interface ILoggingBroker
    {
        void LogError(string v);
        void LogError(Exception exception);
        void LogInfo(object value);
        void LogInformation(string v);
    }
}
