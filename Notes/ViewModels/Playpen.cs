using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;
    
namespace Notes.ViewModels;
    
internal class PlaypenViewModel
{
    public string Title => AppInfo.Name;
    public string Version => AppInfo.VersionString;
  
    public string Message => "This app is Playpen.";

    
}
