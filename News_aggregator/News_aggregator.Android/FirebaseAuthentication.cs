using System;
using System.Threading.Tasks;
using Firebase.Auth;
using News_aggregator.Interfaces;

namespace News_aggregator.Droid
{
    public class FirebaseAuthentication : IFirebaseAuthentication
    {
        public async Task<string> CreateAccountFirebase(string email, string password)
        {
            var result = await FirebaseAuth.Instance.CreateUserWithEmailAndPasswordAsync(email, password);
            var tokenResourse = await result.User.GetIdTokenAsync(false);
            return tokenResourse.Token.ToString();
        }

        public async Task<string> SignInFirebase(string email, string password)
        {
            var result = await FirebaseAuth.Instance.SignInWithEmailAndPasswordAsync(email, password);
            var tokenResourse = await result.User.GetIdTokenAsync(false);
            return tokenResourse.Token.ToString();
        }
    }
}
