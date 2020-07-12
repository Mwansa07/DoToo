using System;
using System.Threading.Tasks;
using DoToo.Repositories;
using System.Windows.Input;
using DoToo.Views;
using Xamarin.Forms;

namespace DoToo.ViewModels
{
    public class MainViewModel : ViewModel
    {
        public ICommand AddItem => new Command(async () =>
        {
            var itemView = Resolver.Resolve<ItemView>();
            await Navigation.PushAsync(itemView);
        });

        private readonly TodoItemRepository repository;

        public MainViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
            Task.Run(async () => await LoadData());
        }

        private async Task LoadData()
        {

        }
    }
}
