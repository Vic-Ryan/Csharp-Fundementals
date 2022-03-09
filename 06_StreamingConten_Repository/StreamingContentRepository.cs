using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingConten_Repository
{
    public class StreamingContentRepository
    {
        //Simulated Database Essentially 
        //Essentially private  
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Repository pattern; A typical design pattern for accessing/using databases
        //CRUD Funcationality; The standard functions you need

        //Create
        public bool AddContentToDirectory(StreamingContent content)
        {
            int startingCount = _contentDirectory.Count();
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count() > startingCount) ? true : false;
            return wasAdded;
            //Used to check if someone added to the directory, and will return a true if it was or false if not, allowing investigation
        }

        //Read
        public List<StreamingContent> GetContents() //A way for users to read content of the directory
        {
            return _contentDirectory;
        }

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null; //Not the best practice, typically want to write an exception
        }

        public List<StreamingContent> GetFamilyFriendlyContent()
        {
            List<StreamingContent> familyFriendly = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.IsFamilyFriendly)
                {
                    familyFriendly.Add(content);
                }
            }
            return familyFriendly;
        }

        public List<StreamingContent> GetUnFamilyFriendlyContent()
        {
            List<StreamingContent> nonFamilyFriendly = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (!content.IsFamilyFriendly)
                {
                    nonFamilyFriendly.Add(content);
                }
            }
            return nonFamilyFriendly;
        }
        public List<StreamingContent> GetByStarRatingByMinimum(double minimumStarRating)
        {
            List<StreamingContent> starContent = new List<StreamingContent>();
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.StarRating >= minimumStarRating)
                {
                    starContent.Add(content);
                }
            }
            //LINQ order by 
            return starContent.OrderBy(c=>c.StarRating).ToList(); //Easiest way to sort something... I suppose. Will be explained better at later date.
        }

        //Update
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);
            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;

                return true;
            }
            else
            {
                return false;
            }

        }


        //Delete
        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }
    }
}
