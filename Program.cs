using System;
using System.Collections.Generic;
using System.Linq;
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
                        Problema1.p1();
                        break;
                    case 2:
                        Problema2.p2();
                        break;
                    case 3:
                        Problema3.p3();
                        break;
                    case 4:   
                        Problema4.p4();
                        break;
                    case 5:
                        Problema5.p5();
                        break;
                    case 6:
                        Problema6.p6();
                        break;
                    case 7:
                        Problema7.p7();
                        break;
                    case 8: 
                        Problema8.p8();
                        break;
                    case 9:
                        Problema9.p9();
                        break;                    
                    case 10:
                        Problema10.P10();
                        break;
                    case 11:
                        Problema11.P11();
                        break;
                    case 12:
                        
                    case 13:
                        
                    case 14:
                            
                       
                    case 15:
                            
                        
                    case 16:
                        
                    case 17:
                        
                    case 18:
                       
                    case 19:
                       
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
                       
                    case 29:
                      
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
