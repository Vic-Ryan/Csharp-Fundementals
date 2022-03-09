using _06_StreamingConten_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingConten_Repository
{
    public class ContentRepository : StreamingContentRepository
    {
        //Create
        //Read
        public List<Shows> GetAllShows()
        {
            List<Shows> allShows = new List<Shows>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Shows)
                {
                    allShows.Add(content as Shows);
                }
            }
            return allShows;
        }
        public List<Movies> GetAllMovies()
        {
            List<Movies> allMovies = new List<Movies>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movies) //similar to GetType == TypeOf
                {
                    allMovies.Add(content as Movies); //similar to casting
                }
            }
            return allMovies;

        }



        public Shows GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Shows))
                {
                    return (Shows)content;
                }
            }
            return null;
        }

        public Movies GetShowByMovie(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Movies))
                {
                    return (Movies)content;
                }
            }
            return null;
        }

        //Update
        //Delte
    }
}



