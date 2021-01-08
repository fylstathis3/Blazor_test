using System.Collections.Generic;
using BlazorTest.Shared.Entities;

namespace BlazorTest.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}