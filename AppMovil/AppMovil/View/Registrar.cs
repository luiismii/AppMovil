using AppMovil.Modelos;
using AppMovil.View;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMovil
{
    public class Registrar : ContentPage
    {
        Usuarios users = new Usuarios();
        ActivityIndicator _loading;
        private List<Usuarios> lstUsuarios;
        Entry Nom, Ape, Id, Em, Fn, Email, Password;

        public Registrar()
        {
            StackLayout stack = new StackLayout();
            _loading = new ActivityIndicator() { IsRunning = true, IsVisible = false };
            Label InicioRegistro = new Label { Text = "Registro", TextColor = Color.Black, FontSize = 50, VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
            Nom = new Entry { Text = "", Placeholder = "Nombre" };
            Ape = new Entry { Text = "", Placeholder = "Apellido" };
            Id = new Entry { Text = "", Placeholder = "Identificacion" };
            Em = new Entry { Text = "", Placeholder = "Empresa" };
            Fn = new Entry { Text = "", Placeholder = "Fecha de Nacimiento" };
            Email = new Entry { Text = "", Placeholder = "Correo" };
            Password = new Entry { Text = "", Placeholder = "Contraceña", IsPassword = true };
            Button Entrar = new Button { Text = "Registrarme", };
            Entrar.Clicked += Aceptar_Click;
            stack.Children.Add(InicioRegistro);
            stack.Children.Add(Nom);
            stack.Children.Add(Ape);
            stack.Children.Add(Id);
            stack.Children.Add(Em);
            stack.Children.Add(Fn);
            stack.Children.Add(Email);
            stack.Children.Add(Password);
            stack.Children.Add(Entrar);
            Content = stack;
        }


        public async void Aceptar_Click(object sender, EventArgs e)
        {
        }
    }
}
