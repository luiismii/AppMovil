using System;
using System.Collections.Generic;
using System.Text;

namespace AppMovil.Modelos
{
    public class ClsLogin
    {
       public string do_id { get; set; }
        public string do_nombre { get; set; }
        public string do_apellido { get; set; }
        public string do_email { get; set; }
        public string Password { get; set; }
        public string Imag { get; set; }
    }
    public class ResponseData: messagedataDefauld
    {
        public ClsLogin Data { get; set; }
    }
    public  class messagedataDefauld
    {
        public int success { get; set; }
        public int responseCode { get; set; }
        public string message { get; set; }
    }
    
}
