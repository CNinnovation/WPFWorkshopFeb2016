using Microsoft.Extensions.DependencyInjection;
using MVVMSample.LocalServices;
using MVVMSampleLib.Contracts;
using MVVMSampleLib.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MVVMSample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Container = RegisterServices();
        }

        private IServiceProvider RegisterServices()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IMessageContract, MyMessageService>();
            serviceCollection.AddTransient<MainViewModel>();


            return serviceCollection.BuildServiceProvider();
        }

        public IServiceProvider Container { get; private set; }
    }
}
