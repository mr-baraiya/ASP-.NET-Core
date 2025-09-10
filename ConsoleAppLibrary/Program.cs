using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ConsoleAppLibrary.Data;
using ConsoleAppLibrary.Models;

class Program
{
    static void Main(string[] args)
    {
        using var context = new LibraryContext();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n===== Library Management System =====");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Add Member");
            Console.WriteLine("3. Borrow Book");
            Console.WriteLine("4. Return Book");
            Console.WriteLine("5. List Borrowed Books with Members");
            Console.WriteLine("6. List Available Books");
            Console.WriteLine("7. Show Top 3 Members");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");

            string? input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    AddBook(context);
                    break;
                case "2":
                    AddMember(context);
                    break;
                case "3":
                    BorrowBook(context);
                    break;
                case "4":
                    ReturnBook(context);
                    break;
                case "5":
                    ListBorrowedBooks(context);
                    break;
                case "6":
                    ListAvailableBooks(context);
                    break;
                case "7":
                    ShowTopMembers(context);
                    break;
                case "0":
                    exit = true;
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Try again!");
                    break;
            }
        }
    }

    // --- Methods for each operation ---
    static void AddBook(LibraryContext context)
    {
        Console.Write("Enter book title: ");
        string? title = Console.ReadLine();

        Console.Write("Enter author name: ");
        string? author = Console.ReadLine();

        var book = new Book { Title = title ?? "", Author = author ?? "", IsAvailable = true };
        context.Books.Add(book);
        context.SaveChanges();
        Console.WriteLine("✅ Book added successfully.");
    }

    static void AddMember(LibraryContext context)
    {
        Console.Write("Enter member name: ");
        string? name = Console.ReadLine();

        Console.Write("Enter member email: ");
        string? email = Console.ReadLine();

        var member = new Member { Name = name ?? "", Email = email ?? "" };
        context.Members.Add(member);
        context.SaveChanges();
        Console.WriteLine("✅ Member added successfully.");
    }

    static void BorrowBook(LibraryContext context)
    {
        Console.Write("Enter member ID: ");
        int memberId = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Enter book ID: ");
        int bookId = int.Parse(Console.ReadLine() ?? "0");

        var member = context.Members.Find(memberId);
        var book = context.Books.Find(bookId);

        if (member == null) { Console.WriteLine("❌ Member not found."); return; }
        if (book == null) { Console.WriteLine("❌ Book not found."); return; }
        if (!book.IsAvailable) { Console.WriteLine("❌ Book is not available."); return; }

        var borrow = new BorrowRecord
        {
            BookId = bookId,
            MemberId = memberId,
            BorrowDate = DateTime.Now
        };

        book.IsAvailable = false;
        context.BorrowRecords.Add(borrow);
        context.SaveChanges();

        Console.WriteLine($"✅ {member.Name} borrowed '{book.Title}'.");
    }

    static void ReturnBook(LibraryContext context)
    {
        Console.Write("Enter borrow record ID: ");
        int borrowId = int.Parse(Console.ReadLine() ?? "0");

        var borrow = context.BorrowRecords.Include(br => br.Book).FirstOrDefault(br => br.Id == borrowId);

        if (borrow == null || borrow.ReturnDate != null)
        {
            Console.WriteLine("❌ Invalid borrow record.");
            return;
        }

        borrow.ReturnDate = DateTime.Now;
        borrow.Book!.IsAvailable = true;
        context.SaveChanges();

        Console.WriteLine($"✅ '{borrow.Book.Title}' has been returned.");
    }

    static void ListBorrowedBooks(LibraryContext context)
    {
        var borrowedBooks = context.BorrowRecords
            .Where(br => br.ReturnDate == null)
            .Include(br => br.Book)
            .Include(br => br.Member)
            .Select(br => new { br.Book!.Title, br.Member!.Name })
            .ToList();

        if (!borrowedBooks.Any())
        {
            Console.WriteLine("📖 No books are currently borrowed.");
            return;
        }

        Console.WriteLine("📚 Borrowed Books:");
        foreach (var item in borrowedBooks)
            Console.WriteLine($"- {item.Title} (by {item.Name})");
    }

    static void ListAvailableBooks(LibraryContext context)
    {
        var availableBooks = context.Books.Where(b => b.IsAvailable).ToList();

        if (!availableBooks.Any())
        {
            Console.WriteLine("📖 No available books.");
            return;
        }

        Console.WriteLine("📚 Available Books:");
        foreach (var b in availableBooks)
            Console.WriteLine($"- {b.Title} by {b.Author}");
    }

    static void ShowTopMembers(LibraryContext context)
    {
        var topMembers = context.BorrowRecords
            .GroupBy(br => br.Member!.Name)
            .Select(g => new { Name = g.Key, Count = g.Count() })
            .OrderByDescending(x => x.Count)
            .Take(3)
            .ToList();

        if (!topMembers.Any())
        {
            Console.WriteLine("📖 No borrow history found.");
            return;
        }

        Console.WriteLine("🏆 Top 3 Members:");
        foreach (var tm in topMembers)
            Console.WriteLine($"{tm.Name} - {tm.Count} books");
    }
}
