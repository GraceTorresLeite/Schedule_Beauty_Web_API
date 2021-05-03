using System;
using System.Collections.Generic;
using WebServiceApi.Hypermedia;
using WebServiceApi.Hypermedia.Abstract;
using WebServiceApi.Models;

namespace WebServiceApi.Data.VO
{
    public class ScheduleFormVO : ISupportsHypermedia
    {

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Service { get; set; }
        public DateTime Date { get; set; }
        public bool Enabled { get; set; }
        public List<HypermediaLink> Links { get; set; } = new List<HypermediaLink>();

        public ScheduleFormVO()
        {

        }
        public TypeServices GetService(int service)
        {
            return (TypeServices)ServiceTypeWrapper.ServiceTypeById(service);
        }

        public void SetService(TypeServices types)
        {
            this.Service = types.GetHashCode();
        }
    }
}
