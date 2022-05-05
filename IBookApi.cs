using ParseLibraryThingy;
// using ParseLibraryThingy.Models;

namespace ParseLibraryThingy
{
    interface IBookApi
    {
        public Task<Book> ParseJson();

    }
}