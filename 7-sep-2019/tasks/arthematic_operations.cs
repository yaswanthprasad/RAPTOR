using System;
using System.IO;
using System.Text;

namespace arthematic_operations
{
   public class main_class
   {
      static System.Random random_generator = new System.Random();
      public static void Main(string[] args)
      {
         string raptor_prompt_variable_zzyz;
         ?? b;
         ?? c;
         ?? a;
         ?? f;
         ?? g;
         ?? d;
         ?? h;
      
         raptor_prompt_variable_zzyz ="enter first number";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         a= Double.Parse(Console.ReadLine());
         raptor_prompt_variable_zzyz ="enter second number";
         Console.WriteLine(raptor_prompt_variable_zzyz);
         b= Double.Parse(Console.ReadLine());
         c =a+b;
         Console.WriteLine("sum of first and second number is"+c);
         d =a-b;
         Console.WriteLine("difference od first and second number is"+d);
         f =a*b;
         Console.WriteLine("product of first and second number is"+f);
         g =a/b;
         Console.WriteLine("division of first and second number is"+g);
         h =a % b;
         Console.WriteLine("mod od first and second number is"+h);
      }
   }
}
