using System;
using System.Collections.Generic;

namespace EsemkaLibrary.Model;

public partial class Borrowing
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int BookId { get; set; }

    public DateTime BorrowDate { get; set; }

    public DateTime? ReturnDate { get; set; }

    public decimal? Fine { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Book Book { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
