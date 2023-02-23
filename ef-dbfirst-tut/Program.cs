using ef_dbfirst_tut;
using ef_dbfirst_tut.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Channels;

var ordlCtrl = new OrdersController();

var ord = await ordlCtrl.GetByIdAsync(1);

Console.WriteLine(ord);


var orderTotal = ord.OrderLines.Sum(x => x.Price * x.Quantity);

Console.WriteLine($"Order total is {orderTotal:C}");

//var ordLine = new OrderLine() {
//    Id = 0 ,
//    OrdersId = 1 ,
//    Product = "GEFORCE 4070",
//    Description = "Herschels 4070ti" ,
//    Quantity = 3 ,
//    Price = 100
//
//};

//await ordCtrl.InsertAsync(ordLine);

//ordLines.ForEach(ord => Console.WriteLine(ord));

//var order = new Order() {
//    Id = 0,
//    Date = new DateTime(2023 , 2 , 23),
//    Description = "New Kroger Order",
//    CustomerId = 1
//};

//bool success = await ordCtrl.DeleteAsync(27);
//Console.WriteLine(success ? "It updated" : "booooooo!!!");



//var custCtrl = new CustomersController();
//
//var success = await custCtrl.DeleteAsync(39);
//
//Console.WriteLine(success ? "OK" : "FAILED");




//var success = await custCtrl.UpdateAsync(bootcamp);

//var bootcamp = await custCtrl.GetByIdAsync(39);
//
//bootcamp.Sales = 5000;


//var cust = new Customer() {
//    Id = 0,
//    Name = "Bootcamp",
//    City = "Mason",
//    State = "OH",
//    Sales = 0,
//    Active = true
//};
//
//var success = await custCtrl.InsertAsync(cust);





//var cust = await custCtrl.GetByIdAsync(1);
//Console.WriteLine(cust.Name);



//foreach(var cust in await custCtrl.GetAllAsync()) {
//    Console.WriteLine(cust.Name);
//
//}



//var dbc = new SalesDbContext();

//var customer = await GetById(1);

//var customers = await GetAll();

//foreach(var cust in customers) {
//    Console.WriteLine(cust.Name);
//} 
//Console.WriteLine(customer.Name);

//async Task<Customer> GetById(int id) {
//        return await dbc!.Customers.FindAsync(id);
//}

 //async Task<List<Customer>> GetAll() {
 //  return await dbc.Customers.ToListAsync();
//}


//var ordersWithCustomers = from o in dbc.Orders
//                          join c in dbc.Customers
//                              on o.CustomerId equals c.Id
//                          orderby c.Name    
//                          select new {
//                                Id = o.Id, Desc = o.Description, Customer = c.Name 
//                              };
//
//foreach(var oc in ordersWithCustomers) {
//    Console.WriteLine($"{oc.Id,2} | {oc.Desc,-30} | {oc.Customer,-30}");
//}

//var orders = from o in dbc.Orders
//             select o;
//
//foreach(var order in orders) {
//    Console.WriteLine(order.Description);
//}
//
//var customers = dbc.Customers
//    .Where(x => x.City == "Cincinnati")
//    .OrderByDescending(x => x.Sales)
//    .ToList();
//
//foreach (var customer in customers) {
//    Console.WriteLine(customer.Name);
//}
