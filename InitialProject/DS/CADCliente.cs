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

        public static void InsertClientes(int IDTipoDocumento, string Documento, string NombreComercial, string NombresContacto,
                                            string ApellidosContacto, string Direccion, string Telefono1, string Telefono2,
                                            string Correo, string Notas, DateTime Aniversario)
        {
            adapter.InsertClientes(IDTipoDocumento,Documento,NombreComercial,NombresContacto,ApellidosContacto,
                                    Direccion,Telefono1,Telefono2,Correo,Notas,Aniversario);
        }

        public static void UpdateClientes(int IDTipoDocumento, string Documento, string NombreComercial, string NombresContacto,
                                            string ApellidosContacto, string Direccion, string Telefono1, string Telefono2,
                                            string Correo, string Notas, DateTime Aniversario, int IDCliente)
        {
            adapter.UpdateClientes(IDTipoDocumento, Documento, NombreComercial, NombresContacto, ApellidosContacto,
                                    Direccion, Telefono1, Telefono2, Correo, Notas, Aniversario,IDCliente);
        }

        public static void DeleteClientes(int IDCliente)
        {
            adapter.DeleteClientes(IDCliente);
        }
    }
}
