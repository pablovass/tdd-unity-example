namespace TDDProject.Assets.Scripts.Heroes
{
    public class Calculator
    {
        public int Sum (int value1,int value2){ 
            
            if (value1<0|| value2<0)
            {
                throw new System.Exception();
            }
            return value1+value2;
         }
    }
}