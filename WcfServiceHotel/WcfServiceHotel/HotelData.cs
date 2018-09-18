using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceHotel
{
    [DataContract]
    class HotelData
    {
        [DataMember]
        public String name;
        [DataMember]
        public int id;
        [DataMember]
        public string address;
        [DataMember]
        public int rating;
    }
    [ServiceContract]
    interface IHotel
    {
        [OperationContract]
        List<HotelData> GetAllHotel();
        [OperationContract]
        HotelData GetHotelById(int id);
    }
    class Hotel : IHotel
    {
        public List<HotelData> GetAllHotel()
        {
            List<HotelData> hotelList = new List<HotelData>();
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "/" + "HotelList.json";
            using (StreamReader streamReader = new StreamReader(path))
            {
                var readData = streamReader.ReadToEnd();
                hotelList = JsonConvert.DeserializeObject<List<HotelData>>(readData);
            }
            return hotelList;
        }

        public HotelData GetHotelById(int id)
        {
            var hotel = GetAllHotel().Find(x => x.id == id);
            return hotel;

        }
    }


}
