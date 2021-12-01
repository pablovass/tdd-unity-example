using System;

namespace Heroes
{
    public partial class Calculator
    {
        private readonly ILog log;

        public Calculator(UnityLogAdapter log)
        {
            this.log =log;
        }
        public int Sum (int value1,int value2){ 
            
            if (value1<0|| value2<0)
            {
                throw new Exception();
            }

            var result = value1 + value2;
            log.Log($"{value1} + {value2} = {result}");
            return result;
        }
    }
}