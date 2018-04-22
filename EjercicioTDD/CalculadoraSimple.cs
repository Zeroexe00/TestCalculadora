using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTDD
{
    public class CalculadoraSimple
    {
        private static int toInt(string a) {
            return (a.Equals("")) ? 0 : Convert.ToInt32(a);
        } 


    public static int Suma(object a , object b)
        {
            int p = (a.GetType().Name.Equals("String")) ? toInt(a.ToString())  : Convert.ToInt32(a);
            int q = (b.GetType().Name.Equals("String")) ? toInt(b.ToString()) : Convert.ToInt32(b); 
            return p +q;
        } 

        public static int Resta(int f,int g)
        {
            int res = f - g;
            return res;
        }
        public static int Resta(string a, string b)
        {
            
            return  toInt(a) - toInt(b);
        }
        public static int Multi (int a, int v)
        {
            return a * v;
        }
        public static int Multi(string a , string b)
        {
            return toInt(a) * toInt(b);
        }
        public static double RaizCuadrada(int a)
        {
            double res = Math.Sqrt(a);
            return res;
        }
        public static double Potencia(int a, int b)
        {
            double res = Math.Pow(a,b);
            return res;
        }
        public static int Division(int a, int b)
        {
            int res = a / b;
            return res;
        }
        public static double Division(double a,double b)
        {
             double res = a / b;
            return Math.Round(res);
        }
        public static double Residuo(int a, int b)
        {
            int res = a % b;
            return res;
        }

    }

}
