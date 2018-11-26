using Xamarin.Forms;

namespace AppMovil.View.MyViewCells
{
    public class MyViewCell : ViewCell
    {
        public MyViewCell()
        {
            StackLayout ViewVertical = new StackLayout();
            ViewVertical.Spacing = 0;
            ViewVertical.Padding = 0;
            StackLayout ViewOrizontal = new StackLayout();
            ViewOrizontal.Padding = 10;
            
            Label IdOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red
            };
            Label NombreOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Blue
            };
            Label ApellidoOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red
            };

            IdOwn.SetBinding(Label.TextProperty, new Binding("est_id"));
            NombreOwn.SetBinding(Label.TextProperty, new Binding("est_nombre"));
            ApellidoOwn.SetBinding(Label.TextProperty, new Binding("est_apellido"));
            
            ViewVertical.Children.Add(IdOwn);
            ViewVertical.Children.Add(NombreOwn);
            ViewVertical.Children.Add(ApellidoOwn);

            ViewOrizontal.Children.Add(ViewVertical);

            View = ViewOrizontal;
        }
    }
}
