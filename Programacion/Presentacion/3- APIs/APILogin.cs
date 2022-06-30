
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class APILogin
    {

    public APILogin()
    {
    }
        public String loginUsuario(String user, String pass)
        {

        var datosUsuario = Controlador.loginUsuario(user, pass);

        return JsonConvert.SerializeObject(datosUsuario);
    }


}
