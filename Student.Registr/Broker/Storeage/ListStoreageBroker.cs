//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Models;

namespace Student.Registr.Broker.Storeage
{
    internal class ListStoreageBroker : IStoreageBroker
    {
        private List<StudenT> students = new List<StudenT>();
        public ListStoreageBroker()
        {
            this.students.Add(new StudenT()
            {
                Id = 1,
                FirstName = "Karimjon",
                LastName = "Abidjonov",
                Age = 14,
                Email = "Karimjon0@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 2,
                FirstName = "Inomjon",
                LastName = "Safarov",
                Age = 14,
                Email = "Inomjon12@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 3,
                FirstName = "Saidjon",
                LastName = "Jalolov",
                Age = 14,
                Email = "Saidjon32@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 4,
                FirstName = "Ozodbek",
                LastName = "Jovliyev",
                Age = 12,
                Email = "Jovliyev23@gmail.com"
            });
            this.students.Add(new StudenT()
            {
                Id = 5,
                FirstName = "Ibirihim",
                LastName = "Amirov",
                Age = 13,
                Email = "Amirov12@gmail.com"
            });
        }

        public StudenT AddStudent(StudenT student)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.Id == student.Id
                    && studentItem.Email == student.Email)
                {
                    return new StudenT();
                }
            }

            this.students.Add(student);
            return student;
        }

        public StudenT FindStudentByName(string firstName)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.FirstName == firstName)
                {
                    return studentItem;
                }
            }
            return new StudenT();
        }

        public List<StudenT> FindStudentByLetter(char letter)
        {
            List<StudenT> studentNew = new List<StudenT>();
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.FirstName.Contains(letter))
                {
                    studentNew.Add(studentItem);
                }
            }
            return studentNew;
        }

        public IStudent PrintNameAndEmail(int id, StudenT studentItem)
        {
            foreach (StudenT studentItem in this.students)
            {
                if (studentItem.Id == id)
                {
                    var studentInfo = new IStudent()
                    {
                        FirstName = studentItem.FirstName,
                        Email = studentItem.Email
                    };
                    return studentInfo;
                }
            }
            return new IStudent();
        }

        IStudent IStoreageBroker.PrintNameAndEmail(int id)
        {
            throw new NotImplementedException();
        }
    }
}