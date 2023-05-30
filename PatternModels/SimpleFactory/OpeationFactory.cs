using System;
namespace DesignPattern.PatternModels.SimpleFactory
{
    public class OpeationFactory
    {
        /**
            We can create a OperationBase instance using by factory mind.
            Input operate and the function output dest operate.
         */
        public OperationBase CreateOperation(string operate)
        {
            OperationBase operation = null;
            switch (operate)
            {
                case "+":
                    operation = new OperationAdd();
                    break;
                case "-":
                    operation = new OperationSub();
                    break;
                case "*":
                    operation = new OperationMul();
                    break;
                case "/":
                    operation = new OperationDiv();
                    break;
            }
            return operation;
        }

        /*/// <summary>
        /// 通过工厂模式创建对象来使用
        /// </summary>
        /// <param name="args"></param>

        private static void Main(string[] args)
        {
            OpeationFactory opeationFactory = new OpeationFactory();
            OperationBase operation = opeationFactory.CreateOperation("+");
            operation.NumX = 10000;
            operation.NumY = 10086;
            double result = operation.GetResult();
            Console.WriteLine(result);
        }*/
    }
}
