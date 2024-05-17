//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Models;

namespace Student.Registr.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        IStudent PrintNameAndEmail(int id);
        List<StudenT> FindStudentByLetter(char letter);
        StudenT FindStudentByName(string firstName);
        StudenT AddStudent(StudenT student);
    }
}