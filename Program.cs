

/*
using APBD_TASK2.Database;

var db = Singleton.Instance;
*/
using APBD_TASK2.Database;
using APBD_TASK2.Enum;
using APBD_TASK2.Models;
using APBD_TASK2.IRentalServices;

var db = Singleton.Instance;
var service = new RentalService();


db.Users.Add(new User(1, "Adam", "Student", UserType.Student));
db.Users.Add(new User(2, "Ewa", "Pro", UserType.Employee));
db.Equipments.Add(new Laptop(101, "Dell", "i5", 16));
db.Equipments.Add(new Projector(201, "Epson", "4K", 3000));


service.Rent(1, 101);


try { service.Rent(2, 101); } 
catch (Exception e) { Console.WriteLine($"Expected Error: {e.Message}"); }


service.Return(101);


service.ShowReport();
