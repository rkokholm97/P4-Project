namespace P4FormsTest2
{
    public class Guest
    {
        public static int TotalId { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Reservation[] PreviousReservations { get; set; } //Ved ikke lige med den her
        public bool IsMember { get; set; }

        public Guest(string name, string phoneNumber, string email, Reservation[] previousReservations, bool isMember)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Email = email;
            PreviousReservations = previousReservations;
            IsMember = isMember;
            TotalId = TotalId + 1;
            Id = TotalId;
        }
    }
}
