using System;
using Microsoft.AspNetCore.Components;

namespace BlazorAcademy.Pages.Portfolios
{
    public partial class PortfolioWebSite
    {
        [Inject]
        public NavigationManager NavigationManagerRef { get; set; }

        protected override void OnInitialized()
        {

        }

        protected void GoToDevLog()
        {
            //NavigationManagerRef.NavigateTo("https://shockzinfinity.github.io");
            NavigationManagerRef.NavigateTo("/Index");
        }
    }
}
