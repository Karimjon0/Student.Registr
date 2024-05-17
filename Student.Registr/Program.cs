//----------------------------------------
// Great Code Team (c) All rights reserved
//---------------------------------------

using Student.Registr.Broker.Storeage;
using Student.Registr.Models;
using Student.Registr.Service;

StudentService studentService = new StudentService();
bool isContinue = true;
do
{
    Console.WriteLine("Menu     |");
    Console.WriteLine("-------------------------------------------------------------------------|");
    Console.WriteLine("Display student     |     Faind student     |     a     |     Add student|");
    Console.WriteLine("-------------------------------------------------------------------------|");
    string menu = Console.ReadLine();

    if (menu.Contains("1") is true)
    {
        Console.Write("Enter the id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        studentService.DisplayStudent(id);
    }

    if (menu.Contains("2") is true)
    {
        Console.Write("Enter the charector: ");
        char letter = Convert.ToChar(Console.ReadLine());
        studentService.CheckoutByLetter(letter);
    }

    if (menu.Contains("3") is true)
    {
        Console.Write("Enter the first name: ");
        string studentName = Console.ReadLine();
        studentService.CheckoutByName(studentName);
    }

    if (menu.Contains("4") is true)
    {
        StudenT student = new StudenT();
        Console.Write("Enter the id: ");
        student.Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the first name: ");
        student.FirstName = Console.ReadLine();
        Console.Write("Enter the last name: ");
        student.LastName = Console.ReadLine();
        Console.Write("Enter the age: ");
        student.Age = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the email: ");
        student.Email = Console.ReadLine();

        studentService.InsertStudent(student);
    }

    Console.Write("Is Continue: ");
    string isCommand = Console.ReadLine();

    if (isCommand.Contains("no") is true)
    {
        isContinue = false;
    }
    else if (isCommand.Contains("yes") is true)
    {
        isContinue = true;
        Console.Clear();
    }
    else
    {
        isContinue = false;
        Console.WriteLine("The command was issued incorrectly.");
    }
} while (isContinue is true);