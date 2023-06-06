using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Proxy
{
    internal class RemoteDataBaseServices : IDataBaseService
    {
        private List<string> _cacheDatas = new List<string>();
        public List<string> GetDatas()
        {
            if (_cacheDatas.Count == 0) 
            {
                _cacheDatas.Add("Alex");
                _cacheDatas.Add("is a student of");
                _cacheDatas.Add("ChengDu Neusoft University");
            }
            return _cacheDatas;
        }

        public void SetDatas(List<string> cacheDatas) 
        {
            if (cacheDatas.Count > 0)
            {
                _cacheDatas.Clear();
                _cacheDatas.AddRange(cacheDatas);
            }
        }

        public void SetData(string data)
        {
            if (!string.IsNullOrEmpty(data))
            {
                _cacheDatas.Add(data);
            }
        }
    }
}
