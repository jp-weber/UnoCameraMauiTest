using ZXing.Net.Maui.Controls;

namespace UnoCameraMauiTest;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseMauiControls(this MauiAppBuilder builder) =>
        builder
            .UseBarcodeReader() // Make sure to add this line
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("UnoCameraMauiTest/Assets/Fonts/OpenSansRegular.ttf", "OpenSansRegular");
                fonts.AddFont("UnoCameraMauiTest/Assets/Fonts/OpenSansSemibold.ttf", "OpenSansSemibold");
            });
}
