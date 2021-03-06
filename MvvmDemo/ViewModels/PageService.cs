using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmDemo.ViewModels
{
    public class PageService : IPageService
    {
        async public Task<bool> DisplayAlert(string title, string message, string ok, string cancel)
        {
            return await Application.Current.MainPage.DisplayAlert(title, message, ok, cancel);
        }

        public async Task PushAsync(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
