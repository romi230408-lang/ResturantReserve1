using ResturantReserve.ModelsLogic;

namespace ResturantReserve.Models
{
    internal abstract class UserModel
    {
        protected FbData fbd = new();
        public EventHandler<bool>? OnAuthComplete;
        public bool IsRegistered => !string.IsNullOrWhiteSpace(Name);
        public bool IsBusy { get; protected set; } = false;
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public abstract void Register();
        public abstract void Login();
        public abstract bool IsValid();
    }
}
