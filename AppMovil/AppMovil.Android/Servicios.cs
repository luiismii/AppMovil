using AppMovil.Droid;
using AppMovil.Modelos;
using Newtonsoft.Json;
using RestSharp;
using System;
using Xamarin.Forms;
using System.Threading.Tasks;

[assembly: Dependency(typeof(Servicios))]

namespace AppMovil.Droid
{
    public class Servicios : IServicios
    {
         public Task <ResponseData> Login(string user, string pass)
        {
            try
            {
                RestClient Cliente = new RestClient("http://youis.000webhostapp.com/Project/Utap/api");
                RestRequest Request = new RestRequest("/utap0-0.php", Method.POST)
                { RequestFormat = DataFormat.Json };
                Request.AddParameter("email",user);
                Request.AddParameter("password",pass);
                var respuesta = Cliente.Execute(Request);
                ResponseData Response = JsonConvert.DeserializeObject<ResponseData>(respuesta.Content);
                return Task.FromResult(Response);

            }catch (Exception ex)
            {
                return null;
            }
        }
        public Task<ResponseDataUsers> Usuarios(string Id)
        {
            try
            {
                RestClient Cliente = new RestClient("http://youis.000webhostapp.com/Project/Utap/api");
                RestRequest Request = new RestRequest("/utap1-0.php", Method.POST)
                { RequestFormat = DataFormat.Json };
                Request.AddParameter("estudiante_id", Id);
                var respuesta = Cliente.Execute(Request);
                ResponseDataUsers Response = JsonConvert.DeserializeObject<ResponseDataUsers>(respuesta.Content);
                return Task.FromResult(Response);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}