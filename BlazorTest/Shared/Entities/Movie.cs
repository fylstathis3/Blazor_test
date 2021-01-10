using System;

namespace BlazorTest.Shared.Entities
{
    public class Movie
    {
        public int Id { get; set; } = 1;
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}