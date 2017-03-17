using System;
using System.Linq;
using System.Data;

namespace GrupoSM_Recepcion.DAO
{
    class AviosDAO
    {
        BO.DS_MasterDataSetTableAdapters.devuelvenumeroavioprodTableAdapter numeroavioproduccion = new BO.DS_MasterDataSetTableAdapters.devuelvenumeroavioprodTableAdapter();

        BO.DS_MasterDataSetTableAdapters.AviosAlmacen_DetalleTableAdapter tablaaviosalmacen = new BO.DS_MasterDataSetTableAdapters.AviosAlmacen_DetalleTableAdapter();

        BO.DS_MasterDataSetTableAdapters.AviosAlmacenTableAdapter tablaaviosalmacendetalle = new BO.DS_MasterDataSetTableAdapters.AviosAlmacenTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelveavioshojacorteeTableAdapter devuelveavioshojacorte = new BO.DS_MasterDataSetTableAdapters.devuelveavioshojacorteeTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvenumaviosdetallealmacenTableAdapter numeroaviosdetallealmacen = new BO.DS_MasterDataSetTableAdapters.devuelvenumaviosdetallealmacenTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvevistabodegaaviostipo2TableAdapter vistabodegareportetipo = new BO.DS_MasterDataSetTableAdapters.devuelvevistabodegaaviostipo2TableAdapter();

        BO.DS_MasterDataSetTableAdapters.ver_avios_fichasTableAdapter ver_aviosficha = new BO.DS_MasterDataSetTableAdapters.ver_avios_fichasTableAdapter();

        BO.DS_MasterDataSetTableAdapters.vistabodegaavios2TableAdapter vistabodegadeavios = new BO.DS_MasterDataSetTableAdapters.vistabodegaavios2TableAdapter();

        BO.DS_MasterDataSetTableAdapters.aviosTableAdapter tablaavios = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.aviosTableAdapter();

        BO.DS_MasterDataSetTableAdapters.busca_aviostipoBASEPortipoTableAdapter tablaaviosbasetipo = new BO.DS_MasterDataSetTableAdapters.busca_aviostipoBASEPortipoTableAdapter();

        BO.DS_MasterDataSetTableAdapters.avios_detalleTableAdapter tabladetalleavios = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_detalleTableAdapter();

        BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter querysadapter = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.QueriesTableAdapter();

        BO.DS_MasterDataSetTableAdapters.avios_bodegaTableAdapter tablabodega = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_bodegaTableAdapter();

        BO.DS_MasterDataSetTableAdapters.numeroaviosTableAdapter numeroavio = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.numeroaviosTableAdapter();

        BO.DS_MasterDataSetTableAdapters.avios_mas_bodegaTableAdapter aviosvista = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_mas_bodegaTableAdapter();

        BO.DS_MasterDataSetTableAdapters.avios_produccionTableAdapter tablaaviosproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_produccionTableAdapter();

        BO.DS_MasterDataSetTableAdapters.vistabodegaavios3TableAdapter vistabodegaaviosfaltantes = new BO.DS_MasterDataSetTableAdapters.vistabodegaavios3TableAdapter();

        BO.DS_MasterDataSetTableAdapters.vistabodegaavios4TableAdapter vistabodegaavioscatalogo = new BO.DS_MasterDataSetTableAdapters.vistabodegaavios4TableAdapter();

        BO.DS_MasterDataSetTableAdapters.Existen_aviosproduccionTableAdapter existeavioproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.Existen_aviosproduccionTableAdapter();

        BO.DS_MasterDataSetTableAdapters.avios_orden_asignacionesTableAdapter aviostablaasignaciones = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_orden_asignacionesTableAdapter();

        BO.DS_MasterDataSetTableAdapters.busca_aviostipoTableAdapter aviostipo = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.busca_aviostipoTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelveaviosproduccionTableAdapter aviosproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelveaviosproduccionTableAdapter();

        BO.DS_MasterDataSetTableAdapters.busca_tipo_aviosmasbodegaTableAdapter tipomasbodega = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.busca_tipo_aviosmasbodegaTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelveavios_plantillaTableAdapter aviosplantilla;

        BO.DS_MasterDataSetTableAdapters.numeroaviosproduccionTableAdapter numeroaviosproduccion;

        BO.DS_MasterDataSetTableAdapters.ColorAvioTableAdapter tablacoloravios = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.ColorAvioTableAdapter();

        BO.DS_MasterDataSetTableAdapters.avios_impresionTableAdapter impresionavios;

        BO.DS_MasterDataSetTableAdapters.avios_vistaasignacionTableAdapter aviosasignacion;

        BO.DS_MasterDataSetTableAdapters.devuelvenumeroprendascolorTableAdapter numeroprendascolor;

        BO.DS_MasterDataSetTableAdapters.AviosSubgruposTableAdapter aviossubgrupostabla;

        BO.DS_MasterDataSetTableAdapters.devuelvesubgruposcolorTableAdapter aviossubgrupos;

        BO.DS_MasterDataSetTableAdapters.devuelvealmacenavios01TableAdapter almacenavios = new BO.DS_MasterDataSetTableAdapters.devuelvealmacenavios01TableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvedatosalmacenaviosTableAdapter datosalmacenavios = new BO.DS_MasterDataSetTableAdapters.devuelvedatosalmacenaviosTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvetallasaviosTableAdapter tallasproduccion = new BO.DS_MasterDataSetTableAdapters.devuelvetallasaviosTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvenumerodealmacenTableAdapter numerodealmacen = new BO.DS_MasterDataSetTableAdapters.devuelvenumerodealmacenTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvenumeroavioalmacendetalleTableAdapter numeroavioalmacendetalle = new BO.DS_MasterDataSetTableAdapters.devuelvenumeroavioalmacendetalleTableAdapter();

        BO.DS_MasterDataSetTableAdapters.devuelvedatoscatalogoalmacenaviosTableAdapter catalogoalmacendatospornombre = new BO.DS_MasterDataSetTableAdapters.devuelvedatoscatalogoalmacenaviosTableAdapter();

        BO.DS_MasterDataSetTableAdapters.catalogodealmacenexistenciasaviosTableAdapter catalogolmacenexistencias = new BO.DS_MasterDataSetTableAdapters.catalogodealmacenexistenciasaviosTableAdapter();
        public int IDAvioAlmacen { get; set; }
        public int id_ficha_avio { get; set; }
        public int idavios { get; set; }
        public int idplantilla { get; set; }
        public string nombre { get; set; }
        public string Color { get; set; }
        public int tipo { get; set; }
        public string tipoo { get; set; }
        public string talla { get; set; }
        public double precio { get; set; }
        public int iddetalle { get; set; }
        public decimal cantidadd { get; set; }
        public double cantidad { get; set; }
        public decimal cantidadbodegaa { get; set; }
        public double costo { get; set; }
        public int idaviosbodega { get; set; }
        public int idproduccion { get; set; }
        public decimal cantidadasignada { get; set; }
        public double cantidadbodega { get; set; }
        public DateTime fecha { get; set; }
        public double cantidad_ficha { get; set; }
        public int idavioproduccion { get; set; }

        public DataTable existenciascatalogoalmacenavios()
        {
            return catalogolmacenexistencias.GetData();
        }


        public DataTable datoscatalogoalmacenavios()
        {
            return catalogoalmacendatospornombre.GetData(this.nombre);
        }

        public string eliminadebodegaalmacen()
        {
            querysadapter.eliminaalmacenbodega(this.IDAvioAlmacen);
            return "Correcto";
        }

        public DataTable devuelvehojadecorteavios()
        {
            return devuelveavioshojacorte.GetData(this.idproduccion);
        }

        public string ingresaalmacencatalogo()
        {
            querysadapter.actualizaavioscatalogo(this.idavioproduccion, this.cantidadd, this.cantidadbodegaa);
            return "Correcto";
        }

        public string insertalmacendetalle()
        {
            querysadapter.insertaalmacendetalle(this.idavios, this.idproduccion, this.cantidadd);
            insertadetallealmacen();
            return "Correcto";
        }

        public int devuelvenumerodealmacen()
        {
            return Convert.ToInt32(numerodealmacen.GetData().Max().Column1);
        }

        public int numeroaviosalmacendetalle()
        {
            return Convert.ToInt32(numeroavioalmacendetalle.GetData().Max().Column1);
        }

        public string ingresaprimeralmacen()
        {
            querysadapter.insertacopiadebodegaprimeringreso(this.idavioproduccion, this.cantidadd);
            return "Correcto";
        }
        public void insertadetallealmacen()
        {
            querysadapter.insertaproducciondetalleavios(numeroaviosalmacendetalle(), this.Color, this.talla);
        }

        public string insertaalmacen()
        { 
            querysadapter.ingresaalmacen(this.cantidadd, this.idproduccion);
            querysadapter.ingresacatalogo(devuelvenumerodealmacen(), this.nombre, this.tipoo);
            return "Correcto";
        }
        
        public DataTable devuelvetallasproduccion()
        {
            return tallasproduccion.GetData(this.idproduccion);
        }
        public DataTable datosalmacen()
        {
            return datosalmacenavios.GetData(this.nombre);
        }

        public DataTable almacenavioslistado()
        {
            return almacenavios.GetData();
        }

       
        public string eliminaentradaavios()
        {
            querysadapter.eliminaaviosalmacen(this.IDAvioAlmacen);
            return "Correcto";
        }
        public int numeros_almacen()
        {
            try
            {
                return Convert.ToInt32(numeroaviosdetallealmacen.GetData().Max().Column1);
            }
            catch
            {
                return 100;
            }
        }
        
        
        
        public DataTable devuelvealmacenavio()
        {
            return almacenavios.GetData();
        }

       
        public DataTable devuelvebodegaaviosparaimprimir()
        {
            return vistabodegadeavios.GetData();
        }
        public DataTable devuelvefaltantesaviosbodega()
        {
            return vistabodegaaviosfaltantes.GetData();
        }

        public DataTable devuelvecatalogoaviosbodega()
        {
            return vistabodegaavioscatalogo.GetData();
        }

        public string Actualizaaviosproduccion()
        {
            try
            {
                querysadapter.actualizaavioproduccionsubgrupo(this.idavios, this.iddetalle);
                return "Correcto";
            }
            catch
            {
                return "Error(Actualizaaviosproduccion)";
            }
        }

        public DataTable vistaimpresionbodegaaviosportipo()
        {
            return vistabodegareportetipo.GetData(this.tipo);
        }
        public string eliminaaviossubgruposcolor()
        {
            try
            {
                querysadapter.eliminaaviossubgrupos(this.idavios);
                return "Correcto";
            }
            catch
            {
                return "Error(eliminaviossubgrupos)";
            }
        }

        public string ingresaaviossubgrupos()
        {
            try
            {
                aviossubgrupostabla = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.AviosSubgruposTableAdapter();
                aviossubgrupostabla.Insert(this.idavios, this.iddetalle);
                return "Correcto";
            }
            catch
            {
                return "Error(ingresasubgrupos)";
            }
        }

        public DataTable devuelveaviossubgruposcolor()
        {
            aviossubgrupos = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelvesubgruposcolorTableAdapter();
            return aviossubgrupos.GetData(this.idavios);
        }

        public DataTable devuelveaviostipobase()
        {
            BO.DS_MasterDataSetTableAdapters.busca_aviostipoBASETableAdapter aviosbase = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.busca_aviostipoBASETableAdapter();
            return aviosbase.GetData();
        }

        public int numerocolorprendas()
        {
            numeroprendascolor = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelvenumeroprendascolorTableAdapter();
            return Convert.ToInt32(numeroprendascolor.GetData(this.idproduccion, this.Color).Max().Cantidad_prendas);

        }

        public DataTable devuelveaviosasignaciones()
        {
            aviosasignacion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_vistaasignacionTableAdapter();
            return aviosasignacion.GetData(this.idproduccion);
            //return aviostablaasignaciones.GetData(this.idproduccion);
        }

        public DataTable avios_asignacionbodega()
        {
            aviosasignacion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_vistaasignacionTableAdapter();
            return aviosasignacion.GetData(this.idproduccion);
        }

        public DataTable aviosimpresion()
        {
            impresionavios = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.avios_impresionTableAdapter();
            return impresionavios.GetData(this.idproduccion);
        }

        public DataTable devuelveplantillaavios()
        {
            aviosplantilla=new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.devuelveavios_plantillaTableAdapter();
            return aviosplantilla.GetData(this.idplantilla);
        }

        public string insertaaviosplantilla()
        {
            try
            {

                querysadapter.insertaplantilla_avios(this.idplantilla, this.idavios, this.cantidad, this.costo);
                return "Correcto";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }

        public string eliminaaviosplantilla()
        {
            try
            {

                querysadapter.eliminaplantilla_avios(this.idplantilla, this.idavios);
                return "Correcto";
            }
            catch
            {
                return "Error(eliminaaviosplantilla)";
            }
        }

        public DataTable aviosproduc()
        {
            return aviosproduccion.GetData(this.idproduccion);
        }

        public string actualizabodegaavios()
        {
            try
            {
                int numero = Convert.ToInt32(this.cantidad);
                querysadapter.actualizabodegaavios(this.idavios, numero);
                return "Correcto";
            }
            catch
            {
                return "A habido un error";
            }
        }

        public string eliminaaviosproduccion()
        {
            try
            {
                querysadapter.eliminaaviosproduccion(this.idproduccion);
                return "Correcto";
            }
            catch
            {
                return "A habido un error";
            }
        }

        public string actualizabodega_avios()
        {
            querysadapter.actualiza_bodegaavios(this.idaviosbodega, Math.Round((this.cantidad), 2));
            return "Correcto";
        }

        public DataTable aviosbodega()
        {
            return aviosvista.GetData();
        }
        public int numeroavioalmacen()
        {
            return Convert.ToInt32(numeroavio.GetData().Max().Column1);
        }
        public int numeros_avios()
        {
            return Convert.ToInt32(numeroavio.GetData().Max().Column1);
        }

        public int numero_avios_produccion()
        {
            numeroaviosproduccion = new GrupoSM_Recepcion.BO.DS_MasterDataSetTableAdapters.numeroaviosproduccionTableAdapter();
            return Convert.ToInt32(numeroaviosproduccion.GetData().Max().Column1);
        }

       

        public DataTable sacar_avios()
        {
            return ver_aviosficha.GetData(this.id_ficha_avio);
        }


        public string insertabodega()
        {

            tablabodega.Insert(idavios, this.cantidad);
            return "correcto";

        }


        public string agregar_avios()
        {
            try
            {
                tablaavios.Insert(this.nombre, this.tipo, Convert.ToDouble(this.precio));
                return "Agregado Correctamente";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public string agregar_detalle()
        {
            try
            {
                querysadapter.insertaficha_avios(this.id_ficha_avio, this.idavios, Math.Round((this.cantidad), 2), this.costo);
                return "Agregado Correctamente";
            }
            catch(Exception ex) 
            {
                return ex.ToString();
            }
        }

        public DataTable sacartodosavios()
        {
            return tablaavios.GetData();
        }

        public string actualizaavios()
        {
            try
            {
                querysadapter.actualiza_avios(this.idavios, this.nombre, this.tipo, this.precio);
                return "Actualizado";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        

        public int existe_produccionavios()
        {
            return Convert.ToInt32(existeavioproduccion.GetData(this.idproduccion).Max().Return_Status);
        }

        

        public string verificaavios()
        {

                int respuesta = querysadapter.verificaordenavios(this.idproduccion, this.id_ficha_avio, this.fecha);
                if(respuesta==1)
            {
                return "Agregado";
            }
                else
            {
                return "Error de coneccion";
            }
                
            
        }


        

        public DataTable busca_aviosportipo()
        {
            return aviostipo.GetData(this.tipo);
        }

        public DataTable busca_aviosportipobase()
        {
            return tablaaviosbasetipo.GetData(this.tipo); 
        }

        public string borra_avioficha()
        {
            try
            {
                querysadapter.borra_aviosficha(this.idavios, this.id_ficha_avio);
                return "Borrado";
            }
            catch
            {
                return "Error de coneccion";
            }
        }

        public DataTable buscatipobodega()
        {
            return tipomasbodega.GetData(this.tipo);
        }

    }
}
