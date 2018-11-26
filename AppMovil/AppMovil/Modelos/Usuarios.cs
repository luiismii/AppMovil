using System;
using System.Collections.Generic;
using Xamarin.Forms;
namespace AppMovil
{
   public class Usuarios
    {
        public string est_id { get; set; }
        public string est_nombre { get; set; }
        public string est_apellido { get; set; }
        public string ce_primera_nota { get; set; }
        public string ce_segunda_nota { get; set; }
        public string ce_tercera_nota { get; set; }
        public string ce_semestre { get; set; }
        public string car_nombre { get; set; }
        public string car_jornada { get; set; }
 }
    public class ResponseDataUsers : messagedataDefauld
    {
        public List<Usuarios> Data { get; set; }
    }
    public class messagedataDefauld
    {
        public int Sucsess { get; set; }
        public int ResponseCode { get; set; }
        public string messaje { get; set; }
    }
}
