using ef_dbfirst_tut;
using ef_dbfirst_tut.Models;
using Microsoft.EntityFrameworkCore;


var custCtrl = new CustomersController();

var success = await custCtrl.DeleteAsync(39);

Console.WriteLine(success ? "OK" : "FAILED");




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
