namespace cs6
{
    internal class Employee
    {
        public string PIP { get; set; }
        public Data? BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Post { get; set; }
        public string Responsib { get; set; }

        public decimal Salary { get; set; }

        public static Employee operator +(Employee employee, decimal increment)
        {
            return new Employee { Salary = employee.Salary + increment };
        }
        public static Employee operator -(Employee employee, decimal increment)
        {
            return new Employee { Salary = employee.Salary - increment };
        }

        public static bool operator ==(Employee left, Employee right)
        {
            return left.Salary == right.Salary;
        }
        public static bool operator !=(Employee left, Employee right)
        {
            return left.Salary != right.Salary;
        }

        public static bool operator >(Employee left, Employee right)
        {
            return left.Salary > right.Salary;
        }
        public static bool operator <(Employee left, Employee right)
        {
            return left.Salary < right.Salary;
        }

        public override bool Equals(object obj)
        {
            if (obj is Employee)
            {
                Employee other = (Employee)obj;
                return this.Salary == other.Salary;
            }
            return false;
        }



        //public Employee(string pip,
        //Data data,
        //string phone,
        //string email, string post,
        //string respon)
        //{
        //    PIP = pip;
        //    BirthDay = data;
        //    Phone = phone;
        //    Email = email;
        //    Post = post;
        //    Responsib = respon;
        //}
        //public void ShowInfo(Data data)
        //{
        //    Console.WriteLine($"PIP:\t{PIP}");
        //    data.ShowData();
        //    Console.WriteLine($"Phone:\t{Phone}");
        //    Console.WriteLine($"Email:\t{Email}");
        //    Console.WriteLine($"Post:\t{Post}");
        //    Console.WriteLine($"Responsibilities:\n{Responsib}");
        //}
    }

    struct Data
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }
        public Data(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
        public void ShowData()
        {
            Console.WriteLine($"Birthday: {Day}.{Month}.{Year}");
        }
    }
}
