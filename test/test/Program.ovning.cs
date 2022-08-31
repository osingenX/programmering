string namn = ""; 
string favoritglass = "";
string favoritfilm = "";
string favoritskor = ""; 

Console.WriteLine("Hej, Vad heter du?"); 
namn = Console.ReadLine();

Console.WriteLine($"Hej {namn}, vad är din favorit glass?:"); 
favoritglass = Console.ReadLine(); 

Console.WriteLine("Du har dålig smak du, vilken film gillar du mest?:");
favoritfilm = Console.ReadLine(); 

Console.WriteLine("Ännu sämre än din favoritglass, har du ett par favorit skor?:");
favoritskor = Console.ReadLine(); 

Console.WriteLine($"Hallå {namn}, hur kan du ens tycka om något av dessa?.");
Console.WriteLine($"Du har så kass smak att alla skrattar åt dig!");

Console.WriteLine("Tryck på ENTER för att avsluta.");
Console.ReadLine();