using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Setul3;
using Setul3.Probleme;

namespace Setul3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Introduceti numarul problemei:");
                int nrp = int.Parse(Console.ReadLine());
                Console.WriteLine("Problema " + nrp);
                switch(nrp)
                {
                    case 1:
                        Problema1.P1();
                        break;
                    case 2:
                        Problema2.P2();
                        break;
                    case 3:
                        Problema3.P3();
                        break;
                    case 4:   
                        Problema4.P4();
                        break;
                    case 5:
                        Problema5.P5();
                        break;
                    case 6:
                        Problema6.P6();
                        break;
                    case 7:
                        Problema7.P7();
                        break;
                    case 8: 
                        Problema8.P8();
                        break;
                    case 9:
                        Problema9.P9();
                        break;                    
                    case 10:
                        Problema10.P10();
                        break;
                    case 11:
                        Problema11.P11();
                        break;
                    case 12:
                        Problema12.P12();
                        break;
                    case 13:
                        Problema13.P13();
                        break;
                    case 14:
                        Problema14.P14();
                        break;
                    case 15:
                        Problema15.P15();
                        break;
                    case 16:
                        Problema16.P16();
                        break;
                    case 17:
                        Problema17.P17();
                        break;
                    case 18:
                       Problema18.P18();
                        break;
                    case 19:
                       Problema19.P19();
                        break;
                    case 20:
                      
                    case 21:
                     
                    case 22:
                            
                      
                    case 23:
                      
                    case 24:
                            
                       
                    case 25:
                            
                      
                    case 26:
                        Problema26.P26();
                        break;
                    case 27:

                    case 28:
                        Problema28.p28();
                        break;
                    case 29:
                       Problema29.p29();
                        break;
                    case 30:
                       
                    case 31:
                        break;
                    default:
                        break;

                }  
                Console.ReadKey();
            }
        }
    }
}
