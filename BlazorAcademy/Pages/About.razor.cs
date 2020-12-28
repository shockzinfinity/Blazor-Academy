using System;
namespace BlazorAcademy.Pages
{
    public partial class About
    {
        private string title = "정보";
        private string subTitle = "부가정보";

        protected override void OnInitialized()
        {
            this.subTitle = DateTime.Now.ToLongTimeString();
        }
    }
}
