using DeviceManagement_WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface ICategoriesRepository : IGenericRepository<Category>
    {
        public Category GetMostRecent();
        public bool CategoryExists(Guid id);
    }
}
