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
                    Title = "<b>None</b>",
                    ReleaseDate = DateTime.Now
                },
                new Movie(){
                    Title = "<i>None2</i>",
                    ReleaseDate = DateTime.Now
                }
            };
        }
    }
}