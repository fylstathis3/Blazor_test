using System;
using System.Collections.Generic;
using BlazorTest.Shared.Entities;

namespace BlazorTest.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){
                    Title = "Spider-Man: Far From Home",
                    ReleaseDate = DateTime.Now
                },
                new Movie(){
                    Title = "Inception",
                    ReleaseDate = DateTime.Now
                }
            };
        }
    }
}