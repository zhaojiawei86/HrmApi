﻿using System;
using System.ComponentModel.DataAnnotations;
using Hrm.ApplicationCore.Contract.Repository;
using Hrm.ApplicationCore.Contract.Service;
using Hrm.ApplicationCore.Entity;
using Hrm.ApplicationCore.Model.Request;
using Hrm.ApplicationCore.Model.Response;
using Hrm.Infrastructure.Repository;

namespace Hrm.Infrastructure.Service
{
	public class EmployeeTypeServiceAsync : IEmployeeTypeServiceAsync
    {
        private readonly IEmployeeTypeRepositoryAsync employeeTypeRepositoryAsync;

        public EmployeeTypeServiceAsync(IEmployeeTypeRepositoryAsync _employeeTypeRepositoryAsync)
		{
            employeeTypeRepositoryAsync = _employeeTypeRepositoryAsync;
        }

        // async for insert is not necessory, speed up
        public Task<int> AddAsync(EmployeeTypeRequestModel model)
        {
            EmployeeType employeeType = new EmployeeType()
            {
                Title = model.Title,
                description = model.description,
                IsActive = model.IsActive
            };
            return employeeTypeRepositoryAsync.InsertAsync(employeeType);
        }

        public Task<int> DeleteAsync(int id)
        {
            return employeeTypeRepositoryAsync.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmployeeTypeResponseModel>> GetAllAsync()
        {
            var result = await employeeTypeRepositoryAsync.GetAllAsync();
            if (result != null)
            {
                return result.ToList().Select(x => new EmployeeTypeResponseModel()
                {
                    Id = x.Id,
                    Title = x.Title,
                    description = x.description,
                    IsActive = x.IsActive
                });
            }
            return null;
            
        }

        public async Task<EmployeeTypeResponseModel> GetByIdAsync(int id)
        {
            var result = await employeeTypeRepositoryAsync.GetByIdAsync(id);
            if (result != null)
            {
                return new EmployeeTypeResponseModel()
                {
                    Id = result.Id,
                    Title = result.Title,
                    description = result.description,
                    IsActive = result.IsActive
                };
            }
            return null;
        }

        public async Task<int> UpdateAsync(EmployeeTypeRequestModel model)
        {
            EmployeeType employeeType = new EmployeeType()
            {
                Id = model.Id,
                Title = model.Title,
                description = model.description,
                IsActive = model.IsActive
            };
            return await employeeTypeRepositoryAsync.UpdateAsync(employeeType);
        }
    }
}

