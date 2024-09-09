
double sandwich = 0.00; 
double toppings = 0.00;
double tip = 0.00;

double totalsandwichcost = 0.00; 
double totaltoppingscost = 0.00;
double basecost = 0.00;
double ordercost = 0.00; 
double discount = 0.00; 

System.Console.WriteLine("How many sandwichs would you like?");
sandwich = double.Parse(Console.ReadLine());

System.Console.WriteLine("How many toppings would you like?");
toppings = double.Parse(Console.ReadLine());

System.Console.WriteLine("How much would you like to tip?");
tip = double.Parse(Console.ReadLine());

totalsandwichcost = 4.75 * sandwich;
totaltoppingscost = .55 * toppings;
basecost = totalsandwichcost + totaltoppingscost;

discount = basecost * .1; 
ordercost = tip + basecost - discount ;


System.Console.WriteLine("Your total is: " + ordercost);