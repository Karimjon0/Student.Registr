//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Broker;
using Student.Registr.Models;
namespace Student.Registr.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        IStudent PrintNameEmail(int id);
        List<StudenT> FindStudentName(char letter);
        StudenT FindStudentByName(string firstName);
        StudenT AddStudent(StudenT student);
    }
}
