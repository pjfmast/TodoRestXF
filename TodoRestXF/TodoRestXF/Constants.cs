using Xamarin.Essentials;

namespace TodoRestXF
{
    public static class Constants
    {
        // URL of REST service
        //public static string RestUrl = "https://YOURPROJECT.azurewebsites.net:8081/api/todoitems/{0}";

        // URL of REST service (Android does not use localhost)
        // Use http cleartext for local deployment. Change to https for production

        // The ports are defined in TodoApi under Properties/launchSettings.json
        public static string RestUrl 
            = DeviceInfo.Platform == DevicePlatform.Android 
            ? "http://10.0.2.2:5159/api/todoitems/{0}"
            : "http://localhost:5159/api/todoitems/{0}";
    }
}
