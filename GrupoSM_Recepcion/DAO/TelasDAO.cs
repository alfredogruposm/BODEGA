using System;
using System.Data;
using GrupoSM_Recepcion.Services;

namespace GrupoSM_Recepcion.DAO
{
    class TelasDAO
    {
        BO.DS_MasterDataSetTableAdapters.devuelvetelasproduccionTableAdapter telasproduccion = new BO.DS_MasterDataSetTableAdapters.devuelvetelasproduccionTableAdapter();
        BO.DS_MasterDataSetTableAdapters.telacosteoTableAdapter tablatelacosteo = new BO.DS_MasterDataSetTableAdapters.telacosteoTableAdapter();
        BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter queriesadpter = new BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();
        BO.DS_MasterDataSetTableAdapters.telaTableAdapter tablatela = new BO.DS_MasterDataSetTableAdapters.telaTableAdapter();
        BO.DS_MasterDataSetTableAdapters.devuelvetelasproduccionTableAdapter tablatelasalmacen = new BO.DS_MasterDataSetTableAdapters.devuelvetelasproduccionTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvetelasportipoTableAdapter telasalmacen = new BO.DS_MasterDataSetTableAdapters.devuelvetelasportipoTableAdapter();
        public int idtela_bodega { get; set; }
        public int cliente { get; set; }
        public int proveedor { get; set; }
        public DateTime fecha_entrada { get; set; }
        public string nombre_descripcion { get; set; }
        public double metros { get; set; }
        public decimal metross { get; set; }
        public string composicion { get; set; }
        public string color { get; set; }
        public double ancho { get; set; }
        public decimal anchoo { get; set; }
        public int tipo { get; set; }
        public int idtelacosteo { get; set; }
        public string nombretelacosteo { get; set; }
        public double precio { get; set; }
        public int id_tela_produccion { get; set; }
        public int produccion { get; set; }
        public DateTime fecha_entrada_produccion { get; set; }
        public decimal largo_trazo { get; set; }
        public decimal paños { get; set; }
        public decimal utilizado_tela { get; set; }
        public decimal retazo_tela { get; set; }
        public decimal saldo_tela { get; set; }
        public decimal faltante_tela { get; set; }
        public decimal precio_metro { get; set; }

        public DataTable telasrequisicion()
        {
            return telasproduccion.GetData(this.produccion);
        }
        
        public string ingresatelaalmacen()
        {
            return "Correcto";
        }

        public DataTable vertelas_asignados()
        {
            return telasalmacen.GetData(this.produccion, this.tipo);
        }

        //public string insertatelacosteo()
        //{
        //    try
        //    {
        //        tablatelacosteo.Insert(this.nombretelacosteo, this.precio);
        //        return "Correcto";
        //    }
        //    catch
        //    {
        //        return "Error de coneccion";
        //    }
        //}

        public string modificatelascosteo()
        {
            try
            {
                queriesadpter.modificatelacosteo(this.nombretelacosteo, this.precio, this.idtelacosteo);
                return "Correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public string eliminatelascosteo()
        {
            try
            {
                queriesadpter.eliminatelacosteo(this.idtelacosteo);
                return "Correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }        
    }
}
