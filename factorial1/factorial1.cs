using System;

namespace PROGRAMAS{
class factorial1{

     static void Main(){
         
         string mensaje="Programa que calcule el factorial de uno numero";

          int numero = 0,  factorial=1;

          Console.Clear();
          Console.WriteLine( mensaje );

          Console.Write("\nIngresa el numero parara calcular factorial : ");
          numero=int.Parse(Console.ReadLine());


          for (int i = 1; i <=numero; i++)
          {
               factorial =factorial *i;
         
          }

          Console.WriteLine("\nEl factorial del numero: {0} es {1}",numero, factorial );
          Console.ReadLine();



     }
}

}