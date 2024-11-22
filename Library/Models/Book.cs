namespace ExoBibibliothèque;

public class Book
{
    // Constructor
    public Book(int id, string title, string author, bool available)
    {
        Id = id;
        Title = title;
        Author = author;
        Available = available;
    }

    // Atttributes
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public bool Available { get; set; }


    // Show book attributes
    public override string ToString()
    {
        return $"Id : {Id}, Titre: {Title}, Auteur: {Author}, Disponible: {(Available ? "Oui" : "Non")}";
    }
}