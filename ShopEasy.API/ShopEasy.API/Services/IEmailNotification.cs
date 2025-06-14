namespace ShopEasy.API.Services
{
    public interface IEmailNotifiactionService
    {
        void  EmailNotifiaction(string email); 
    }

    public class EmailNotificationService : IEmailNotifiactionService
    {
        public void EmailNotifiaction(string email)
        {
            Console.WriteLine($"Email sent : {email}");
        }
    }
}
