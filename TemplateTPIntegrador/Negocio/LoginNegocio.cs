using Persistencia;
using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class LoginNegocio
    {
        public void login(String usuario, String password) {



            LoginDB loginDB = new LoginDB();
            loginDB.guardarIntento(usuario);


            LoginWS loginWS = new LoginWS();   
            loginWS.login(usuario, password); 

        
        }
    }
}
