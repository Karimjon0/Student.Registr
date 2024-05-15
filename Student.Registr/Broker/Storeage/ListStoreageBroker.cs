//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace Student.Registr.Broker.Storeage
{
    internal class ListStoreageBroker : IStoreageBroker
    {
        private List<StudenT> StudentsInfo { get; set; } = new List<StudenT>();

        List<StudenT> persons = new List<StudenT>()
        {

            new StudenT()
            {

                Id = 1,
                FirstName = "Karimjon",
                LastName = "Abidjonov",
                Age = 14,
                Email = "karimjon@gmail.com"
            },
            new StudenT()
            {
                Id = 2,
                FirstName = "Ozodbek",
                LastName = "Jovliyev",
                Age = 14,
                Email = "ozodceek12@gmail.com"
            },
        };

        List<StudenT> people = new List<StudenT>()
        {
            new StudenT()
            {
                Id = 4,
                FirstName = "Doston",
                LastName = "Ergashev",
                Age = 32,
                Email = "ergashev@gmail.com"
            },
            new StudenT()
            {
                Id = 5,
                FirstName = "Ibirohim",
                LastName = "Amirov",
                Age = 13,
                Email = "amirovibirohm@gmail.com"
            },
            new StudenT()
            {
                Id = 6,
                FirstName = "Akbarjon",
                LastName = "Eshpulatov",
                Age = 14,
                Email = "akbarjon2010@gmail.com"
            }
        };
        public StudenT ReadStudent(int id)
        {
            for (int itaration = 0; itaration <= StudentsInfo.Length; itaration++)
            {
                StudenT studentInfoLine = StudentsInfo[itaration];
                if (studentInfoLine.Id == id)
                {
                    return studentInfoLine;
                }
            }
            return new StudenT();
        }
        public StudenT[] GetAllStudent() => StudentsInfo;

        public StudenT AddStudent(StudenT student)
        {
            for (int itaration = 0; itaration < StudentsInfo.Length; itaration++)
            {
                if (StudentsInfo[itaration] is null)
                {
                    var bookInfo = new StudenT()
                    {
                        Id = student.Id,
                        FirstName = student.FirstName,
                        LastName = student.LastName,
                        Age = student.Age,
                        Email = student.Email,
                    };
                    StudentsInfo[itaration] = bookInfo;
                    return student;
                }
            }
            return new StudenT();
        }

        public bool Update(StudenT student)
        {
            for (int itaration = 0; itaration <= StudentsInfo.Length; itaration++)
            {
                StudenT studentInfoLine = StudentsInfo[itaration];
                if (studentInfoLine.Id == student.Id)
                {
                    studentInfoLine.FirstName = student.FirstName;
                    studentInfoLine.LastName = student.LastName;
                    StudentsInfo[itaration] = studentInfoLine;
                    return true;
                }
            }
            return false;
        }

        public bool Delete(int id)
        {
            for (int itaration = 0; itaration < StudentsInfo.Length; itaration++)
            {
                if (StudentsInfo[itaration] is not null)
                {
                    StudenT bookInfo = StudentsInfo[itaration];
                    if (bookInfo.Id == id)
                    {
                        StudentsInfo[itaration] = new StudenT();
                        return true;
                    }

                }

            }
            return false;
        }

        List<StudenT> IStoreageBroker.GetAllClothes()
        {
            throw new NotImplementedException();
        }

        StudenT IStoreageBroker.GetClothes(int id)
        {
            throw new NotImplementedException();
        }

        public StudenT UpdateClothes(int id, StudenT clothes)
        {
            throw new NotImplementedException();
        }

        public StudenT AddClothes(StudenT clothes)
        {
            throw new NotImplementedException();
        }

        public List<StudenT> AddRangeClothes(List<StudenT> clothes)
        {
            throw new NotImplementedException();
        }

        List<StudenT> IStoreageBroker.SoldInformationClothes()
        {
            throw new NotImplementedException();
        }

        public bool DeleteClothes(int id)
        {
            throw new NotImplementedException();
        }

        public void PurchaseClothes(string productType)
        {
            throw new NotImplementedException();
        }
    }
}
