using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

using ParseLibraryThingy;
// using ParseLibraryThingy.Models;

namespace ParseLibraryThingy
{
    class BookApi : IBookApi
    {
        public async Task<Book> ParseJson()
        {
            Book book = await ReadAsync<Book>(@"./book.json");

            return book;
        }

        public static async Task<T> ReadAsync<T>(string filePath)
        {
            using FileStream stream = File.OpenRead(filePath);
            return await JsonSerializer.DeserializeAsync<T>(stream);
        }
    }

}