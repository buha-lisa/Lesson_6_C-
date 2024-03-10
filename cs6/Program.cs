﻿namespace cs6
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
                    { 
                        Matrix matrix1 = new Matrix(5, 5);
                        Matrix matrix2 = new Matrix(5, 5);

                        Matrix matrix3 = matrix1 + matrix2;
                            for (int i = 0; i < matrix3.Rows; i++)
                            {
                                for (int j = 0; j < matrix3.Cols; j++)
                                {
                                    Console.Write(matrix3.Data[i, j] + " ");
                                }
                                Console.Write("\n");
                            }

                        break;
                    }
                }
                if (task == 0) break;
            }
        }
    }
}
