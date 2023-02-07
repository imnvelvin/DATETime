using System;
using System.Text.RegularExpressions;

namespace HomeWorkGroup2._7._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Group[] groups = new Group[0];

            string opt;
            do
            {

                Console.WriteLine("1. Qrup Elave et");

                Console.WriteLine("2.Qruplara Bax");

                Console.WriteLine("3. Typina gore bax");

                Console.WriteLine("4. Cixis");

                opt = Console.ReadLine();   
                
                
                
                switch (opt)
                {
                    case "1":
                        Console.WriteLine("No:");

                        string no = Console.ReadLine();

                        Console.WriteLine("Type");

                        string type = Console.ReadLine();

                        Console.WriteLine("StartDate:");

                        string startDateStr = Console.ReadLine();

                        DateTime startDate = Convert.ToDateTime(startDateStr);

                        Group group = new Group




                        {
                            No = no,

                            Type = type,

                            StartDate = startDate

                        };



                        Array.Resize(ref groups, groups.Length+1);

                        groups[groups.Length-1] = group;

                        break;

                        case "2":

                        foreach (var gr in groups)



                        {
                            Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd mm yy hh:mm")}");
                        }


                        break;

                        case "3":

                        Console.WriteLine("Type:");

                        type = Console.ReadLine();




                        foreach (var gr in groups)
                        {
                            if(gr.Type == type)
                                Console.WriteLine($"No: {gr.No} - Type: {gr.Type} - StartDate: {gr.StartDate.ToString("dd mm yy hh:mm")}");
                        }
                        break;
                    case "0":

                        Console.WriteLine("Program Bittdi");

                        break;

                    default:

                        Console.WriteLine("Seciminizi yanlistir"); 

                        break;
                }

            }while(opt!="0");
           
            
          
        }
    }
}
