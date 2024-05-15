//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Models;
using Student.Registr.Service;
using Student.Registr.Broker.Logging;
using static System.Reflection.Metadata.BlobBuilder;


IStudentService studentService = new StudentService();

Console.WriteLine("Menu     |");
Console.WriteLine("-------------------------------------------------------------------------|");
Console.WriteLine("Display student     |     Faind student     |     a     |     Add student|");
Console.WriteLine("-------------------------------------------------------------------------|");
string menu = Console.ReadLine();

if (menu == "1")
{
    Console.WriteLine("Enter id: ");
    int id = Convert.ToInt32(Console.ReadLine());
    studentService.DisplayStudent(id);
}

if (menu == "2")
{
    Console.WriteLine("Enter name: ");
    string studentName = Console.ReadLine();
    studentService.CheckoutByName(studentName);
}

if (menu == "3")
{
    IEnumerable<StudenT> persons = null;
    foreach (StudenT person in persons)
    {
        string str1 = person.FirstName.ToLower();
        bool result = str1.Contains("a");
        if (result == true)
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -  - - - - - - - -");
        };
    }
}

if (menu == "4")
{
    StudenT studentInfo = new StudenT();
    Console.Write("Enter id: ");
    studentInfo.Id = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter first name: ");
    studentInfo.FirstName = Console.ReadLine();
    Console.Write("Enter last name: ");
    studentInfo.LastName = Console.ReadLine();
    Console.Write("Enter age: ");
    studentInfo.Age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter email: ");
    studentInfo.Email = Console.ReadLine();

    studentService.InsertRangeStudent(studentInfo);
}

