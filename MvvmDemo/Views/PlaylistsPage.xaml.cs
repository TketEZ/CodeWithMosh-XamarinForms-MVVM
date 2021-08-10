using System.Collections.ObjectModel;
using MvvmDemo.ViewModels;
using Xamarin.Forms;

namespace MvvmDemo
{
    public partial class PlaylistsPage : ContentPage
    {
        public PlaylistsPage ()
        {
            viewModel = new PlaylistsViewModel(new PageService());
            InitializeComponent ();
        }

        protected override void OnAppearing ()
        {
            base.OnAppearing ();
        }

        void OnPlaylistSelected (object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            viewModel.SelectPlaylistCommand.Execute(e.SelectedItem);
        }

        public PlaylistsViewModel viewModel
        {
            get { return BindingContext as PlaylistsViewModel; }
            set { BindingContext = value; }
        }
    }
}
