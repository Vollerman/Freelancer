using FreelancerProject.Common;

namespace FreelancerProject.Entities
{
    public class Customer : Person<Guid>
    {
        public string PhoneNumber { get; set; }
        public string GetValueCSV()
        {
            return $"{Id},{FirstName},{LastName},{PhoneNumber}";
        }
        public void SetValuesCSV(string csvLine)
        {
            string[] data = csvLine.Split(',');
            Id = Guid.Parse(data[0]);
            CreatedOn = DateTimeOffset.Parse(data[4]);
            FirstName = data[2];
            LastName = data[3];
            PhoneNumber = data[4];
        }
    }
}