using Persistencia.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class LoginDB
    {
        public void guardarIntento(String username)
        {
            DBHelper dbHelper = new DBHelper("intentos_login");
            dbHelper.Insertar(username, "1");
        }
    }
}
