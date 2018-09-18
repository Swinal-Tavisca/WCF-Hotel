using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelsClient.ServiceReference1;
namespace HotelsClient
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelClient hotelClient = new HotelClient("BasicHttpBinding_IHotel");
            int flag = 0;
            do
            {
                Console.WriteLine("1. GET ALL HOTELS");
                Console.WriteLine("2. GET HOTEL BY ID");
                Console.WriteLine("3. EXIT");
                Console.WriteLine();
                int option =int.Parse( Console.ReadLine());
               
                if (option==1)
                {
                    foreach(HotelData hotel in hotelClient.GetAllHotel())
                    {
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("HOTEL NAME : " + hotel.name);
                        Console.WriteLine("HOTEL ID : " + hotel.id);
                        Console.WriteLine("HOTEL ADDRESS : " + hotel.address);
                        Console.WriteLine("RATINGS : " + hotel.rating);
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine();
                    }

                }
                else if(option==2)
                {
                    Console.WriteLine("ENTER HOTEL ID");
                    int id = int.Parse(Console.ReadLine());
                    HotelData hotel = hotelClient.GetHotelById(id);

                    Console.WriteLine("--------------------------------");
                    Console.WriteLine("HOTEL NAME : " + hotel.name);
                    Console.WriteLine("HOTEL ID : " + hotel.id);
                    Console.WriteLine("HOTEL ADDRESS : " + hotel.address);
                    Console.WriteLine("RATINGS : " + hotel.rating);
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine();


                }
                else if(option==3)
                {
                    flag = 1;
                }
            } while (flag==0);
        }
    }
}
