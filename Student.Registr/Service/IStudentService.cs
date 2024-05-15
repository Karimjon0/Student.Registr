//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Models;
namespace Student.Registr.Service
{
    internal interface IStudentService
    {
        IStudent DisplayStudent(int id);
        List<StudenT> CheckoutByLetter(char letter);
        StudenT CheckoutByName(string firstName);
        StudenT InsertStudent(StudenT student);
        StudenT ReadStudent(int id);
        bool Delete(int id);
        StudenT Update(int id, StudenT clothes);
        StudenT InsertStudent(StudenT clothes);
        List<StudenT> InsertRangeStudent(List<StudenT> clothes);
        void Purchase(string model);
        List<StudenT> SoldInformation();
        void DisplayStudent(object id);
        void InsertRangeStudent(StudenT studentInfo);
    }
}
