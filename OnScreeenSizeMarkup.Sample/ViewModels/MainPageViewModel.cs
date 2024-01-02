using System.Windows.Input;

namespace OnScreeenSizeMarkup.Sample.ViewModels;

public class MainPageViewModel
{
    public List<OnScreenSizeMarkup.Maui.Mappings.SizeMappingInfo> Mappings => OnScreenSizeMarkup.Maui.Manager.Current.Mappings;
    public MainPageViewModel()
    {
        SeeDocumentationCommand = new Command((url) =>
        {
            Launcher.OpenAsync(new System.Uri( "https://github.com/MicrosoftDocs/CommunityToolkit/tree/main/docs/maui/extensions/on-screen-size-extension.md"));
        });
    }

    public ICommand SeeDocumentationCommand { get; set; }

    
}