using System;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;
using DDD.Insfrastructure.Data.Context;

namespace DDD.Insfrastructure.Data.Repository
{
    public class StudentRepository:Repository<Student>,IStudentRepository
    {
        public StudentRepository(StudyContext context):base(context)
        {
            
        }
    }
}
