//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Registr.Models;

namespace Student.Registr.Service
{
    internal interface IStudentService
    {
        IStudent DisplayStudent(int id);
        List<StudenT> CheckoutByLetter(char letter);
        StudenT CheckoutByName(string firstName);
        StudenT InsertStudent(StudenT student);
    }
}