using System.Text.RegularExpressions;

namespace UserClassLibrary
{
    public class User
    {
        private string _userName { get; set; }
        private string _password { get; set; }

        public User()
        {
            bool Check;
            string Pass;
            string Name;

            do
            {
                Console.Write("\nEnter UserName: ");
                Name = Console.ReadLine();
            } while (Name.Length < 6 || Name.Length > 25);

            do
            {
                Console.Write("\nEnter Password: ");
                Pass = Console.ReadLine();
                Regex num = new Regex(@"[0-9]+");
                Regex up = new Regex(@"[A-Z]+");
                Regex low = new Regex(@"[a-z]+");

                Check = num.IsMatch(Pass) && up.IsMatch(Pass) && low.IsMatch(Pass);
            } while (Pass.Length < 8 || Pass.Length > 25||!Check );
            
            this._userName = Name;
            this._password = Pass;

            Console.WriteLine("\nUserName created: " + _userName);
            Console.WriteLine("Password created: " + _password);
        }

        public bool HasDigit(string Value)
        {
            Regex rg = new Regex(@"[0-9]+");
            bool Check = rg.IsMatch(Value);
            return Check;
        }
        public bool HasUpper(string Value)
        {
            Regex rg = new Regex(@"[A-Z]+");
            bool Check = rg.IsMatch(Value);
            return Check;
        }
        public bool HasLower(string Value)
        {
            Regex rg = new Regex(@"[a-z]+");
            bool Check = rg.IsMatch(Value);
            return Check;
        }

    }
}