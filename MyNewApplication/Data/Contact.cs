namespace MyNewApplication.Data
{
    public class Contact
    {
        public Contact(string name, string email, string message)
        {
            Name = name;
            Email = email;
            Message = message;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
