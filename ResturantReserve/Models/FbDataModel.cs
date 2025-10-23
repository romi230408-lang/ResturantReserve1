﻿using Firebase.Auth;
using Firebase.Auth.Providers;
using Plugin.CloudFirestore;
using ResturantReserve.Models;

namespace ResturantReserve.Models
{
    abstract class FbDataModel
    {
        protected FirebaseAuthClient facl;
        protected IFirestore fdb;
        public string DisplayName => facl != null && facl.User != null ? facl.User.Info.DisplayName : string.Empty;
        public string UserId => facl != null ? facl.User.Uid : string.Empty;
        public abstract string GetErrorMessage(string errMessage);
        public abstract void CreateUserWithEmailAndPasswordAsync(string email, string password, string name, Action<System.Threading.Tasks.Task> OnComplete);
        public abstract void SignInWithEmailAndPasswordAsync(string email, string password, Action<System.Threading.Tasks.Task> OnComplete);
        public FbDataModel()
        {
            FirebaseAuthConfig fac = new()
            {
                ApiKey = Keys.FbApiKey,
                AuthDomain = Keys.FbAppDomainKey,
                Providers = [new EmailProvider()]
            };
            facl = new FirebaseAuthClient(fac);
            fdb = CrossCloudFirestore.Current.Instance;
        }
    }
}

