using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Openfin.Desktop;

namespace WinformsApp
{
    class OpenFinIntegration
    {
        private const string DotNetUuid = "8651D4BB-5B58-4AE6-9984-3E6DB1641E7D";
        private const string ProcessOrderTopic = "1E133889-CCBA-49A8-8898-4E3333526966";

        private const string WebAppManifest = "http://localhost:56100/manifest/webApp.json";      

        private RuntimeOptions _webAppOptions;
        private RuntimeOptions _dotNetOptions;

        private Runtime _runtime;
        private Application _openfinApp;

        public OpenFinIntegration()
        {
            _webAppOptions = RuntimeOptions.LoadManifest(new Uri(WebAppManifest));
            _dotNetOptions = new RuntimeOptions()
            {
                UUID = DotNetUuid,
                Version = _webAppOptions.Version,
                RemoteDevToolsPort = _webAppOptions.RemoteDevToolsPort
            };

            _dotNetOptions.UUID = DotNetUuid;

            _runtime = Runtime.GetRuntimeInstance(_dotNetOptions);
            _openfinApp = _runtime.WrapApplication(_webAppOptions.StartupApplicationOptions.UUID);

            _runtime.Disconnected += Runtime_Disconnected;
            _openfinApp.Closed += DeepThoughtApp_Closed;
        }

        public event EventHandler<ProcessOrderEventArgs> OrderReceived;
        public event EventHandler RuntimeConnected;
        public event EventHandler RuntimeDisconnected;
        public event EventHandler AppConnected;
        public event EventHandler AppDisconnected;

        public void LaunchOpenFinApp()
        {
            // Launch and Connect to the OpenFin Runtime
            // If already connected, callback executes immediately
            _runtime.Connect(() =>
            {
                Console.WriteLine("Runtime object connected!");
                RuntimeConnected?.Invoke(this, EventArgs.Empty);
                
                _openfinApp.isRunning(ack => 
                {
                    var isRunning = ack.getJsonObject().Value<bool>("data");

                    if(!isRunning)
                    {
                        _runtime.CreateApplication(_webAppOptions.StartupApplicationOptions);
                        InterApplicationBus.Subscription<Order>(_openfinApp, ProcessOrderTopic).MessageReceived += ProcessOrder_MessageReceived;
                    }

                    // Run the OpenFin App
                    // If already running, the callback executes immediately
                    _openfinApp.Run(() =>
                    {
                        Console.WriteLine("The application is now running!");
                        AppConnected?.Invoke(this, EventArgs.Empty);
                    });
                });
            });
        }

        private void Runtime_Disconnected(object sender, EventArgs e)
        {
            RuntimeDisconnected?.Invoke(this, EventArgs.Empty);
        }

        private void DeepThoughtApp_Closed(object sender, ApplicationEventArgs e)
        {
            AppDisconnected?.Invoke(this, EventArgs.Empty);
        }

        private void ProcessOrder_MessageReceived(object sender, Openfin.Desktop.Messaging.MessageBusMessageEventArgs<Order> e)
        {
            OrderReceived?.Invoke(this, new ProcessOrderEventArgs(e.Message));
        }
    }
}
