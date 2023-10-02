namespace FreelancerProject.Common
{
    public class Person<TKey> : EntityBase<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}