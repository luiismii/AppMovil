using AppMovil.Modelos;
using System.Threading.Tasks;

namespace AppMovil
{
    public interface IServicios
    {
        Task <ResponseData> Login(string user,string pass);
        Task<ResponseDataUsers> Usuarios(string Id);

    }
}
