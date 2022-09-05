using System;

namespace SKYNET.Helpers
{
    public class Settings
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string Host { get; set; }
        public static bool AutoConnect { get; set; }
        public static bool AutoRelease { get; set; }
        


        private static RegistrySettings Registry;

        static Settings()
        {
            Registry = new RegistrySettings(@"SOFTWARE\SKYNET\[SKYNET] MK Releaser\");
        }

        public static void Load()
        {
            Username = Registry.Get<string>("Username", "admin");
            Password = Registry.Get<string>("Password", "");
            Host = Registry.Get<string>("Host", "192.168.88.1");
            AutoConnect = Registry.Get<bool>("AutoConnect", false);
            AutoRelease = Registry.Get<bool>("AutoRelease", false);
        }

        public static void Save()
        {
            Registry.Set("Username", Username);
            Registry.Set("Password", Password);
            Registry.Set("Host", Host);
            Registry.Set("AutoConnect", AutoConnect);
            Registry.Set("AutoRelease", AutoRelease);
            
        }
    }
}

