﻿using System;
namespace DDD.Domain.Models
{
    /// <summary>
    /// 定义领域对象 Customer.
    /// </summary>
    public class Customer
    {
        protected Customer() { }
        public Customer(int id, string name, string email, DateTime birthDate)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
    }
}