

using _02Uzduotis.Models;
using _02Uzduotis.Services;

WorkWithTextService workWithTextService = new WorkWithTextService("C:\\C# Mokymai\\PaskaitaLINQ\\02Uzduotis\\bin\\Debug\\net8.0\\Document.txt");

List<Item> items = await workWithTextService.LoadItemsAsync(workWithTextService.ConvertFromCsvLine);

foreach (var item in items)
{
    Console.WriteLine($"{item}");
}

Console.WriteLine("Įveskite autoriu arba zanra:");
string input = Console.ReadLine().ToLower();

var booksBy = items
    .OfType<Book>()
    .Where(book => book.Author.ToLower().Contains(input) || book.Genre.ToLower().Contains(input))
    .ToList();

booksBy.ForEach(book => Console.WriteLine($"{book}"));


Console.WriteLine("Įveskite leideja arba isleidimo metus:");
string input2 = Console.ReadLine().ToLower();

var magazinesBy = items
    .OfType<Magazine>()
    .Where(magazine => magazine.Publisher.ToLower().Contains(input2) || magazine.PublicationYear.ToString().Contains(input2))
    .ToList();

magazinesBy.ForEach(magazine => Console.WriteLine($"{magazine}"));
