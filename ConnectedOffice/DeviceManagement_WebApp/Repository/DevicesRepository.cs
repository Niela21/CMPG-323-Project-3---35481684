using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class DevicesRepository : GenericRepository<Device>, IDevicesRepository
    {
        public DevicesRepository(ConnectedOfficeContext context) : base(context)
        {
        }
        //This method checks if the device exists based on the id
        public bool DeviceExists(Guid id)
        {
            return _context.Device.Any(e => e.CategoryId == id); ;
        }
        //order descending
        public Device GetMostRecent()
        {
            return _context.Device.OrderByDescending(Device => Device.DateCreated).FirstOrDefault(); ;
        }
        //returns a selectlist for categories viewdata
        public SelectList GetCategory()
        {
            SelectList category = new SelectList(_context.Category, "CategoryId", "CategoryName");
            return category;
        }
        //returns a selectlist for zones viewdata
        public SelectList GetZone()
        {
            SelectList zone = new SelectList(_context.Zone, "ZoneId", "ZoneName");
            return zone;
        }
        //returns a category selectlist  based on the id for the update method
        public SelectList UpdateCategory(Guid? id)
        {
            var device = this.GetById(id);
            SelectList cateegory = new SelectList(_context.Category, "CategoryId", "CategoryName", device.CategoryId);
            return cateegory;
        }
        //returns a zone selectlist  based on the id for the update method
        public SelectList UpdateZone(Guid? id)
        {
            var device = this.GetById(id);
            SelectList zone = new SelectList(_context.Zone, "ZoneId", "ZoneName", device.ZoneId);
            return zone;
        }
    }
}
