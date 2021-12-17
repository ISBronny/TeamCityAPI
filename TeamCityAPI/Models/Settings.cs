namespace TeamCityAPI
{
    internal class Settings
    {
        public string Server { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }
        public bool? UseSsl { get; set; }
    }
}