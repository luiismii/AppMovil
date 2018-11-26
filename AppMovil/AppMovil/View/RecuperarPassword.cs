using Xamarin.Forms;
using System;
namespace AppMovil
{
    public class RecuperarPassword : ContentPage
    {
        Usuarios users = new Usuarios();
        Entry Email;
        Button Enviar;

        public RecuperarPassword(string Correo)

        {
            StackLayout stack = new StackLayout();
            Label OlvidoPassword = new Label { Text = "Recuperar Contraceña", TextColor = Color.Black, FontSize = 50, VerticalOptions = LayoutOptions.Center, HorizontalOptions = LayoutOptions.Center };
            Email = new Entry { Text = "", Placeholder = "Correo" };
            Enviar = new Button { Text = "Enviar" };
            Email.Text = Correo;
             stack.Children.Add(OlvidoPassword);
            stack.Children.Add(Email);
            stack.Children.Add(Enviar);
            Content = stack;


        }

    }
}
