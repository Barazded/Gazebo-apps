using System;
using System.Threading.Tasks;
using Firebase.Auth;
using News_aggregator.Interfaces;

namespace News_aggregator.iOS
{
    public class FirebaseAuthenticationIos : IFirebaseAuthentication
    {
        public async Task<string> CreateAccountFirebase(string email, string password)
        {
            var result = await Auth.DefaultInstance.CreateUserAsync(email, password);
            var tokenResourse = await result.User.GetIdTokenAsync(false);
            return tokenResourse;
        }

        public async Task<string> SignInFirebase(string email, string password)
        {
            var result = await Auth.DefaultInstance.SignInWithPasswordAsync(email, password);
            var tokenResourse = await result.User.GetIdTokenAsync(false);
            return tokenResourse;
        }
    }
}