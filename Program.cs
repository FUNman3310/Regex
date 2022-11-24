using UserClassLibrary;
using System.Text.RegularExpressions;

string RandomText = "Kono Giorno Giovanna niwa yume ga aru";
bool Check;

User user = new User();

Console.ReadLine();


Check=user.HasDigit(RandomText);
Console.WriteLine(Check);
Check=user.HasLower(RandomText);
Console.WriteLine(Check);
Check=user.HasUpper(RandomText);
Console.WriteLine(Check);

Console.ReadLine();