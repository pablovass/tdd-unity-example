using UnityEngine;

namespace Heroes
{
    public partial class Calculator
    {
        public class  UnityLogAdapter : Ilog
        {
            public  void Log(string message)
            {
                Debug.Log(message);
            }
        }
    }
}