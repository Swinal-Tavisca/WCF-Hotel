using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientHotel clientHotel = new ClientHotel("BasicHttpBinding_IHotel");

            Console.WriteLine("Welcome User");
            while (true)
            {
                Console.WriteLine("1. Get All Hotels");
                Console.WriteLine("2. Get Hotel By Id");
                Console.WriteLine("3. Exit");
                int choice;
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Console.Write("Hotel Id\t");
                        Console.Write("Hotel Name\t");
                        Console.Write("Hotel Address\t");
                        Console.WriteLine("Hotel Ratings\t");
                        foreach (HotelData hotel in hotelOperationsClient.GetAllHotels())
                        {
                            Console.Write(hotel.HotelId + "\t\t");
                            Console.Write(hotel.HotelName + "\t\t");
                            Console.Write(hotel.HotelAddress + "\t\t");
                            Console.WriteLine(hotel.Ratings);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter Hotel Id");
                        int hotelId;
                        int.TryParse(Console.ReadLine(), out hotelId);
                        Console.Write("Hotel Id\t");
                        Console.Write("Hotel Name\t");
                        Console.Write("Hotel Address\t");
                        Console.WriteLine("Hotel Ratings\t");
                        HotelData hotelData = hotelOperationsClient.GetHotelById(hotelId);
                        Console.Write(hotelData.HotelId + "\t\t");
                        Console.Write(hotelData.HotelName + "\t\t");
                        Console.Write(hotelData.HotelAddress + "\t\t");
                        Console.WriteLine(hotelData.Ratings);
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        break;
                }
            }
        }
    }
}
