using CommunityToolkit.Mvvm.ComponentModel;

namespace Maui9Issues
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy = false;

        [ObservableProperty]
        string title = string.Empty;
    }
}