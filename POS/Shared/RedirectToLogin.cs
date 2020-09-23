using Microsoft.AspNetCore.Components;


namespace POS.Shared
{

    public class RedirectToLoginComponent : ComponentBase
    {
        [Inject] protected NavigationManager NavigationManager { get; set; }

        protected override void OnInitialized()
        {
            NavigationManager.NavigateTo("/Identity/Account/Login");
        }
    }

}