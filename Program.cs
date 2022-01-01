using System;
namespace recurisivemethods 
{
    class Program
    {
        static void Main(string[] args)
        {    //Rekursif - oz yinelemli
            //3^4=3*3*3*3
            int result= 1 ;
            for (int i=1 ; i<5; i++)
                result = result*3 ;
            Console.WriteLine(result);

            operations instance = new() ;
            Console.WriteLine(instance.Expo(3,4)) ;
            //Extension Methods
            string expression = "baris demirkap" ;
            bool result2 = expression.CheckSpaces() ;
            Console.WriteLine(result2) ;
            if(result2)
            {
                Console.WriteLine(expression.RemoveWhiteSpaces) ;
            }
            Console.WriteLine(expression.MakeUpperCase) ;
            Console.WriteLine(expression.MakeLowerCase) ;


        }
    }

    public class operations
    {
        public int Expo (int number1, int power)
        {
            if(power<2)
                return number1;
            return Expo (number1,power-1)*number1;
        }
        //Expo(3,4)
        // Expo (3,3)*3
        // Expo (3,2)*3*3 ;
        // Expo (3,1)*3*3*3 ;
        // Expo 3*3*3*3=3^4 ;


    }
    public static class Extension
    {
        public static bool CheckSpaces (this string money)
        {
            return money.Contains(" ");
        }

        public static string RemoveWhiteSpaces (this string param)
            {
                string[] sequences = param.Split(" ") ;
                 return string.Join("", sequences) ;
            }
             public static string MakeUpperCase(this string param)
            {
                return param.ToUpper () ;
            }
            public static string MakeLowerCase(this string param)
            {
                return param.ToLower () ;
            }




    }  
}