using System.Text;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            string s1 = "Clean Code";
            string s2 = "Clean Code";
            Console.WriteLine(ReferenceEquals(s1, s2));

            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            Console.WriteLine(sb);

            sb.Replace("Book List", "Library");
            Console.WriteLine(sb);

            string bookTitle = "Clean Code";
            int pages = 464;
            string sentence1 = "Book: " + bookTitle + ", Pages: " + pages;
            Console.WriteLine(sentence1);

            string sentence2 = $"Book: {bookTitle}, Pages: {pages}";
            Console.WriteLine(sentence2);

            string sentence3 = string.Format("Book: {0}, Pages: {1}", bookTitle, pages);
            Console.WriteLine(sentence3);

            if (pages > 300)
                Console.WriteLine("Long Book");
            else
                Console.WriteLine("Short Book");

            bool isAvailable = true;
            if (pages > 300 && isAvailable)
                Console.WriteLine("You can borrow this book");

            string t = "Refactoring";
            switch (t)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            Console.WriteLine(sizeLabel);

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }

            int j = 0;
            while (j < books.Length)
            {
                Console.WriteLine(books[j]);
                j++;
            }

            int count = 0;
            do
            {
                Console.WriteLine("Checking book...");
                count++;
            } while (count < 3);

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            foreach (string book in books)
            {
                if (book == "Refactoring")
                    break;
                Console.WriteLine(book);
            }

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                    continue;
                Console.WriteLine(book);
            }

            PrintFirstBook(books);

            static void PrintFirstBook(string[] arr)
            {
                if (arr.Length == 0)
                    return;
                Console.WriteLine(arr[0]);
            }
        }
    }
}
