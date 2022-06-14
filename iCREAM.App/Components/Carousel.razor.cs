using iCREAM.Domain.Models.ContentTypes;
using Microsoft.AspNetCore.Components;

namespace iCREAM.App.Components
{
    public partial class Carousel
    {
        [Parameter]
        public List<CarouselItem> CarouselItems { get; set; }
    }
}
