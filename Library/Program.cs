// See https://aka.ms/new-console-template for more information
using System;
using ExoBibibliothèque;

class Program
{
    static void Main(string[] args)
    {
        // 1. creating books instance
        Book book1 = new Book("Le Petit Prince", "Antoine de Saint-Exupery", true);
        Book book2 = new Book("1984", "Georges Orwell", false);
        Book book3 = new Book("Vingt mille lieues sous les mers", "Jules Verne", true);
        
        // 2. creating library instance
        Library library = new Library();
        Console.WriteLine(library.ToString());
        
        // 2. Adding book instance
        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);
        
        
        //3. listing all books
        Console.WriteLine(library.ToString());
        library.ListAllBooks();
        
        // 4. Searching a book by title
        Console.WriteLine("\nSouhaitez vous rechercher un livre par titre? (y/n)");
        string userResponse = Console.ReadLine();
        if (userResponse.ToLower() == "y")
        {
            Console.WriteLine("\nPour rechercher un livre, entrez son titre :");
            string searchedTitle = Console.ReadLine();
            Book searchedBook= library.GetBookByTitle(searchedTitle);
            if (searchedBook != null)
            {
                Console.WriteLine("\nUn résultat trouvé :");
                Console.WriteLine(searchedBook.ToString());
            }
            else
            {
                Console.WriteLine("\nAucun résultat trouvé.");
            }
        }
    }
}