using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeeamAcademyLabs
{
    /// <summary>
    /// Task 1. Create an immutable type
    /// Whenever a property changes, new object is returned;
    /// </summary>
    public class ImmutablePerson
    {
        private readonly DateTime _birthDate;
        private readonly string _lastName;
        private readonly string _firstName;

        public DateTime BirthDate { get { return _birthDate; } }

        public string LastName { get { return _lastName; } }

        public string FirstName { get { return _firstName; } }

        public ImmutablePerson(DateTime birthDate, string lastName, string firstName)
        {
            this._birthDate = birthDate;
            this._lastName = lastName;
            this._firstName = FirstName;
        }

        public ImmutablePerson SetBirthDate(DateTime newBirthDate)
        {
            return new ImmutablePerson(newBirthDate, LastName, FirstName);
        }

        public ImmutablePerson SetLastName(string newLastName)
        {
            return new ImmutablePerson(BirthDate, newLastName, FirstName);
        }

        public ImmutablePerson SetFirstName(string newFirstName)
        {
            return new ImmutablePerson(BirthDate, LastName, newFirstName);
        }
    }

    interface StructInterface
    {
        int MethodA();
    }


    /// <summary>
    /// Task 2. Imitating inheritance and method overriding in structs
    /// </summary>
    public struct BaseStruct : StructInterface
    {
        public int MethodA()
        {
            return 6;
        }
    }

    public struct ChildStruct : StructInterface
    {
        public int MethodA()
        {
            return 8;
        }
    }
}
