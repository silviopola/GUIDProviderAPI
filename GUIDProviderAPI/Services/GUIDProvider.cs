
namespace GUIDProviderAPI.Services
{
    public class GUIDProvider : IGUIDProvider
    {
        private Guid _guid = Guid.Empty;
            
        public Guid ProvideGUID()
        {
           if (_guid == Guid.Empty)
                _guid = Guid.NewGuid();

           return _guid;
        }
    }
}
