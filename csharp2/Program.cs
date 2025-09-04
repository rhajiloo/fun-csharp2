namespace dotnetFundamental
{
    internal class Program
    {
        
        public static bool IsValidMobile(string phoneNumber)
        {
            if (phoneNumber == null) return false;
            if (phoneNumber.Length != 11) return false;
            else return true;
        }

        public static string ShowFullName(string name, string family , string phone)
        {
            string fullName = name + " " + family + " " + phone;
            Console.WriteLine(fullName);
            return fullName;
        }


        public static void ShowNameFamily(string name, string family)
        { Console.WriteLine("welcome " + name + " " + family); }



        static void Main(string[] args)
        {
            string phoneNumber = string.Empty;
            for (; ; )
            {
                try
                {
                    Console.WriteLine("please enter phone number?");
                    phoneNumber = Console.ReadLine() ?? throw new Exception("Invalid phone number!!!"); //اگر نال بود پیام دهد
                    if (IsValidMobile(phoneNumber))
                    {
                    break;
                    }
                  

                }
                catch (Exception ex)
                {
                    Console.WriteLine("invalid!");
                    continue;
                }

            }


            string firstName = string.Empty;
            while (true)
            {
                Console.WriteLine("firstname?");
                firstName = Console.ReadLine() ?? string.Empty; //اگر خالی رد کرد و اطلاعاتی وارد نکرد یعنی نالیبل شد آنگاه مقدار آنرا یک رشته خالی بگذار
                if (!string.IsNullOrEmpty(firstName) && firstName.Length > 2)
                    break;
                else
                    Console.WriteLine("invalid!");
            }

            string lastName = string.Empty;
            while (true)
            {
                Console.WriteLine("lastName?");
                lastName = Console.ReadLine() ?? string.Empty; //اگر خالی رد کرد و اطلاعاتی وارد نکرد یعنی نالیبل شد آنگاه مقدار آنرا یک رشته خالی بگذار
                if (!string.IsNullOrEmpty(lastName) && lastName.Length > 2)
                    break;
                else
                    Console.WriteLine("invalid!");
            }


            ShowNameFamily(firstName, lastName);
            ShowFullName(firstName ,lastName , phoneNumber);


        }
    }
}