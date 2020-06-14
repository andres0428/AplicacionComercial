using InitialProject.DS.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static InitialProject.DS.DSAplicacionComercial;

namespace InitialProject.DS
{
    public class CADCliente
    {
        private static ClienteTableAdapter adapter = new ClienteTableAdapter();

        public static ClienteDataTable GetData()
        {
            return adapter.GetData();
        }
    }
}
