using System.Threading.Tasks;

namespace NewsAggregator.Interfaces
{
    public interface IFirebaseAuthentication
    {
        Task<string> SignInFirebase(string email, string password);
        Task<string> CreateAccountFirebase(string email, string password);
    }
}
