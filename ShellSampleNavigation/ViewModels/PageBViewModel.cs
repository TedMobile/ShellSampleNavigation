using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellSampleNavigation.Views;

namespace ShellSampleNavigation.ViewModels;

public partial class PageBViewModel : ObservableObject
{
    [RelayCommand]
    async void NavigateToPageC()
    {
        //In prism I can do this what is the equivalent
        //await navigationService.NavigateAsync("PageC");

        await Shell.Current.GoToAsync(nameof(PageC)); //this will load it modally!! 
    }

    [RelayCommand]
    async void BackToRoot()
    {
        //In prism I can do this what is the equivalent (back to ModalSamplePage)
        //await navigationService.GoBackToRootAsync();

    }
}