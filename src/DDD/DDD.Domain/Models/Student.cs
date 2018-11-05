using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DDD.Domain.Models
{
    public class Student
    {
        public Guid Id { get; private set; }

        public string Name { get; private set; }

        public string Email { get; private set; }

    }
}
