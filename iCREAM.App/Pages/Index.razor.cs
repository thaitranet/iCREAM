using iCREAM.Domain.Models.ContentTypes;
using iCREAM.Service.Repositories;
using Microsoft.AspNetCore.Components;

namespace iCREAM.App.Pages
{
    public partial class Index
    {
        [Inject]
        public HomePageRepository HomePageRepository { get; set; }

        public HomePage Page { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Page = await HomePageRepository.GetItemAsync();
        }
    }
}
