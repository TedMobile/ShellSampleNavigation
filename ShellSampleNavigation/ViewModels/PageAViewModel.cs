using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellSampleNavigation.Views;

namespace ShellSampleNavigation.ViewModels
{
    public partial class PageAViewModel : ObservableObject
    {
        [RelayCommand]
        async void NavigateToPageB()
        {
            //how do you navigate to PageB NOT MODALLY!!

            //await Shell.Current.Navigation.PushAsync(new PageB());

            await Shell.Current.GoToAsync(nameof(PageB)); //this will load it modally!! 
        }

        [RelayCommand]
        async void BackToRoot()
        {
            //In prism I can do this what is the equivalent (back to ModalSamplePage)
            //await navigationService.GoBackToRootAsync();

        }
    }
}
