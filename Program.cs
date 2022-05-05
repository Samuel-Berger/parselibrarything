using System;
using System.Threading;
using System.Text.Json.Serialization;
using System.Text.Json;
using ParseLibraryThingy;

namespace ParseLibraryThingy
{
    class Program
    {
        public static async Task<int> Main()
        {
            JsonSerializerOptions prettyPrint = new JsonSerializerOptions {
                WriteIndented = true
            };

            BookApi bookApi = new BookApi();

            Book book = await bookApi.ParseJson();

            Console.WriteLine($"Model of the book: {JsonSerializer.Serialize<Book>(book, prettyPrint)}");
 
            return 0;
        }
    }
}