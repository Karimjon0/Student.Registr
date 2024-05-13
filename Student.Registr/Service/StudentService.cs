//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Broker.Logging;
using Student.Registr.Broker.Storeage;
using Student.Registr.Models;
namespace Student.Registr.Service
{
    internal class StudentService
    {
        private readonly ILoggingBroker loggingBroker;
        private readonly IStoreageBroker storeageBroker;
        private LoggingBroker loggingBroker1;

        public StudentService(ILoggingBroker loggingBroker)
        {
            this.loggingBroker = loggingBroker;
            this.storeageBroker = new ListStoreageBroker();
        }

        public StudentService(LoggingBroker loggingBroker1)
        {
            this.loggingBroker1 = loggingBroker1;
        }

        public StudenT InsertBook(StudenT student)
        {
            return student is null
                    ? InsertStudentIsInvalid()
                    : ValidationAndInsertStudent(student);
        }

        private StudenT ValidationAndInsertStudent(StudenT student)
        {
            throw new NotImplementedException();
        }

        public bool Update(StudenT student)
        {
            return student is null
                ? InvalidUpdate()
                : ValidationAndUpdate(student);
        }

        private bool ValidationAndUpdate(StudenT student)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            return id is 0
                  ? InvalidDeleteId()
                  : ValidationAndDelete(id);
        }

        private StudenT ValidationAndGetStudent(int id)
        {
            if (String.IsNullOrWhiteSpace(id.ToString()))
            {
                this.loggingBroker.LogError("Information is invalid.");
                return new StudenT();
            }
            else
            {
                StudenT studentInfo = this.storeageBroker.ReadStudent(id);

                if (studentInfo is null)
                {
                    this.loggingBroker.LogError("Not Found.");
                }
                else
                {
                    this.loggingBroker.LogInformation("Sucssesfull.");
                }
                return studentInfo;
            }
        }

        private StudenT InvalidGetStudentById()
        {
            this.loggingBroker.LogInformation("Id is invalid.");
            return new StudenT();
        }

        private bool InvalidUpdate()
        {
            this.loggingBroker.LogError("Book information is incomplete.");
            return false;
        }

        private bool ValidationAndDelete(int id)
        {
            bool isDelete = this.storeageBroker.Delete(id);

            if (isDelete is true)
            {
                this.loggingBroker.LogInformation("The information in the id has been deleted.");
                return isDelete;
            }
            else
            {
                this.loggingBroker.LogError("Id is Not Found.");
                return isDelete;
            }
        }

        private bool InvalidDeleteId()
        {
            this.loggingBroker.LogError("The id information is invalid.");
            return false;
        }
        private StudenT InsertStudentIsInvalid()
        {
            this.loggingBroker.LogError("Book info is null.");
            return new StudenT();
        }
    }
}
