namespace ExoBibibliothèque;

public class User
{
    public List<Book> BorrowedBooks;

    // Constructor
    public User(int id, string firstName, string lastName, string email)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        BorrowedBooks = new List<Book>();
    }

    // Attributes
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"Id : {Id}, Prénom : {FirstName}, Nom: {LastName}, Nombre de livre emprunté : {BorrowedBooks.Count}";
    }

    // Borrow a book
    public void BorrowBook(Book book)
    {
        if (!book.Available)
        {
            Console.WriteLine($"Le livre n°{book.Id} intitulé {book.Title} n'est pas disponible.");
            return;
        }

        if (BorrowedBooks.Count >= 3)
        {
            Console.WriteLine(
                $"Un utilisateur ne peut pas emprunter plus de 3 livres à la fois (nombre de livre emprunté : {BorrowedBooks.Count}.");
            return;
        }

        book.Available = false;
        BorrowedBooks.Add(book);
        Console.WriteLine(
            $"Le livre n°{book.Id} intitulé {book.Title} est emprunté par l'utilisateur {LastName} {FirstName} n°{Id}.");
    }

    // Return a book
    public void ReturnBook(Book book, Library library)
    {
        if (BorrowedBooks.Contains(book))
        {
            BorrowedBooks.Remove(book);
            book.Available = true;
            Console.WriteLine(
                $"Le livre n°{book.Id} intitulé {book.Title} est de nouveau disponible dans la bilbliothèque {library.Name}.");
        }
    }
}