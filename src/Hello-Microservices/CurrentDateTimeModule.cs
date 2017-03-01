using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nancy;

namespace Hello_Microservices
{
    public class CurrentDateTimeModule : NancyModule
    {
        public CurrentDateTimeModule()
        {
            //Get("/", _ => {
            //    return string.Concat("Hello");
            //});
            Get("/", _ => DateTime.UtcNow);
        }
    }
}
