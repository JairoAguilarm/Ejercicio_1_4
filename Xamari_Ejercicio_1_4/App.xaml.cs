using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using Ejercicio1_4_Xamari.Controllers;
using Ejercicio1_4_Xamari.Views;

namespace Ejercicio1_4_Xamari
{
    public partial class App : Application
    {
        static EmpleadosDB basedatos;

        public static EmpleadosDB BaseDatos
        {
            get
            {
                if (basedatos == null)
                {
                    basedatos = new EmpleadosDB(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EmpleadosDB.db3"));
                }
                return basedatos;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListarEmpleados());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
