string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] orderIDs = orderStream.Split(",");
Array.Sort(orderIDs);

foreach(var order in orderIDs){  
    Console.WriteLine(order.Length != 4 ? $@"{order}    - Error": order);
}