using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ShellSampleNavigation.Views;

namespace ShellSampleNavigation.ViewModels
{
    public partial class ModalSamplePageViewModel : ObservableObject
    {
        [RelayCommand]
        async void NavigateToPageA()
        {
            //how do you navigate to PageA NOT MODALLY!!

            //await Shell.Current.Navigation.PushAsync(new PageA());

            await Shell.Current.GoToAsync(nameof(PageA)); //this will load it modally!! 
        }
    }
}
