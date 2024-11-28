using CommunityToolkit.Mvvm.ComponentModel;

namespace Maui9Issues
{
    public partial class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel()
        {
            Amount = 20.99m;
        }

        [ObservableProperty]
        decimal amount;
    }
}