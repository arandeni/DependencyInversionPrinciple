﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using DependencyInversionPrinciple;

EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
Employee emp = employeeBusinessLogic.GetEmployeeDetails(1001);
Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
Console.ReadKey();
