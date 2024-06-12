using _02Uzduotis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace _02Uzduotis.Services
{
    public class WorkWithTextService
    {
        private readonly string _filePath;

        public WorkWithTextService(string filePath)
        {
            _filePath = filePath;
        }

        public async Task<List<T>> LoadItemsAsync<T>(Func<string, T> convertFromCsvLine)
        {
            var items = new List<T>();

            using (var reader = new StreamReader(_filePath))
            {
                string line;
                while ((line = await reader.ReadLineAsync()) != null)
                {
                    items.Add(convertFromCsvLine(line));
                }
            }

            return items;
        }

        public async Task SaveItemsAsync<T>(List<T> items, Func<T, string> convertToCsvLine)
        {
            using (var writer = new StreamWriter(_filePath, false))
            {
                foreach (var item in items)
                {
                    var line = convertToCsvLine(item);
                    await writer.WriteLineAsync(line);
                }
            }
        }

        public Item ConvertFromCsvLine(string line)
        {
            var parts = line.Split(',');

            if (parts[0] == "Book")
            {
                return new Book(
                    id: int.Parse(parts[1]),
                    title: parts[2],
                    publicationYear: int.Parse(parts[3]),
                    author: parts[4],
                    genre: parts[5]
                );
            }
            else if (parts[0] == "Magazine")
            {
                return new Magazine(
                    id: int.Parse(parts[1]),
                    title: parts[2],
                    publicationYear: int.Parse(parts[3]),
                    issueNumber: int.Parse(parts[4]),
                    publisher: parts[5]
                );
            }
            else
            {
                throw new ArgumentException("Unknown item type in CSV line");
            }
        }

    }
}
