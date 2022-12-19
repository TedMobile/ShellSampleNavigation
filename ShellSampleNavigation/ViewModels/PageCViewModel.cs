using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ShellSampleNavigation.ViewModels;

public partial class PageCViewModel : ObservableObject
{

    [RelayCommand]
    async void NavigateBackToModalSamplePage()
    {
        //In prism I can do this what is the equivalent
        //await navigationService.NavigateAsync("NavigationPage/MainPage/ModalSamplePage", null, true);
    }

    [RelayCommand]
    async void BackToRoot()
    {
        //In prism I can do this what is the equivalent (back to ModalSamplePage)
        //await navigationService.GoBackToRootAsync();

    }
}