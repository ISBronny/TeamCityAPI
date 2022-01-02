using TeamCityAPI.Locators.Serializer;

namespace TeamCityAPI.Locators.Common
{
    public abstract class Locator
    {
        public override string ToString()
        {
            return LocatorSerializer.Serialize(this);
        }
    }
}