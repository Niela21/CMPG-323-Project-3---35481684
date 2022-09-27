using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZonesRepository : IGenericRepository<Zone>
    {
        public bool ZoneExists(Guid id);
    }
}
