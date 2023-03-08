using Firebase.Auth;
using Firebase.Storage;
using Microsoft.EntityFrameworkCore.Internal;
using Restaurant.BLL.Repository;
using Restaurant.DAL.Repository;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Restaurant.BLL.Implementation
{
    public class FirebaseStorageService : IImageStorageService
    {
        private readonly IGenericRepository<Setting> _repository;

        public FirebaseStorageService(IGenericRepository<Setting> repository)
        {
            _repository = repository;
        }
        public async Task<string> Upload(Stream image, string folder, string fileName)
        {
            string url = "";
            try
            {
                IQueryable<Setting> query = _repository.Consult(q => q.Resource == "Firebase_Store");
                Dictionary<string, string> config = query.ToDictionary(keySelector: k => k.Property, elementSelector: e => e.Value);

                var auth = new FirebaseAuthProvider(new FirebaseConfig(config["api_key"]));
                var sesion = await auth.SignInWithEmailAndPasswordAsync(config["email"], config["password"]);
                var cancelation = new CancellationTokenSource();
                var storage = new FirebaseStorage(config["route"], new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(sesion.FirebaseToken),
                    ThrowOnCancel = true,
                })
                .Child(config[folder])
                .Child(fileName)
                .PutAsync(image, cancelation.Token);

                url = await storage;
            }
            catch (Exception)
            {
                url = "";
            }

            return url;
        }
        public async Task<bool> Remove(string folder, string fileName)
        {
            try
            {
                IQueryable<Setting> query = _repository.Consult(q => q.Resource =="Firebase_Storage");
                Dictionary<string, string> config = query.ToDictionary(keySelector: k => k.Property, elementSelector: e => e.Value);

                var auth = new FirebaseAuthProvider(new FirebaseConfig(config["api_key"]));
                var sesion = await auth.SignInWithEmailAndPasswordAsync(config["email"], config["password"]);
                var storage = new FirebaseStorage(config["route"], new FirebaseStorageOptions
                {
                    AuthTokenAsyncFactory = () => Task.FromResult(sesion.FirebaseToken),
                    ThrowOnCancel = true
                })
                .Child(config[folder])
                .Child(fileName)
                .DeleteAsync();

                await storage;

                return true;
            }
            catch (Exception)
            {

               return false;
            }
        }

        
    }
}
