using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace TiendaVirtual.Controllers
{
	[ApiController]
	[Route("api/inventario")]
	public class InventarioController : Controller
	{
		//private readonly TiendaVirtualContext _context;
		//public InventarioController(TiendaVirtualContext _context)
		//{
		//	this._context = _context;
		//}

		[HttpPost]
        [Route("api/inventario/disponibilidad")]
        public async Task<string> PostDisponibilidadNeta(string sku_id)
		{
			BuyBLL buy = new BuyBLL(_context);
			string response = buy.SaveBuy(resquest);

			return response;
		}

        [HttpPost]
        [Route("api/inventario/inventario")]
        public async Task<string> PostInventario(string sku_id)
        {
            BuyBLL buy = new BuyBLL(_context);
            string response = buy.SaveBuy(resquest);

            return response;
        }

        [HttpPost]
        [Route("api/inventario/unidades")]
        public async Task<string> PostUnidades(string sku_id)
        {
            BuyBLL buy = new BuyBLL(_context);
            string response = buy.SaveBuy(resquest);

            return response;
        }
    }
}
