using API.Modals;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")] //yönlendirme şablonu ; http isteklerini bu şablona göre yönlendirir.
    [ApiController]
    public class DeviceController : ControllerBase  //DeviceList methodunun httpget isteği ile çağırıldığını belirtir.url den api/device/deviceList
    {
        [HttpGet("DeviceList")] 
        public IActionResult DeviceList(int Id)
        { Device device1 = new Device { Name = "Screen", Id = 1, Ip = "10.12.124.100", sehir = "Ankara" };
            Device device2 = new Device { Name = "Switch", Id = 2, Ip = "10.11.124.100", sehir = "İstanbul" };
            Device device3 = new Device { Name = "Printer", Id = 3, Ip = "10.18.124.100", sehir = "Muğla" };
            Device device4 = new Device { Name = "Hub", Id = 4, Ip = "10.22.124.100", sehir = "Karaman" };
            Device device5 = new Device { Name = "Connector", Id = 5, Ip = "10.24.124.100", sehir = "Elazığ" };

            List<Device> deviceList = new List<Device>();
            deviceList.Add(device1);
            deviceList.Add(device2);
            deviceList.Add(device3);
            deviceList.Add(device4);
            deviceList.Add(device5);
            var List = deviceList.Where(x => x.Id == Id).ToList();
            return Ok(List);//Filtrelenmiş cihaz listesini HTTP 200 OK yanıtı ile döndürür.
        }
        [HttpGet("GetTheNames")]
        public IActionResult GetTheNames(string Name)
        {
            Device device1 = new Device { Name = "Screen", Id = 1, Ip = "10.12.124.100", sehir = "Ankara" };
            Device device2 = new Device { Name = "Switch", Id = 2, Ip = "10.11.124.100", sehir = "İstanbul" };
            Device device3 = new Device { Name = "Printer", Id = 3, Ip = "10.18.124.100", sehir = "Muğla" };
            List<Device> deviceList = new List<Device>();   
            deviceList.Add(device1);
            deviceList.Add(device2);
            deviceList.Add(device3);
            var modelName= deviceList.Where(x=> x.Name == Name).ToList();
            return Ok(modelName);

        }
        


    }
}
