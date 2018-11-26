using AppMovil.Modelos;
using AppMovil.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace AppMovil
{
    public class Login : ContentPage
    {
        Entry Usua, Password;
        ActivityIndicator _loading;
        private List<ClsLogin> lstLogin;
        private List<Usuarios> lstUsuarios;

        public Login(List<ClsLogin> lstLogin)
        {
            StackLayout stack = new StackLayout();
            _loading = new ActivityIndicator() { IsRunning = true, IsVisible = false };
            TapGestureRecognizer tapRecupera = new TapGestureRecognizer();
            TapGestureRecognizer tapCrear = new TapGestureRecognizer();
            tapCrear.Tapped += RegistrarCuenta;
            tapRecupera.Tapped += RecuperarCuenta;
            Label Inicio = new Label { Text = "Login", TextColor = Color.Black, FontSize = 50, VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
            Usua = new Entry { Text = "", Placeholder = "Correo" };
            Password = new Entry { Text = "", Placeholder = "Contraceña", IsPassword = true };
            Button Entrar = new Button { Text = "Iniciar Sesion" };
            Label Regis = new Label { Text = "Registrarme", TextColor = Color.Black, FontSize = 20, VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
            Label RecuPass = new Label { Text = "Recuperar Contraceña", TextColor = Color.Black, FontSize = 20, VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
            stack.Children.Add(Inicio);
            stack.Children.Add(Usua);
            stack.Children.Add(Password);
            stack.Children.Add(_loading);
            stack.Children.Add(Entrar);
            stack.Children.Add(Regis);
            stack.Children.Add(RecuPass);
            Entrar.Clicked += btnAceptar_Click;
            Regis.GestureRecognizers.Add(tapCrear);
            RecuPass.GestureRecognizers.Add(tapRecupera);
            Content = stack;
        }
        public async void RegistrarCuenta(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Registrar());

        }

        public async void RecuperarCuenta(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Usua.Text)) await DisplayAlert("Notificacion", "Usted no ha ingresado el correo", "Ok");
            else await Navigation.PushAsync(new RecuperarPassword(Usua.Text));


        }


        public async void btnAceptar_Click(object sender, EventArgs e)
        {
            if ( string.IsNullOrEmpty(Usua.Text)||string.IsNullOrEmpty(Password.Text))
            {
                await DisplayAlert("Notificacion", "Digitar Todos los campos", "Ok");
                return;
            }
            _loading.IsVisible = true;
            await Task.Delay(1000);
            IServicios servicios = DependencyService.Get<IServicios>();
            ResponseData responseData = await servicios.Login(Usua.Text, Password.Text);
            _loading.IsVisible = false;

            if (responseData == null) return;
            if(responseData.success != 0)
            {
                var json = responseData.Data;
                await Navigation.PushAsync(new PaginaContenido(json.do_id));     
            }
            else
            {
                await DisplayAlert("Notificacion",responseData.message, "Ok");
            }          
        }

    }
}


