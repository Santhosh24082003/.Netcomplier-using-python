
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = GenerateNumbers(100);
            var squaredNumbers = SquareNumbers(numbers);
            var sumOfSquares = squaredNumbers.Sum();
            var evenNumbers = GetEvenNumbers(numbers);

            Console.WriteLine("Numbers: " + string.Join(", ", numbers));
            Console.WriteLine("Squared Numbers: " + string.Join(", ", squaredNumbers));
            Console.WriteLine("Sum of Squares: " + sumOfSquares);
            Console.WriteLine("Even Numbers: " + string.Join(", ", evenNumbers));

            // Example of sorting and filtering
            var sortedNumbers = numbers.OrderBy(n => n).ToList();
            Console.WriteLine("Sorted Numbers: " + string.Join(", ", sortedNumbers));

            var filteredNumbers = numbers.Where(n => n > 50).ToList();
            Console.WriteLine("Filtered Numbers (greater than 50): " + string.Join(", ", filteredNumbers));

            // Example of complex data manipulation
            var combinedData = CombineData(numbers, squaredNumbers);
            Console.WriteLine("Combined Data (Number and Square):");
            foreach (var item in combinedData)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }

            // Process the data using more methods
            ProcessData(combinedData);

            // More complex logic with strings
            var sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine("Original Sentence: " + sentence);
            var reversedSentence = ReverseString(sentence);
            Console.WriteLine("Reversed Sentence: " + reversedSentence);

            // Example of working with objects and classes
            var students = CreateStudents();
            Console.WriteLine("Students and their scores:");
            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} scored {student.Score}");
            }
        }

        public static List<int> GenerateNumbers(int count)
        {
            var random = new Random();
            var numbers = new List<int>();
            for (int i = 0; i < count; i++)
            {
                numbers.Add(random.Next(1, 101));
            }
            return numbers;
        }

        public static List<int> SquareNumbers(List<int> numbers)
        {
            return numbers.Select(n => n * n).ToList();
        }

        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            return numbers.Where(n => n % 2 == 0).ToList();
        }

        public static List<(int Number, int Square)> CombineData(List<int> numbers, List<int> squares)
        {
            var combined = new List<(int, int)>();
            for (int i = 0; i < numbers.Count; i++)
            {
                combined.Add((numbers[i], squares[i]));
            }
            return combined;
        }

        public static void ProcessData(List<(int Number, int Square)> data)
        {
            Console.WriteLine("Processing Data...");
            foreach (var item in data)
            {
                Console.WriteLine($"Processing: Number = {item.Number}, Square = {item.Square}");
            }
        }

        public static string ReverseString(string input)
        {
            var chars = input.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        public static List<Student> CreateStudents()
        {
            return new List<Student>
            {
                new Student { Name = "Alice", Score = 95 },
                new Student { Name = "Bob", Score = 85 },
                new Student { Name = "Charlie", Score = 78 },
                new Student { Name = "Diana", Score = 92 }
            };
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public int Score { get; set; }
    }
    