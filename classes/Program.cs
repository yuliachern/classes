// See https://aka.ms/new-console-template for more information
using classes;

Person person; // null by default
Person baby = new Person();
baby.LastName = "Thompson";
baby.FirstName = "Theresa";
baby.DateOfBirth = new DateOnly(2023, 10, 29);


baby.PrintFullName();
baby.PrintInitials();
baby.GenerateTaxNumber();
baby.GetTaxNumber();

var taxNumber = baby.GetTaxNumber();
Console.WriteLine(taxNumber);   



