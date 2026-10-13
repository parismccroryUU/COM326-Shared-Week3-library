using Library;

List<Book> books = new List<Book>();
List<Member> members = new List<Member>();

books.Add(new Book("C# for beginners", "BillGates", "12345678"));
books.Add(new Book("C# Methods and classes", "Microsoft", "55667778"));



members.Add(new Member(1, "John Smith", "High Street", 0790090090));
members.Add(new Member(2, "Mary Jones", "Garden Road", 0790345666));



//Display all items in book list
foreach (Book book in books)
{
    Console.WriteLine($"Book Title: {book.Title}");
    Console.WriteLine($"Author: {book.Author}");
    Console.WriteLine($"ISBN: {book.ISBN}");
    Console.WriteLine();
}

//Display all members in member list
foreach (Member member in members)
{
    Console.WriteLine($"Member ID: {member.MemberId}");
    Console.WriteLine($"Name: {member.Name}");
    Console.WriteLine($"Address: {member.Address}");
    Console.WriteLine($"Phone: {member.Phone}");
    Console.WriteLine();
}