// See https://aka.ms/new-console-template for more information
using System.Xml;
using XmlFiles;

XmlDocument xmlDocument = XML_First_Project.Main();
Employee employee = new Employee(xmlDocument);
employee.GetAllEmployees();