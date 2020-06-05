using System;

namespace Aula11Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
          Calcular infoplayer =new Calcular();
            
        
          System.Console.WriteLine(infoplayer.calcular());

          System.Console.WriteLine(infoplayer.calcular(89));

          System.Console.WriteLine(infoplayer.calcular(11, 89));

          System.Console.WriteLine(infoplayer.calcular("suporte","1100"));  
        }    
    }
}
