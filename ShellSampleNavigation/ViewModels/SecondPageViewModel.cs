using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellSampleNavigation.Views;

namespace ShellSampleNavigation.ViewModels
{
    public partial class SecondPageViewModel : ObservableObject
    {
        [RelayCommand]
        async void NavigateToThirdPage()
        {
            await Shell.Current.GoToAsync(nameof(ThirdPage));
        }
    }
}
