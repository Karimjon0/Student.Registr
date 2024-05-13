//----------------------------------------
// Great Code Team (c) All rights reserved
//----------------------------------------

using Student.Registr.Broker;
using Student.Registr.Models;
namespace Student.Registr.Broker.Storeage
{
    internal interface IStoreageBroker
    {
        bool Delete(int id);
        StudenT[] GetAllStudent();
        StudenT GetStudent(int id);
    }
}
