using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FlightBooking.Entities
{
    [BsonIgnoreExtraElements] // MongoDB'den gelen ekstra alanları görmezden gel
    public class Flight
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)] // MongoDB ObjectId olarak sakla,C# tarafında string olarak kullan.
        public string FlightId { get; set; } // ObjectId
        public string FlightNumber { get; set; } // TK123, PC2023
        public string AirlineCode { get; set; } // TK, PC, LH
        public string DepartureAirportCode { get; set; } // IST
        public string DepartureAirportName { get; set; } // İstanbul Havalimanı
        public string ArrivalAirportCode { get; set; } // LHR
        public string ArrivalAirportName { get; set; } // London Heathrow
        public DateTime DepartureTime { get; set; }
        public DateTime ArrivalTime { get; set; }
        public int DurationMinutes { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal BasePrice { get; set; }
        public string Currency { get; set; } // TRY, EUR, USD
        public string Status { get; set; }  // Scheduled, Delayed, Cancelled, Completed

    }
}