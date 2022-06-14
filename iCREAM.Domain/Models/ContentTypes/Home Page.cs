using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contentful.Core.Models;

namespace iCREAM.Domain.Models.ContentTypes
{
    public class HomePage
    {
        public SystemProperties Sys { get; set; }
        public string Name { get; set; }
        public string UrlSlug { get; set; }
        public List<CarouselItem> CarouselItems { get; set; }
    }
}

