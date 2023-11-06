using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Com.Unity3d.Player;

namespace maui;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    private UnityPlayer unityPlayer;
    protected override void OnCreate(Bundle savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        
        unityPlayer = new UnityPlayer(this);
        SetContentView(unityPlayer.View);
    }
}

