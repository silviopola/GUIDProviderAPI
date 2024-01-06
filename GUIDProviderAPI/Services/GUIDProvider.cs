
namespace GUIDProviderAPI.Services
{
    public class GUIDProvider : IGUIDProvider
    {
        private Guid _guid = Guid.Empty;

        // Performing a Lazy initialization so a unique guid for any class instance
        public Guid ProvideGUID()
        {
           if (_guid == Guid.Empty)
                _guid = Guid.NewGuid();

           return _guid;
        }
    }
}
