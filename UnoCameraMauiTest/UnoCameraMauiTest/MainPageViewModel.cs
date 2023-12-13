using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Messaging;
using Microsoft.Maui.ApplicationModel;
using Newtonsoft.Json.Linq;
using UnoCameraMauiTest.MauiControls;
using Windows.UI.Core;

namespace UnoCameraMauiTest;
public partial class MainPageViewModel : ObservableRecipient
{
    private string _parameter = string.Empty;

    public string Parameter
    {
        get => _parameter;
        set => SetProperty(ref _parameter, value);
    }

    public MainPageViewModel()
    {
        // Register a message in some module
        Messenger.Register<MainPageViewModel, QRCodeScannedMessage>(this, async (viewmodel, message) =>
        {
            // on Android the UI update must be set on UI Thread, else =>
            // Android.Util.AndroidRuntimeException: Only the original thread that created a view hierarchy can touch its views
            await App.MainWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                viewmodel.Parameter = message.Value;
            });
            
        });
    }
}

