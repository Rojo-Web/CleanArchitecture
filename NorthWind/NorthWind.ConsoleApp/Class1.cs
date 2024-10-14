
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

HostApplicationBuilder Builder = Host.CreateApplicationBuilder();

Builder.Services.AddNorthWindServices();
using IHost AppHost = Builder.Build();

IAppLogger Logger = AppHost.Services.GetRequiredService<IAppLogger>();
Logger.WriteLog("Application started");

IProductService Service = AppHost.Services.GetRequiredService<IProductService>();
Service.Add("Demo", "Azucar refinada");



/*
 *AppLoger y los Writers: Resposabilidad unica
 *AppLoger: Abierto pero cerrado 
 *AppLoger: Inversione de dependencias. Los modulos
 *de alto nivel son independientes de los detalles de implementacion.
 */