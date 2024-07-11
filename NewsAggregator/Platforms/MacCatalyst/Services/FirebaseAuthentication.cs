using System;
using System.Threading.Tasks;
using NewsAggregator.Interfaces;
using Firebase.Auth;

namespace NewsAggregator.Services
{
    public class FirebaseAuthentication : IFirebaseAuthentication
    {
        public async Task<string> CreateAccountFirebase(string email, string password)
        {
            var result = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
            var tokenResourse = result.User.GetIdToken(false);
            return tokenResourse.ToString();
        }

        public async Task<string> SignInFirebase(string email, string password)
        {
            var result = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
            var tokenResourse = result.User.GetIdToken(false);
            return tokenResourse.ToString();
        }
    }
}
