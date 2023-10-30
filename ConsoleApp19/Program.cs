namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Contoller controller = new Contoller();
            int userAnswer = 0;
            Library library = new Library();
            Book book = new Book();

            Console.Write("Enter Name : ");
            book.Name = Console.ReadLine();

            Console.Write("Enter Author Name : ");
            book.AuthorName = Console.ReadLine();

            Console.Write("Enter Count : ");
            book.Count = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Page Count : ");
            book.PageCount = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Price : ");
            book.Price = Convert.ToInt32(Console.ReadLine());
            library.AddBook(book);

            book.Sell();
            book.Sell();
            book.Sell();
            book.Sell();

        }
    }
}