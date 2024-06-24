namespace AcunMedyaMenu.Entities
{
    public class Booking
    {
        public int BookingID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime BookingDate { get; set; }
        public string BookingTime { get; set; }
        public int GuestCount { get; set; }
        public string Description { get; set; }
    }
}
