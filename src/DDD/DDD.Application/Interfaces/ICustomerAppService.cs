﻿using System;
using System.Collections.Generic;
using DDD.Application.ViewModels;

namespace DDD.Application.Interfaces
{
    /// <summary>
    /// 定义 ICustomerAppService 服务接口
    /// 并继承IDisposable，显式释放资源
    /// 注意这里我们使用的对象，是视图对象模型
    /// </summary>
    public interface ICustomerAppService:IDisposable
    {
        void Register(CustomerViewModel customerViewModel);

        IEnumerable<CustomerViewModel> GetAll();

        CustomerViewModel GetById(int id);

        void Update(CustomerViewModel customerViewModel);

        void Remove(int id);
    }
}
