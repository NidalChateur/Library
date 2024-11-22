namespace ExoBibibliothèque;

public class Library
{
    //Atributes
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Book> Books;  
    
    //Constructor
    public Library(int id, string name)
    {
        Id = id;
        Name = name;
        Books = new List<Book>();
    }
    
    
    // Show book attributes
    public override string ToString()
    {
        int totalBooks=Books.Count;
        int availableBooks=Books.Count(book => book.Available );
        int unavailableBooks=Books.Count(book => !book.Available);
        
        return $"\nId : {Id}, Nom de la bibliothèque : {Name}, Nombre total de livres : {totalBooks}\n- Livres disponibles : {availableBooks}\n- Livre indisponibles : {unavailableBooks}";
    }

    // Add a book to the library (BookList)
    public void AddBook(Book book)
    {
        Books.Add(book);
        Console.WriteLine(
            $"Le livre s'intitulant {book.Title} écrit par {book.Author} a été ajouté à la bibliothèque {Name}.");
    }

    // List All books
    public void ListAllBooks()
    {
        Console.WriteLine($"\nVoici la liste des livres présent dans la bibiliothèque {Name} :");
        foreach (var book in Books) Console.WriteLine($"\n- {book}");
    }

    // Search a book by title
    public Book? GetBookByTitle(string title)
    {
        foreach (var book in Books)
            if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                return book;
        return null;
    }
}