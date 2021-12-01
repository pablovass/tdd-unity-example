using UnityEngine;

namespace Heroes
{
    public partial class Calculator
    {
        public class  UnityLogAdapter : ILog
        {
            public  void Log(string message)
            {
                Debug.Log(message);
            }

            public int Count()
            {
                return 1;
            }
        }
    }
}