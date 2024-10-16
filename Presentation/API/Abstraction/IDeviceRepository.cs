using API.Modals;

namespace API.Abstraction
{
    public interface IDeviceRepository
    {
        //Tüm cihazları döndüren bir method tanımlanıyor.
        List<Device> GetDevices();
        Device GetId(int Id);   //Device türünde bir nesne döndürür.
        List<Device> GetByName(string Name);
    }
}
