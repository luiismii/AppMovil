using AppMovil.Modelos;
using AppMovil.View.MyViewCells;
using System.Threading.Tasks;
using Xamarin.Forms;
namespace AppMovil.View
{
    public class PaginaContenido : ContentPage
    {
        public string _id { get; set; }
        public PaginaContenido(string id)
        {
            _id = id;

            StackLayout ViewGeneral = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                BackgroundColor = Color.Transparent
            };

            ListView listViewContent = new ListView();
            listViewContent.ItemsSource = App.lstUsuarios;
            listViewContent.ItemTemplate = new DataTemplate(typeof(MyViewCell)); //aqui
            listViewContent.ItemTapped += ListViewContent_ItemTapped;
            listViewContent.ItemSelected += ListViewContent_ItemSelected;
            listViewContent.RowHeight = 60;

            ViewGeneral.Children.Add(listViewContent);
            Content = ViewGeneral;
        }
        private void ListViewContent_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            ((ListView)sender).SelectedItem = null;
        }
        private async void ListViewContent_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await DisplayAlert("Notificacion", "Bienvenido: " + ((ClsLogin)e.Item).do_nombre, "Ok");
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            //await Task.Delay(1000);
            IServicios servicios = DependencyService.Get<IServicios>();
            ResponseDataUsers responseData = await servicios.Usuarios(_id);

            App.lstUsuarios = responseData.Data;
        }
    }
}