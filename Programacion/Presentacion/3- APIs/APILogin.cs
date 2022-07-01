
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
        //login usuario publico
        public String loginUsuario(String user, String pass)
        {
        // datos usuarios es una lista de string
        // esta lista es pasada al entorno del usuario publico a travez de la serializacion en formato JSON.

        var datosUsuario = Controlador.loginUsuario(user, pass);

        return JsonConvert.SerializeObject(datosUsuario);
    }


}
