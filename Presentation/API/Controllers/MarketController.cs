using API.Modals;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarketController : ControllerBase
    {
        [HttpGet("ProductList")]
        public IActionResult ProductList() 
        {
            List<Market> prolist = new List<Market>();
            Market product1 = new Market { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            prolist.Add(product1);
            prolist.Add(product2);
            prolist.Add(product3);
            var model=prolist.ToList();
            return Ok(model);
        }
        [HttpGet("GetWithId")]
        public IActionResult GetWithId(int UrunId)
        {
            List<Market> prolist = new List<Market>();
            Market product1 = new Market { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            prolist.Add(product1);
            prolist.Add(product2);
            prolist.Add(product3);
            var model = prolist.Where(x=> x.UrunId == UrunId).FirstOrDefault();
            return Ok(model);
        }

    }

}
