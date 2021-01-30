namespace FluentValidation.Domain
{
    public class Developer
    {
        public Developer(string firstName, string lastName, string email, decimal experience)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Experience = experience;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Email { get; private set; }
        public decimal Experience { get; private set; }

    }
}