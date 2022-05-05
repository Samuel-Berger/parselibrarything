using System.Text.Json.Serialization;

namespace ParseLibraryThingy
{
    class Book
    {
        [JsonPropertyName("books_id")]
        public string BookId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("sortcharacter")]
        public string SortCharacter { get; set; }

        [JsonPropertyName("public")]
        public string Public { get; set; }

        [JsonPropertyName("primaryauthor")]
        public string PrimaryAuthor { get; set; }

        [JsonPropertyName("primaryauthorrole")]
        public string PrimaryAuthorRole { get; set; }

        [JsonPropertyName("authors")]
        IEnumerable<Authors> Author { get; set; }

        [JsonPropertyName("originalisbn")]
        public string OriginalIsbn { get; set; }
    }
}