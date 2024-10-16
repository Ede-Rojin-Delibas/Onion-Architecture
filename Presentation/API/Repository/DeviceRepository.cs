using API.Abstraction;
using API.Modals;

namespace API.Repository
{
    public class DeviceRepository : IDeviceRepository
    {
        public List<Device> GetDevices()
        {
            List<Device> devices = new List<Device>();
            Device device1 = new Device() { Name = "Tarayıcı", Id = 1, Ip = "10.11.13.100", sehir = "İzmir" };
            Device device2 = new Device() { Name = "Printer", Id = 2, Ip = "10.11.14.102", sehir = "Ankara" };
            devices.Add(device1);
            devices.Add(device2);
            return devices;

        }
        public Device GetId(int Id )
        {
            List<Device> devices = new List<Device>();
            Device device1 = new Device() { Name = "Tarayıcı", Id = 1, Ip = "10.11.13.100", sehir = "İzmir" };
            Device device2 = new Device() { Name = "Printer", Id = 2, Ip = "10.11.14.102", sehir = "Ankara" };
            devices.Add(device1);
            devices.Add(device2);
            var model = devices.Where(x=> x.Id == Id).FirstOrDefault();
            return model;

        }
        public List<Device> GetByName(string Name)
        {
            List<Device> devices = new List<Device>();
            Device device1 = new Device() { Name = "Tarayıcı", Id = 1, Ip = "10.11.13.100", sehir = "İzmir" };
            Device device2 = new Device() { Name = "Printer", Id = 2, Ip = "10.11.14.102", sehir = "Ankara" };
            devices.Add(device1);
            devices.Add(device2);
            var model2 = devices.Where(x => x.Name.Contains(Name)).ToList();
            return model2;
        }
    }
}
