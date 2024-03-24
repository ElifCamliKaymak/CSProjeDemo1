using CSDemoProject1.Models;
using System.ComponentModel.DataAnnotations;

namespace CSDemoProject1.Abstracts
{
    public interface IMember
    {
        [Key]
        public int MemberNo { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string FullName => $"{FirstName} {Surname}";

        public void Borrow(Book book);
        public void Deliver(Book book);
        
    }
}
