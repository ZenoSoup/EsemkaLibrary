using System;
using System.Collections.Generic;

namespace EsemkaLibrary.Model;

public partial class Book
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Author { get; set; } = null!;

    public DateOnly? PublishDate { get; set; }

    public int Stock { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual ICollection<BookGenre> BookGenres { get; set; } = new List<BookGenre>();

    public virtual ICollection<Borrowing> Borrowings { get; set; } = new List<Borrowing>();
}
