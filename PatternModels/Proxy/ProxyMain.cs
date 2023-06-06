using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.Proxy
{
    /// <summary>
    /// 定义了远程服务接口IDatabaseService和实现类RemoteDatabaseService，代理类DatabaseServiceProxy实现了该接口，
    /// 并使用远程服务对象_remoteService来实现实际的数据获取，
    /// 同时在代理类中缓存了远程服务的数据，以便下一次访问时直接从缓存中获取，避免了频繁的网络访问。
    /// 客户端代码中，我们使用代理类来访问远程服务，并输出获取到的数据。
    /// 这个示例展示了代理模式的一个常见应用场景，即在访问远程服务时使用代理类进行控制和优化。
    /// </summary>
    public class ProxyMain
    {
        //private static void Main(string[] args)
        //{
        //    Console.WriteLine("Proxy partten learning test.");

        //    DataBaseServicesProxy proxy = new DataBaseServicesProxy();
        //    List<string> datas = proxy.GetDatas();
        //    string result = "";
        //    foreach (string data in datas) 
        //    {
        //        result += data;
        //    }
        //    Console.WriteLine(result);

        //    proxy.AddData(" who already graduated.");
        //    string secResult = "";
        //    foreach (string data in datas) 
        //    {
        //        secResult += data;
        //    }
        //    Console.WriteLine(secResult);

        //    Console.ReadKey();
        //}
    }
}
