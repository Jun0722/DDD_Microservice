using System;
using System.Collections.Generic;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using DDD.Application.Interfaces;
using DDD.Application.ViewModels;
using DDD.Domain.Interfaces;
using DDD.Domain.Models;

namespace DDD.Application.Services
{
    /// <summary>
    /// StudentAppService 服务接口实现类,继承 服务接口
    /// 通过 DTO 实现视图模型和领域模型的关系处理
    /// 作为调度者，协调领域层和基础层，
    /// 这里只是做一个面向用户用例的服务接口,不包含业务规则或者知识
    /// </summary>
    public class StudentAppService:IStudentAppService
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IMapper _mapper;
        public StudentAppService(IStudentRepository studentRepository,IMapper mapper)
        {
            _studentRepository = studentRepository;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<StudentViewModel> GetAll()
        {
            return (_studentRepository.GetAll()).ProjectTo<StudentViewModel>();
        }

        public StudentViewModel GetById(Guid id)
        {
            return _mapper.Map<StudentViewModel>(_studentRepository.GetById(id));
        }

        public void Register(StudentViewModel studentViewModel)
        {
            //判断是否为空等等 还没有实现
            _studentRepository.Add(_mapper.Map<Student>(studentViewModel));
        }

        public void Remove(Guid id)
        {
            _studentRepository.Remove(id);
        }

        public void Update(StudentViewModel studentViewModel)
        {
            _studentRepository.Update(_mapper.Map<Student>(studentViewModel));
        }
    }
}
