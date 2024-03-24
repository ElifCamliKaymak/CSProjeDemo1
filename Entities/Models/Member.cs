using CSDemoProject1.Abstracts;
using CSDemoProject1.Models;
using System.ComponentModel.DataAnnotations;

namespace CSDemoProject1.Repos
{
    public class Member : IMember
    {
        public Member()
        {
            Books = new List<Book>();
        }


        [Key]
        public int MemberNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{FirstName} {Surname}";
        public List<Book> Books {  get; set; } 

        public void Borrow(Book book)
        {
            Books.Add(book);
        }

        public void Deliver(Book book)
        {
            Books.Remove(book);
        }
    }
}
