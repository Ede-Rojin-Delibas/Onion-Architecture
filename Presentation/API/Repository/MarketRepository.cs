using API.Modals;

namespace API.Repository
{
    public class MarketRepository
    {
        public List<Market> GetAllProducts() 
        {
            List<Market> productList = new List<Market>();
            Market product1 = new Market() { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi ="Soda",UrunId=2, Barkod=0610, kategoriAdi="İçecek",KategoriId=04};
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product4 = new Market() { UrunAdi = "Meyve suyu", UrunId = 4, Barkod = 0611, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product5 = new Market() { UrunAdi = "Peynir", UrunId = 5, Barkod = 0602, kategoriAdi = "Süt ve süt ü", KategoriId = 05 };
            Market product6 = new Market() { UrunAdi = "Çikolata", UrunId = 6, Barkod = 0614, kategoriAdi = "Atıştırmalık", KategoriId = 08 };
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            return productList;
        }
        public Market GetById(int UrunId)
        {
            List<Market> productList = new List<Market>();
            Market product1 = new Market() { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product4 = new Market() { UrunAdi = "Meyve suyu", UrunId = 4, Barkod = 0611, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product5 = new Market() { UrunAdi = "Peynir", UrunId = 5, Barkod = 0602, kategoriAdi = "Süt ve süt ü", KategoriId = 05 };
            Market product6 = new Market() { UrunAdi = "Çikolata", UrunId = 6, Barkod = 0614, kategoriAdi = "Atıştırmalık", KategoriId = 08 };
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            var model = productList.Where(x=> x.UrunId == UrunId).FirstOrDefault();
            return model;
        }
        public  List<Market> GetByName(string UrunAdi)
        {
            List<Market> productList = new List<Market>();
            Market product1 = new Market() { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product4 = new Market() { UrunAdi = "Meyve suyu", UrunId = 4, Barkod = 0611, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product5 = new Market() { UrunAdi = "Peynir", UrunId = 5, Barkod = 0602, kategoriAdi = "Süt ve süt ü", KategoriId = 05 };
            Market product6 = new Market() { UrunAdi = "Çikolata", UrunId = 6, Barkod = 0614, kategoriAdi = "Atıştırmalık", KategoriId = 08 };
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            var model2 = productList.Where(x=> x.UrunAdi.Contains(UrunAdi)).ToList();
            return model2;

        }
        public List<Market> GetByLabel(int Barkod)
        {
            List<Market> productList = new List<Market>();
            Market product1 = new Market() { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product4 = new Market() { UrunAdi = "Meyve suyu", UrunId = 4, Barkod = 0611, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product5 = new Market() { UrunAdi = "Peynir", UrunId = 5, Barkod = 0602, kategoriAdi = "Süt ve süt ü", KategoriId = 05 };
            Market product6 = new Market() { UrunAdi = "Çikolata", UrunId = 6, Barkod = 0614, kategoriAdi = "Atıştırmalık", KategoriId = 08 };
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            var model3=productList.Where(x=> x.Barkod == Barkod).OrderByDescending(x=> x.Barkod).ToList();
            return model3 ; 
        }
        public List<Market> GetByCategoryName(string kategoriAdi)
        {
            List<Market> productList = new List<Market>();
            Market product1 = new Market() { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product4 = new Market() { UrunAdi = "Meyve suyu", UrunId = 4, Barkod = 0611, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product5 = new Market() { UrunAdi = "Peynir", UrunId = 5, Barkod = 0602, kategoriAdi = "Süt ve süt ü", KategoriId = 05 };
            Market product6 = new Market() { UrunAdi = "Çikolata", UrunId = 6, Barkod = 0614, kategoriAdi = "Atıştırmalık", KategoriId = 08 };
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            return productList;

        }
        public List<Market> GetByCategoryId(int KategoriId)
        {
            List<Market> productList = new List<Market>();
            Market product1 = new Market() { UrunAdi = "Makarna", UrunId = 1, Barkod = 0608, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product2 = new Market() { UrunAdi = "Soda", UrunId = 2, Barkod = 0610, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product3 = new Market() { UrunAdi = "Sıvı yağ", UrunId = 3, Barkod = 0609, kategoriAdi = "Temel gıda", KategoriId = 01 };
            Market product4 = new Market() { UrunAdi = "Meyve suyu", UrunId = 4, Barkod = 0611, kategoriAdi = "İçecek", KategoriId = 04 };
            Market product5 = new Market() { UrunAdi = "Peynir", UrunId = 5, Barkod = 0602, kategoriAdi = "Süt ve süt ü", KategoriId = 05 };
            Market product6 = new Market() { UrunAdi = "Çikolata", UrunId = 6, Barkod = 0614, kategoriAdi = "Atıştırmalık", KategoriId = 08 };
            productList.Add(product1);
            productList.Add(product2);
            productList.Add(product3);
            productList.Add(product4);
            productList.Add(product5);
            productList.Add(product6);
            var model4 = productList.Where(x=> x.KategoriId==KategoriId).ToList();
            return model4;
        }

    }
}
