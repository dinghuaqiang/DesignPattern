using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.PatternModels.TemplateMethod
{
    /// <summary>
    /// 实现公共方法,定义模板方法,子类去实现
    /// </summary>
    public abstract class UpdateBase
    {
        public void Update() 
        {
            //检查版本
            CheckVer();
            //对比资源
            CompareRes();
            //下载资源
            DownloadRes();
            //解压缩
            Extract();
            //重载资源
            ReloadRes();
        }

        private void CheckVer()
        {
            Console.WriteLine("检查版本...");
        }

        private void CompareRes() 
        {
            Console.WriteLine("对比资源...");
        }

        private void DownloadRes() 
        {
            Console.WriteLine("下载资源...");
        }

        private void ReloadRes() 
        {
            Console.WriteLine("重载资源...");
        }

        /// <summary>
        /// 解压缩资源,模板方法，子类重载实现
        /// </summary>
        public abstract void Extract();
    }
}
