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
            
            //Label IdOwn = new Label
            //{
            //    FontAttributes = FontAttributes.Bold,
            //    TextColor = Color.Red
            //};
            Label NombreOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Blue
            };

            Label SemestreOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red
            };
            Label NomOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red
            };
            Label JornadaOwn = new Label
            {
                FontAttributes = FontAttributes.Bold,
                TextColor = Color.Red
            };

            NombreOwn.SetBinding(Label.TextProperty, new Binding("est_nombre"));
            SemestreOwn.SetBinding(Label.TextProperty, new Binding("ce_semestre"));
            NomOwn.SetBinding(Label.TextProperty, new Binding("car_nombre"));
            JornadaOwn.SetBinding(Label.TextProperty, new Binding("car_jornada"));


            ViewVertical.Children.Add(NombreOwn);
            ViewVertical.Children.Add(SemestreOwn);
            ViewVertical.Children.Add(NomOwn);
            ViewVertical.Children.Add(JornadaOwn);

            ViewOrizontal.Children.Add(ViewVertical);

            View = ViewOrizontal;
        }
    }
}
