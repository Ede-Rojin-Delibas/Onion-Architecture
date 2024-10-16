using API.Modals;

namespace API.Abstraction
{
    public interface IMarketRepo
    {
        List<Market> GetAllProducts();
        Market GetById(int UrunId);

        List<Market> GetByName(string UrunAdı);

        List<Market> GetByLabel(string Barkod);
        List<Market> GetByCategoryName(string kategoriAdı);

        List<Market> GetByCategoryId(int KategoriId);
    }
}
