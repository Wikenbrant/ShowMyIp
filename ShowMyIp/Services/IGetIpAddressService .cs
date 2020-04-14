using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShowMyIp.Services
{
    public interface IGetIpAddressService
    {
        public string Get();
        public string GetRequestIp(bool tryUseXForwardHeader = true);
    }
}
