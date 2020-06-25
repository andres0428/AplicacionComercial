using InitialProject.DS.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject
{
    public class CADBarra
    {
        private static BarraTableAdapter adapter = new BarraTableAdapter();

        public static bool existeBarra(long Barra)
        {
            if (adapter.existeBarra(Barra) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void xInsertBarra(int IDProducto,long Barra)
        {
            adapter.InsertBarra(IDProducto,Barra);
        }

        public static void DeleteBarra(long Barra)
        {
            adapter.DeleteBarra(Barra);
        }        
    }
}
