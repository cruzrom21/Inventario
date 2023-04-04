using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventarioBLL
{
    public class Inventario
    {
        private readonly InventarioContext _context;
        public Inventario(InventarioContext _context)
        {
            this._context = _context;
        }

        public string DisponibilidadNeta(string sku_id)
        {
            try
            {
               Total inventario -(Unidades comprometidas + UnidadesUbicacion despachadas)

                string JsonString = JsonConvert.SerializeObject(new
                {
                    products = list,
                    status = "success"
                });

                return JsonString;
            }
            catch (Exception ex)
            {
                string JsonString = JsonConvert.SerializeObject(new
                {
                    status = "Ocurrio un problema" + ex.Message
                });

                return JsonString;
            }
        }


        public string TotalInventario(string sku_id)
        {
            try
            {
                
                Unidades comprometidas + UnidadesUbicacion despachadas + unidades si ubicacion 

                string JsonString = JsonConvert.SerializeObject(new
                {
                    products = list,
                    status = "success"
                });

                return JsonString;
            }
            catch (Exception ex)
            {
                string JsonString = JsonConvert.SerializeObject(new
                {
                    status = "Ocurrio un problema" + ex.Message
                });

                return JsonString;
            }
        }


        public string UnidadesUbicacion(string sku_id)
        {
            try
            {
                cantidad reserva cantidad activo cantidad almacenada 
                string JsonString = JsonConvert.SerializeObject(new
                {
                    products = list,
                    status = "success"
                });

                return JsonString;
            }
            catch (Exception ex)
            {
                string JsonString = JsonConvert.SerializeObject(new
                {
                    status = "Ocurrio un problema" + ex.Message
                });

                return JsonString;
            }
        }
    }
}
