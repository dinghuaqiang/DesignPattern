using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Proxy
{
    public class DataBaseServicesProxy : IDataBaseService
    {
        private readonly RemoteDataBaseServices _remoteDBServices;
        private List<string> _cacheDatas = new List<string>();

        public DataBaseServicesProxy() 
        {
            _remoteDBServices = new RemoteDataBaseServices();
        }

        public List<string> GetDatas()
        {
            if (_cacheDatas.Count <= 0)
            {
                _cacheDatas = _remoteDBServices.GetDatas();
            }
            return _cacheDatas;
        }

        public void AddData(string data)
        {
            _remoteDBServices.SetData(data);
        }
    }
}
