using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contentful.Core.Models;

namespace iCREAM.Domain.Models.ContentTypes
{
    public class CarouselItem
    {
        public SystemProperties Sys { get; set; }
        public string Heading { get; set; }
        public string SubHeading { get; set; }
        public Asset Image { get; set; }
        public string ReadMoreLink { get; set; }
    }
}

