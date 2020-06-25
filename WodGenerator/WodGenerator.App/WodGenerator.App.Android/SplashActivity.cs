using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace WodGenerator.App.Droid
{
    [Activity(Label = "WodGenerator.App", Icon = "@mipmap/icon", Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        public override void OnCreate(Bundle savedInstanceState, PersistableBundle persistentState)
        {
            base.OnCreate(savedInstanceState, persistentState);
        }

        // Inicia as operações de validação de inicialização do app
        protected override void OnResume()
        {
            base.OnResume();
            Task startupWork = new Task(() => { SimulateStartup(); });
            startupWork.Start();
        }

        //public override void OnBackPressed()
        //{
        //}

        // Simula o funcionamento de um processo qualquer antes de abrir o aplicativo
        async void SimulateStartup()
        {
            await Task.Delay(3000); // Simula um processo que demora 1 segundos para finalizar

            // Chama a atividade MainActivity para inicializar o Xamarim
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));
        }
    }
}