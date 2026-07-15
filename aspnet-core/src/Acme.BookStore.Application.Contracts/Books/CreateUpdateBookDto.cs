using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.BookStore.Books; 

public class CreateUpdateBookDto
{
    public string Name { get; set; } = string.Empty;
    public BookType Type { get; set; } = BookType.Undefined;

    public DateTime PublishDate { get; set; } = DateTime.Now;
    public float Price { get; set; }
}
