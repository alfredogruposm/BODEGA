using System;
using System.Data;

namespace GrupoSM_Recepcion.DAO
{
    class ProduccionDAO
    {
        BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter querysadapter = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();

        BO.DS_MasterDataSetTableAdapters.producciondetalle_preliminarTableAdapter detalle_preliminarproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.producciondetalle_preliminarTableAdapter();

        BO.DS_MasterDataSetTableAdapters.vistaproduccion_paracorteTableAdapter vistacorte = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.vistaproduccion_paracorteTableAdapter();

        BO.DS_MasterDataSetTableAdapters.vista_prendas_separadoTableAdapter vistaseparado = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.vista_prendas_separadoTableAdapter();

        BO.DS_MasterDataSetTableAdapters.producciondetalle_preliminar2TableAdapter detalleprendas = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.producciondetalle_preliminar2TableAdapter();

        BO.DS_MasterDataSetTableAdapters.vista_prendas_entregaTableAdapter vistaentregas = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.vista_prendas_entregaTableAdapter();


        public int id_produccion_detalle { get; set; }
        public int producionid { get; set; }
        public int avios_completo { get; set; }
        public int tela_completa { get; set; }
        public int maquila_completa { get; set; }
        public Double num_tela_rollo { get; set; }
        public Double num_combinacion_rollo { get; set; }
        public string talla { get; set; }
        public double metros_recibidos { get; set; }
        public double cantidad_prendas { get; set; }
        public double numerorollo_forro { get; set; }
        public double metrosrecibidos_combinacion { get; set; }
        public double metrosrecibidos_forro { get; set; }
        public double metros_hilo { get; set; }
        public int cantidad_prendas_final { get; set; }
        public string combinacion { get; set; }
        public string tela { get; set; }
        public string color { get; set; }
        public string forro { get; set; }
        public int id_produccion { get; set; }
        public int idorden { get; set; }
        public int idficha { get; set; }
        public string observaciones_diseño { get; set; }
        public string rutas { get; set; }
        public string trazo { get; set; }
        public string tendio { get; set; }
        public string corto { get; set; }
        public string separado { get; set; }
        public string marca { get; set; }
        public string pellon { get; set; }
        public DateTime fecharutas { get; set; }

        public string termina_entrega()
        {
            try
            {
                querysadapter.prenda_termina_entrega(this.id_produccion);
                return "Correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public string termina_calidad()
        {
            try
            {
                querysadapter.prendas_terminacalidad(this.id_produccion);
                return "Correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public DataTable vista_entregas()
        {
            return vistaentregas.GetData();
        }

        public string prendas_maquila()
        {
            try
            {
                querysadapter.actualiza_prendamaquila(this.id_produccion);
                return "Correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public DataTable prendas_separado()
        {
            return vistaseparado.GetData();
        }

        public string actualizaobservaciones()
        {
            try
            {
                querysadapter.actualiza_observacionesproduccion(this.id_produccion, this.observaciones_diseño);
                return "Correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public string actualizarutas()
        {
            try
            {
                querysadapter.actualiza_rutasproduccion(this.id_produccion, this.rutas, this.fecharutas);
                return "correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }
        

        public string actualiza_entradatelas()
        {
            try
            {
                querysadapter.actualiza_telas_entrada(this.id_produccion_detalle, this.cantidad_prendas_final);
                return "correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }


        public string eliminatallacolor()
        {
            querysadapter.borra_tallacolorproduccion(this.id_produccion, this.talla, this.color);
            return "0";
        }


        public int ingresa_tallascolores()
        {

            querysadapter.ingresa_producciondetalle_parcial(this.id_produccion, this.tela, this.combinacion, Convert.ToInt32(this.num_tela_rollo), Convert.ToInt32(this.num_combinacion_rollo), this.talla, this.color, Convert.ToDecimal(this.metros_recibidos), Convert.ToDecimal(this.cantidad_prendas), this.forro, Convert.ToDecimal(this.metrosrecibidos_forro), Convert.ToDecimal(this.metrosrecibidos_combinacion), Convert.ToInt32(this.numerorollo_forro));

            return 1;
          
        }

        public string borraorden()
        {
            try
            {
                querysadapter.borra_orden_produccion(this.id_produccion);
                return "correcto";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public DataTable tallas_preliminaresproduccion()
        {
            return detalle_preliminarproduccion.GetData(this.id_produccion);
        }

        public DataTable tallas_preliminaresproduccion2()
        {
            return detalleprendas.GetData(this.id_produccion);
        }

        

        public int ingresa_produccionparcial()
        {
            try
            {
                querysadapter.ingresa_produccionparcial(this.idorden, this.idficha);
                return 1;
            }
            catch
            {
                return 0;
            }
        }
        
        

        public DataTable vistaparacorte()
        {
            return vistacorte.GetData();
        }
    }
}
