﻿using System;
using System.Collections.Generic;
using DDD.Application.ViewModels;

namespace DDD.Application.Interfaces
{
    public interface IStudentAppService : IDisposable
    {
        void Register(StudentViewModel studentViewModel);

        IEnumerable<StudentViewModel> GetAll();

        StudentViewModel GetById(Guid id);

        void Update(StudentViewModel studentViewModel);

        void Remove(Guid id);
    }
}
