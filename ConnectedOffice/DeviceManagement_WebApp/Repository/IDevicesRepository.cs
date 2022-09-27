using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDevicesRepository : IGenericRepository<Device>
    {
        public Device GetMostRecent();
        public bool DeviceExists(Guid id);
        public SelectList GetCategory();
        public SelectList GetZone();
        public SelectList UpdateCategory(Guid? id);
        public SelectList UpdateZone(Guid? id);
    }

}
