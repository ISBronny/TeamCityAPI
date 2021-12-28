using TeamCityAPI.Serializer;

namespace TeamCityAPI
{
    public abstract class Locator
    {
        public override string ToString()
        {
            return LocatorSerializer.Serialize(this);
        }
    }
}