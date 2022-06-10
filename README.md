# TodoRestXF
From the tutorial: https://docs.microsoft.com/en-us/xamarin/xamarin-forms/data-cloud/web-services/rest

## Solution TodoRestXF
This solution includes two projects:
- https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-6.0&tabs=visual-studio
- https://docs.microsoft.com/en-us/xamarin/xamarin-forms/data-cloud/web-services/rest

- In Solution Property multiple startup is selected so that the TodoApi is started together with the Xamarin app for Android and UWP

## Some notes
- In project TodoAPI/Properties/launchSettings contains the TodoAPI profile with the applicationUrl
- In the TodoRestXF (Xamarin Formas app) the first one is used: http://localhost:5159
- For testing as UWP app 
  in Package.appxmanifest, Capabilities:
  - check: Internet (Client & Server)
  - check: Private Networks (Client & Server)
  - check: Shared User Certificates 

- For Android:
   - In AndroidManifest this is added for http connection: android:usesCleartextTraffic="true"
   - Testing from Android emulator requires using http://10.0.2.2:{port}: 
         public static string RestUrl 
            = DeviceInfo.Platform == DevicePlatform.Android 
            ? "http://10.0.2.2:5159/api/todoitems/{0}"
            : "http://localhost:5159/api/todoitems/{0}";
