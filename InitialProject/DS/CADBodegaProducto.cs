using InitialProject.DS.DSAplicacionComercialTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InitialProject.DS
{
    public class CADBodegaProducto
    {
        private static BodegaProductoTableAdapter adapter = new BodegaProductoTableAdapter();

        public int IDBodega { get; set; }
        public int IDProducto { get; set; }
        public float Stock { get; set; }
        public float Minimo { get; set; }
        public float Maximo { get; set; }
        public int DiasReposicion { get; set; }
        public float CantidadMinima { get; set; }


        public static CADBodegaProducto GetBodegaProductoByBodegaAndIdProducto(int IDBodega, int IDProducto)
        {
            CADBodegaProducto miBodegaProducto = null;
            DSAplicacionComercial.BodegaProductoDataTable miTabla = adapter.GetBodegaProductoByBodegaAndIdProducto(IDBodega,IDProducto);
            if (miTabla.Rows.Count == 0) return miBodegaProducto;
            DSAplicacionComercial.BodegaProductoRow miRegistro = (DSAplicacionComercial.BodegaProductoRow) miTabla.Rows[0];
            miBodegaProducto = new CADBodegaProducto();
            miBodegaProducto.IDBodega = miRegistro.IDBodega;
            miBodegaProducto.IDProducto = miRegistro.IDProducto;
            miBodegaProducto.Stock = (float)miRegistro.Stock;
            miBodegaProducto.Minimo = (float)miRegistro.Minimo;
            miBodegaProducto.Maximo = (float)miRegistro.Maximo;
            miBodegaProducto.DiasReposicion = miRegistro.DiasReposicion;
            miBodegaProducto.CantidadMinima = (float)miRegistro.CantidadMinima;


            return miBodegaProducto;
        }

        public static void updateBodegaProducto(int IDBodega, int IDProducto, float Minimo, float Maximo, int DiasReposicion, float CantidadMinima)
        {
            try
            {
                adapter.InsertBodegaProducto(IDBodega,IDProducto,Minimo,Maximo,DiasReposicion,CantidadMinima);
            }
            catch (Exception)
            {

                adapter.UpdateBodegaProducto(Minimo,Maximo,DiasReposicion,CantidadMinima,IDBodega,IDProducto);
            }
        }

    }
}
