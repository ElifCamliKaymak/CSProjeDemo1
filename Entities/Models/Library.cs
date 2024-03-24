using CSDemoProject1.Models;

namespace CSDemoProject1.Repos
{
    public class Library
    {
        public List<Member> Members { get; set; }
        public List<Book> Books { get; set; }

        public string LendingBook(int memberNo, string isbn)
        {
            Member member = new Member();

            foreach (Member item in Members)
            {
                if (item.MemberNo == memberNo)
                {
                    member = item;
                }
            }

            foreach (Book item in Books)
            {
                if (item.ISBN == isbn)
                {
                    if (item.Status == Enums.Status.Available)
                    {
                        member.Books.Add(item);
                        item.Status = Enums.Status.InUse;
                        return "Kitap ödünç verildi.";
                    }
                    else if (item.Status == Enums.Status.InUse)
                    {
                        return "Kitap müsait değil.";
                    }
                    else if (item.Status == Enums.Status.None)
                    {
                        return "Üzgünüm bu kitap kütüphanemizde mevcut değildir.";
                    }                    
                }
            }
            return "Geçersiz işlem";
        }


        public string ReturningBook(int memberNo, string isbn)
        {
            Member member = new Member();

            foreach (Member item in Members)
            {
                if (member.MemberNo == memberNo)
                {
                    member = item;
                }
            }

            foreach (Book item in Books)
            {
                if (item.ISBN == isbn)
                {
                    member.Books.Remove(item);
                    item.Status = Enums.Status.Available;
                    return "Kitap teslim alınmıştır.";
                }
            }
            return "Geçersiz işlem";        
        }
    }
}
