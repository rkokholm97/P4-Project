using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P4FormsTest2
{
    public class Reservation
    {
        public static int TotalId { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public Room Room { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int NumberOfGuests { get; set; }
        public int NumberOfAdults { get; set; }
        public int NumberOfChildren { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Reservation (string name, Room room, DateTime start, DateTime end, string phoneNumber, string email, int numberOfAdults, int numberOfChildren)
        {
            Name = UpperFirst(name);
            Room = room;
            Start = start;
            End = end;
            PhoneNumber = phoneNumber;
            Email = email;
            NumberOfAdults = numberOfAdults;
            NumberOfChildren = numberOfChildren;
            NumberOfGuests = numberOfAdults + numberOfChildren;
            TotalId = TotalId + 1;
            Id = TotalId; 
        }

        public override string ToString()
        {
            return $"{Name}   |   {Start.ToString("dd/MM")} - {End.ToString("dd/MM")}";
        }

        public static string UpperFirst(string String)
        {
            return char.ToUpper(String[0]) + String.Substring(1);
        }

        private string SplitPhoneNumber(string Number)
        {
            return Regex.Replace(Number, ".{2}", "$0 ");
        }
    }
}
