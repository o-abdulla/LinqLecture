
List<int> ages = new List<int> { 23, 21, 19, 30, 25 };

// Count method
// Return how many match the condition
int adultCount = ages.Count(p => p >= 21);  // assigns variable (p) like in a foreach loop => splits it up
Console.WriteLine($"There are {adultCount} adults");

//int counter = 0;              <--- long version to above ^
//foreach (int p in ages)
//{
//    if (p >= 21)
//    {
//        counter++;
//    }
//}
//return counter;

// Any method
// return a true or false if any elements match
bool childCheck = ages.Any(p => p < 21);
Console.WriteLine($"Is there a child here? {childCheck}");

// write a senior check to see if anyone is 65 or older
bool seniorCheck = ages.Any(p => p >= 65);
Console.WriteLine($"Is there a senior here? {seniorCheck}");


// All method
bool allAdult = ages.All(p => p >= 18);
Console.WriteLine($"Is everyone 18 or older? {allAdult}");

// create allCanDrink. Check if all ages are 21 or older
bool allCanDrink = ages.All(p => p >= 21);
Console.WriteLine($"Can everyone drink? {allCanDrink}");


// Where method       ***** VERY POWERFUL TOOL *****
// Create a new collection based on condition
// filtering
List<double> clothes = new List<double>()
{
    40.00,
    50.00,
    200.99,
    500.00,
    10.00,
    100.02
};

// returns IEnumerable. .ToList() converts it to a list
List<double> expensive = clothes.Where(c => c >= 100).ToList();
foreach (double e in expensive)
{
    Console.WriteLine(e);
}

// Create a new list. Use Where to filter it where the value equals 100
// display it (NOTE: You won't get any back)
List<double> hundred = clothes.Where(c => c == 100).ToList();     // foreach loop wont work because theres nothing equal to 100
foreach (double h in hundred)
{
    Console.WriteLine(h);
}