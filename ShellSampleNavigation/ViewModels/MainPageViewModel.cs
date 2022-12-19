using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellSampleNavigation.Views;

namespace ShellSampleNavigation.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        [RelayCommand]
        async void NavigateToSecondPage()
        {
            await Shell.Current.GoToAsync(nameof(SecondPage));
        }

        [RelayCommand]
        async void StartModalNavigation()
        {
            await Shell.Current.GoToAsync(nameof(ModalSamplePage));
        }
    }
}

