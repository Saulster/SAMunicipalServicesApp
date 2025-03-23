using System;

namespace PROG7312ST10202241.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Location { get; set; }

        private DateTime _date;

        public DateTime Date
        {
            get => _date;
            set
            {
                if (value < DateTime.Now)
                    throw new ArgumentException("Event date cannot be in the past.");
                _date = value;
            }
        }

        public Event(string name, string category, DateTime date, string location)
        {
            Name = name;
            Category = category;
            Date = date;  // This line will trigger the validation if `date` is in the past.
            Location = location;
        }
    

    public override string ToString()
        {
            return $"{Name} - {Category} - {Date.ToShortDateString()} - {Location}";
        }
    }
}