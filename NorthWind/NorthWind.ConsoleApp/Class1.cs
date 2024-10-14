

using NorthWind.ConsoleApp.Services;
using NorthWind.Entities.Interfaces;
using NorthWind.Writers;

IUserActionWriter Writer = new FileWriter();

AppLogger Logger = new AppLogger(Writer);
Logger.WriteLog("Aplication Started");

ProductService Service = new ProductService(Writer);
Service.Add("Demo","Azucar refinada");

/*
 *AppLoger y los Writers: Resposabilidad unica
 *AppLoger: Abierto pero cerrado 
 *AppLoger: Inversione de dependencias. Los modulos
 *de alto nivel son independientes de los detalles de implementacion.
 */