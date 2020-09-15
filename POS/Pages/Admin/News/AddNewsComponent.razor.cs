using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace POS.Pages.Admin.News
{

    public class AddNewsComponentBase : OwningComponentBase
    {
        protected Models.News Item;

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }

        protected void ValidSubmit()
        {
        }
    }

}