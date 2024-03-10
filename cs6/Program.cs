namespace cs6
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-4): ");
                int.TryParse(Console.ReadLine(), out int task);
                switch (task)
                {
                    case 1:
                        {
                            Employee employee = new Employee()
                            {
                                PIP = "PIP",
                                Phone = "1234",
                                Salary = 123
                            };

                            Employee employee2 = employee - 23;
                            Console.WriteLine($"{employee2.PIP} - {employee2.Phone} - {employee2.Salary}");

                            Employee employee3 = new Employee()
                            {
                                PIP = "PIP",
                                Phone = "1234",
                                Salary = 123
                            };
                            if (employee == employee3)
                            {
                                Console.WriteLine("==");
                            }
                            if (employee != employee3)
                            {
                                Console.WriteLine("!=");
                            }
                            if (employee > employee3)
                            {
                                Console.WriteLine(">");
                            }
                            if (employee < employee3)
                            {
                                Console.WriteLine("<");
                            }
                            if (employee.Equals(employee3))
                            {
                                Console.WriteLine("==");
                            }
                            break;
                        }
                    case 2: 
                        Matrix matrix1 = new Matrix(5, 5);
                        for (int i = 0; i < matrix1.Rows; i++)
                        {
                            for (int j = 0; j < matrix1.Cols; j++)
                            {
                                matrix1.Data[i, j] = i + 6 + j;
                            }
                        }
                        Matrix matrix2 = new Matrix(5, 5);
                        for (int i = 0; i < matrix2.Rows; i++)
                        {
                            for (int j = 0; j < matrix2.Cols; j++)
                            {
                                matrix2.Data[i, j] = i + 9 + j;
                            }
                        }

                        Matrix matrix3 = matrix1 + matrix2;
                        for (int i = 0; i < matrix3.Rows; i++)
                        {
                            for (int j = 0; j < matrix3.Cols; j++)
                            {
                                Console.Write(matrix3.Data[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        Console.WriteLine("\n\n");
                        Matrix matrix4 = matrix1 * 9;
                        for (int i = 0; i < matrix4.Rows; i++)
                        {
                            for (int j = 0; j < matrix4.Cols; j++)
                            {
                                Console.Write(matrix4.Data[i, j] + " ");
                            }
                            Console.Write("\n");
                        }
                        break;
                    case 3:
                        City city1 = new City
                        {
                            Name = "London", 
                            Country = "UK",
                            Population = 8908081
                        };
                        City city2 = city1 + 944;
                        Console.WriteLine($"{city2.Name} - {city2.Country} - {city2.Population}");
                        City city3 = new City()
                        { 
                            Name = "New York",
                            Country = "USA",
                            Population = 18908081
                        };
                        if (city1 == city3)
                        {
                            Console.WriteLine("==");
                        }
                        if (city1 != city3)
                        {
                            Console.WriteLine("!=");
                        }
                        if (city1 > city3)
                        {
                            Console.WriteLine(">");
                        }
                        if (city1 < city3)
                        {
                            Console.WriteLine("<");
                        }
                        if (city1.Equals(city3))
                        {
                            Console.WriteLine("==");
                        }

                        break;
                    case 4:
                        CreditCard card1 = new CreditCard
                        {
                            CVC = 423,
                            PineCode = 8697,
                            Money = 123
                        };
                        CreditCard card2 = card1 + 944;
                        Console.WriteLine($"{card2.CVC} - {card2.PineCode} - {card2.Money}");
                        CreditCard card3 = new CreditCard()
                        {
                            CVC = 424,
                            PineCode = 8697,
                            Money = 1234
                        };
                        if (card1 == card3)
                        {
                            Console.WriteLine("==");
                        }
                        if (card1 != card3)
                        {
                            Console.WriteLine("!=");
                        }
                        if (card1 > card3)
                        {
                            Console.WriteLine(">");
                        }
                        if (card1 < card3)
                        {
                            Console.WriteLine("<");
                        }
                        if (card1.Equals(card3))
                        {
                            Console.WriteLine("==");
                        }

                        break;
                }
                if (task == 0) break;
            }
        }
    }
}
