using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace GrupoSM_Recepcion.DAO
{
    class EmpleadosDAO
    {
        BO.DS_MasterDataSetTableAdapters.EmpleadosTableAdapter tablaempleados;
        BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter queriesadapter;
        BO.DS_MasterDataSetTableAdapters.devuelveempleadoTableAdapter empleados;
        public int idempleados { get; set; }
        public string nombre { get; set; }
        public int Afinidad1 { get; set; }
        public int Afinidad2 { get; set; }
        public int Afinidad3 { get; set; }
        public int IDProduccion { get; set; }
        public int IDProceso { get; set; }
        public int IDProduccionporcentajes { get; set; }
        public DateTime fechainicio { get; set; }
        public DateTime fechaterminado { get; set; }
        public Decimal Cantidad { get; set; }
        public Decimal Tiempoesperado { get; set; }
        public Decimal Porcentaje { get; set; }
        public DataTable devuelvetodoempleados()
        {
            tablaempleados = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.EmpleadosTableAdapter();
            return tablaempleados.GetData();
        }

        public DataTable devuelveempleados()
        {
            empleados = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelveempleadoTableAdapter();
            return empleados.GetData(this.idempleados);

        }
        
        public string insertaempleados()
        {
            try
            {
                tablaempleados = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.EmpleadosTableAdapter();
                tablaempleados.Insert(this.nombre, this.Afinidad1, this.Afinidad2, this.Afinidad3);
                return "Correcto";
            }
            catch
            {
                return "Error(insertaempleados)";
            }
        }
        public string insertaempleadosproduccion()
        {
            try
            {
                BO.DS_MasterDataSetTableAdapters.empleadosproduccionTableAdapter empleadosproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.empleadosproduccionTableAdapter();

                empleadosproduccion.Insert(this.idempleados, this.IDProduccion);
                return "Correcto";
            }
            catch
            {
                return "Error(insertaempleados)";
            }
        }

        public string actualizaempleados()
        {
            try
            {
                queriesadapter = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();
                queriesadapter.ActualizaEmpleados(this.idempleados,this.nombre, this.Afinidad1, this.Afinidad2, this.Afinidad3);
                return "Correcto";
            }
            catch
            {
                return "Error(actualizaempleados)";
            }
        }

        public string eliminaempleados()
        {
            try
            {
                queriesadapter = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();
                queriesadapter.EliminaEmpleados(this.idempleados);
                return "Correcto";
            }
            catch
            {
                return "Error(eliminaempleados)";
            }
        }


        public string insertaempleadosproduccionmaquila()
        {
            try
            {
                BO.DS_MasterDataSetTableAdapters.EmpleadosPorcentajesProduccionTableAdapter empleadosproducciontabla = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.EmpleadosPorcentajesProduccionTableAdapter();
                empleadosproducciontabla.Insert(this.idempleados, this.IDProduccion, this.IDProceso, this.fechainicio, this.fechaterminado, this.Cantidad, this.Tiempoesperado, this.Porcentaje);

                return "Correcto";
            }
            catch
            {
                return "Error(insertaempleadosproduccionmaquila)";
            }
        }




        public string actualizaempleadosproduccionmaquila()
        {
            try
            {
                queriesadapter = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();
                queriesadapter.actualizaempleadosporcentajesproduccion(this.IDProduccionporcentajes, this.fechaterminado, this.Porcentaje);
                return "Correcto";
            }
            catch
            {
                return "Error(actualizaempleadosproduccionmaquila)";
            }
        }



        public DataTable devuelveempleadostrabajoproduccion1()
        {
            BO.DS_MasterDataSetTableAdapters.devuelveempleadosmaquilapoduccionTableAdapter procedure = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelveempleadosmaquilapoduccionTableAdapter();
            return procedure.GetData(this.IDProduccion);


        }




        public DataTable devuelveempleadostrabajoproduccion()
        {
            BO.DS_MasterDataSetTableAdapters.devuelveempleadosproduccionTableAdapter empleadosproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelveempleadosproduccionTableAdapter();

            return empleadosproduccion.GetData(this.IDProduccion);

        }











    }
}
