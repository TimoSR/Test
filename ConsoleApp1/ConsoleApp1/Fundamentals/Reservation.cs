namespace ConsoleApp1.Fundamentals
{
    public class Reservation
    {
        private User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            return (user.IsAdmin || MadeBy == user);
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}