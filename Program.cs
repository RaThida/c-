using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week6_example
{
    class Phone
    {
        public string strModel;
        public float fltPrice;
        public static int intCount;
        public static float fltTotalPrice;

        public Phone(string strModel, float fltPrice)
        {
            this.strModel = strModel;
            this.fltPrice = fltPrice;
            intCount ++;
            fltTotalPrice = fltPrice + fltTotalPrice;

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone objP1, objP2;
            Console.WriteLine("Enter the model of phone1: ");
            string strModel = Console.ReadLine();
            Console.WriteLine("Enter the price of phone1: ");
            float fltPrice = float.Parse(Console.ReadLine());
            objP1 = new Phone(strModel, fltPrice);

            Console.WriteLine("Enter the model of phone2: ");
            strModel = Console.ReadLine();
            Console.WriteLine("Enter the price of phone2: ");
            fltPrice = float.Parse(Console.ReadLine());
            objP2 = new Phone(strModel, fltPrice);

            Console.WriteLine("Phone 1 model: {0} price: {1}",
                objP1.strModel, objP1.fltPrice);
            Console.WriteLine("Phone 2 model: {0} price: {1}",
               objP2.strModel, objP2.fltPrice);
            Console.WriteLine("Total number of phone = {0}.", Phone.intCount);
            Console.WriteLine("Total Price = {0}", Phone.fltTotalPrice);

        }
    }
}
