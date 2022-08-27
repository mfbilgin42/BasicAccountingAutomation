using Autofac.Extensions.DependencyInjection;
using Autofac;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace FormUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            Application.Run(ServiceProvider.GetRequiredService<Form_Login>());

        }
        public static IServiceProvider ServiceProvider { get; private set; }
        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddTransient<IUserService, UserManager>();
                    services.AddTransient<IAuthService, AuthManager>();
                    services.AddTransient<IUserDal, EfUserDal>();

                    services.AddTransient<Form_Login>();
                });
        }

    }

}