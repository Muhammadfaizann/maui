using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Com.Unity3d.Player;

namespace maui
{
    [Activity(
        Label = "UnityActivity",
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation,
        ScreenOrientation = ScreenOrientation.FullUser,
        Theme = "@android:style/Theme.NoTitleBar")]
    public class UnityActivity : Activity
    {
        private UnityPlayer unityPlayer;

        public UnityActivity()
        {

        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var unityIntent = new Intent(this, typeof(UnityActivity));
            StartActivity(unityIntent);
        }

        protected override void OnPause()
        {
            base.OnPause();
            unityPlayer.Pause();
        }

        protected override void OnResume()
        {
            base.OnResume();
            unityPlayer.Resume();
        }

        protected override void OnDestroy()
        {
            base.OnDestroy();
            unityPlayer.Quit();
        }

    }
}

