using AppMovil.Modelos;
using System.Collections.Generic;
using Xamarin.Forms;

namespace AppMovil
{
    public class App : Application
    {
        public static List<ClsLogin> lstLogin;
        public static List<Usuarios> lstUsuarios;

        public App()
        {
            lstLogin = new List<ClsLogin>();
            LoadInformation();
            MainPage = new NavigationPage(new Login(lstLogin));
        }
        void LoadInformation()
        {
            ClsLogin Object = new ClsLogin
            {
                do_id = "1",
                do_nombre = "miguel",
                do_apellido = "Payan",
                do_email ="r@r.com",
                Password = "12345",
                Imag = "https://compass-ssl.xbox.com/assets/cf/7c/cf7cba96-8258-4fd2-afa0-9a8de00d1ee4.jpg?n=Windows-10-Games_Content-Placement-0_COD-Infinite-Warefare_740x417.jpg",

            };
        }
        

    }
}