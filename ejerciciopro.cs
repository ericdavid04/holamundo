using System;
namespace PROGRAMAS{
class ejerciciopro{
static void  Main(string []args){
      Console.Write("\nEJERCICIO PROPUESTO \n");
      Console.Write("\n****************************** \n");
     
      double x=1.23,y=2.34,z=3.45, w=4.56,r1,r2,rt;

      r1 = (0.045*x)+(2.33*y);
      
      r2= (Math.Pow(2.1*z,x) +((7.3*w)/(9.2 * z)- 1.23 * 2.34)-(3.45/4.56))* 4.5;
      
      rt = (r1 / r2) * (x*y*z*w);
      
      
      Console.WriteLine("\nEl resultado de los valores dados es : " + rt);
      Console.ReadKey();

     }
     }
}