using System;
using DDD.Domain.Core.Models;

namespace DDD.Domain.Models
{
    public class Student:Entity
    {
        protected Student(){}
        public Student(Guid id,string name,string email,DateTime birthDate)
        {
            this.Id = id;
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        //public Guid Id { get; set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

        public string Phone { get; private set; }

        public DateTime BirthDate { get; private set; }

        public Address Address { get; private set; }

    }
}
