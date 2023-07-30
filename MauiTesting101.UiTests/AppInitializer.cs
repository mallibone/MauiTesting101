using Xamarin.UITest;

namespace MauiTesting101.UiTests
{
    internal static class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {
            switch (platform)
            {
                case Platform.Android:
                    return ConfigureApp
                        .Android
                        .ApkFile("../../../../MauiTesting101/bin/Debug/net7.0-android/com.companyname.mauitesting101.apk")
                        .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);

                case Platform.iOS:
                    return ConfigureApp
                        .iOS
                        //.InstalledApp("com.companyname.mauiuitestsample")
                        .AppBundle("../../../../MauiTesting101/bin/Debug/net7.0-ios/iossimulator-x64/MauiTesting101.app")
                        .PreferIdeSettings()
                        .StartApp(Xamarin.UITest.Configuration.AppDataMode.Clear);

                default:
                    throw new System.NotSupportedException();
            };
        }
    }
}