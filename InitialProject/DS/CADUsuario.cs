using InitialProject.DS.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.DS
{
    public class CADUsuario
    {
        private static UsuarioTableAdapter adapter = new UsuarioTableAdapter();

        public static bool ValidaUsuario(string IDUsuario,string Clave)
        {
            if ( (adapter.ValidaUsuario(IDUsuario,Clave) == null))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
