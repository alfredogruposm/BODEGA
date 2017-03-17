using System.Data;


namespace GrupoSM_Recepcion.DAO
{
    class ProcesosDAO
    {
        BO.DS_MasterDataSetTableAdapters.procesosTableAdapter tablaprocesos = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.procesosTableAdapter();

        BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter querysadapter = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();

        BO.DS_MasterDataSetTableAdapters.procesos_detalleTableAdapter procesosdetalle = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.procesos_detalleTableAdapter();

        BO.DS_MasterDataSetTableAdapters.verprocesosfichaTableAdapter procesosficha = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.verprocesosfichaTableAdapter();
        BO.DS_MasterDataSetTableAdapters.busca_procesostipoTableAdapter procesostipo = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.busca_procesostipoTableAdapter();
        BO.DS_MasterDataSetTableAdapters.devuelveprocesosplantillaTableAdapter procesosplantilla;

        public int idproceso { get; set; }
        public int tipo { get; set; }
        public int idplantilla { get; set; }
        public string nombre { get; set; }
        public double tiempo { get; set; }
        public int idprocesodetalle { get; set; }
        public int idficha { get; set; }
        public int proceso { get; set; }
        public decimal cantidad { get; set; }
        public decimal tiempototal { get; set; }
        public int idproduccion { get; set; }

        public string eliminaprocesosplantilla()
        {
            try
            {
                querysadapter.eliminaplantilla_procesos(this.idplantilla, this.idproceso);
                return "Correcto";
            }
            catch
            {
                return "Error(eliminaprocesosplantilla)";
            }
        }

        public string insertaprocesosplantilla()
        {
            try
            {
                querysadapter.insertaplantilla_procesos(this.idplantilla, this.idproceso);
                return "Correcto";
            }
            catch
            {
                return "Error(insertaprocesosplantilla)";
            }
        }

        public DataTable devuelveplantillaprocesos()
        {
            procesosplantilla = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelveprocesosplantillaTableAdapter();
            return procesosplantilla.GetData(this.idplantilla);
        }

        public DataTable devuelveprocesos()
        {
             return tablaprocesos.GetData();
        }

        public string borraproceso()
        {
            querysadapter.borra_proceso(this.idproceso);
            return "0";
        }

        public DataTable verprocesosfichas()
        {
            return procesosficha.GetData(this.idficha);
        }

        public string insertaproceso()
        {
            try
            {
                tablaprocesos.Insert(this.nombre, this.tipo, this.tiempo);
                return "Proceso Agregado";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public string actualizaproceso()
        {
            try
            {
                querysadapter.actualizaprocesos(this.idproceso, this.nombre, this.tipo, this.tiempo);
                return "Operacion Actualizada";
            }
            catch
            {
                return "Error de coneccion";
            }
        }


        public string ingresadetalle()
        {
            try
            {
                querysadapter.insertaficha_procesos(this.idficha, this.idproceso);
                return "Agregado";
            }
            catch
            {
                return "Error de coneccion";
            }

        }


        public DataTable busca_procesosportipo()
        {
            return procesostipo.GetData(this.tipo);
        }

        public string borra_procesoficha()
        {
            try
            {
                querysadapter.borra_procesosficha(this.idproceso, this.idficha);
                return "Borrado";
            }
            catch
            {
                return "Error de coneccion";
            }
            
        }

        public string ingresaprocesostrabajo()
        {
            try
            {
                BO.DS_MasterDataSetTableAdapters.trabajoprocesosTableAdapter trabajoprocesostabla = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.trabajoprocesosTableAdapter();
                trabajoprocesostabla.Insert(this.idproduccion, this.idproceso, this.cantidad, this.tiempototal);
                
                return "Correcto";
            }
            catch
            {
                return "Error";
            }
        }


        public string actualizaprocesostrabajo()
        {
            try
            {
                querysadapter.actualizaprocesostrabajo(this.idproceso, this.idproduccion, this.cantidad, this.tiempototal);
                return "Correcto";
            }
            catch
            {
                return "Error";
            }
        }


        public DataTable devuelveprocesostrabajoproduccion()
        {
            
                BO.DS_MasterDataSetTableAdapters.produccionprocesostrabajoTableAdapter trabajosprocesos = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.produccionprocesostrabajoTableAdapter();

                return trabajosprocesos.GetData(this.idproduccion);
            
        }






    }
}
