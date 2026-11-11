using System.ComponentModel.DataAnnotations;

namespace library.Models;

// One Book object holds one row of lending.book.
public class Book
{
    public long BookId { get; set; }               // book_id   BIGINT, the primary key

    // 1. Rule: a title of at most 150 characters.
    public string Title { get; set; } = "";        // title     VARCHAR(150) NOT NULL

    public string? Category { get; set; }          // category  VARCHAR(40), may be NULL

    // 2. Rule: a price from 0.01 to 99,999.99, when one is given.
    public decimal? Price { get; set; }            // price     NUMERIC(7,2), may be NULL, above 0
}
