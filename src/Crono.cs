
using System;
using System.Globalization; 
namespace ConsoleApp1 
{
    class Program 
    {
        public static  void RetrnData(){
            int inputyear,input_number_day;
            DateTime mydata = new DateTime();
            Calendar myclendar = CultureInfo.InvariantCulture.Calendar;
            Console.Write("Introduceti un an: ");
            inputyear=Convert.ToInt32(Console.ReadLine())-1;
            mydata = myclendar.AddYears(mydata,inputyear);
            Console.Write("Introduceti ziua din an ce va intereseza: ");
            input_number_day = Convert.ToInt32(Console.ReadLine())-1;
            mydata = myclendar.AddDays(mydata,input_number_day);

                
                Console.Clear();    
                Console.Write("Anul:  {0} \nNumarulzilei: {1} \n",mydata.Year,++input_number_day);
                Console.WriteLine("Luna: {0}",mydata.Month);
                Console.WriteLine("Data zilei: {0}",mydata.Date);
                Console.WriteLine("Ziua saptamini: {0}",mydata.DayOfWeek);

                
            

        }
        static void Main(string[] args)  
        {
            RetrnData();
            
        }   
    }   
    
}

