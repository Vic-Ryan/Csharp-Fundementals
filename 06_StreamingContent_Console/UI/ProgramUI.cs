using _06_StreamingConten_Repository;
using _06_StreamingConten_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly ContentRepository _repo = new ContentRepository();
        private readonly IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedContentList(); //Addiing movies before we start
            //Now begin ther program
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();

                _console.WriteLine("Enter the number of the option you would like:\n" +
                    "1. Show all content\n" +
                    "2. Show all Movies \n" +
                    "3. Show all shows \n" +
                    "4. Get content by title\n" +
                    "5. Get contant by minimum star rating\n" +
                    "6. Add content to directory\n" +
                    "7. Update content in directory\n" +
                    "8. Remove content from directory\n" +
                    "9. Exit");

                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        ShowAllContent();
                        break;
                    case "2":
                        ShowAllMovies();
                        break;
                    case "3":
                        ShowAllShows();
                        break;
                    case "4":
                        GetContentByTitle();
                        break;
                    case "5":
                        GetContentByMinimumStarRating();
                        break;
                    case "6":
                        AddContent();
                        break;
                    case "7":
                        UpdateContent();
                        break;
                    case "8":
                        RemoveContent();
                        break;
                    case "9":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 and 7.\n" +
                            "Press any key to continue...");
                        _console.ReadLine();
                        break;
                }
            }
        }
        private void AddContent()
        {
            _console.Clear(); //Clear the Menu
            //Set aside variable to the hold information from the user unti I'm ready
            StreamingContent content = new StreamingContent();

            //Title
            _console.Write("Please enter a title: ");
            content.Title = _console.ReadLine();

            //Description
            _console.Write("Please enter a description: ");
            content.Description = _console.ReadLine();

            //Star Rating
            _console.Write("Please enter a star rating 0-5: ");
            content.StarRating = double.Parse(_console.ReadLine());

            //Maturity Rating
            _console.WriteLine("Select maturity rating:\n" +
            "1.  G\n" +
            "2.  PG\n" +
            "3.  PG13\n" +
            "4.  R\n" +
            "5.  NC 17\n" +
            "6.  TV Y\n" +
            "7.  TV G\n" +
            "8.  TV PG\n" +
            "9.  TV 14\n" +
            "10. TV MA");

            string maturityRating = _console.ReadLine();
            switch (maturityRating)
            {
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_Y;
                    break;
                case "7":
                    content.MaturityRating = MaturityRating.TV_G;
                    break;
                case "8":
                    content.MaturityRating = MaturityRating.TV_PG;
                    break;
                case "9":
                    content.MaturityRating = MaturityRating.TV_14;
                    break;
                case "10":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;


            }

            //Genre Type
            // public enum GenreType { Horror = 1, Drama, Fantasy, Action, Comedy, SciFi, Romance, Bromance}
            _console.WriteLine("Select a Genre: \n" +
                "1. Horror\n" +
                "2. Drama\n" +
                "3. Fantasy\n" +
                "4. Action\n" +
                "5. Comedy\n" +
                "6. SciFi\n" +
                "7. Romance\n" +
                "8. Bromance");

            string genreInput = _console.ReadLine();
            int genreID = int.Parse(genreInput);
            //Casting
            content.GenreType = (GenreType)genreID;

            if (_repo.AddContentToDirectory(content))
            {
                _console.WriteLine("Success! Press any key to continue.");
                _console.ReadKey();
            }
            else
            {
                _console.WriteLine("Failure! Press any key to continue.");
                _console.ReadKey();
            }
        }

        private void ShowAllContent()
        {
            _console.Clear();

            List<StreamingContent> listOfContent = _repo.GetContents();
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            AnyKey();
        }

        private void ShowAllMovies()
        {
            _console.Clear();

            List<Movies> listOfContent = _repo.GetAllMovies();
            foreach (Movies content in listOfContent)
            {
                DisplayContent(content);
            }
            AnyKey();
        }

        private void ShowAllShows()
        {
            _console.Clear();

            List<Shows> listOfContent = _repo.GetAllShows();
            foreach (Shows content in listOfContent)
            {
                DisplayContent(content);
            }
            AnyKey();
        }

        private void GetContentByTitle()
        {
            _console.Clear();
            //prompt
            _console.Write("Enter a title: ");
            //Capture inpuit
            string title = _console.ReadLine();
            //Look up content
            StreamingContent content = _repo.GetContentByTitle(title);
            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {
                _console.WriteLine("Couldn't find content by that title.");
            }
            AnyKey();
        }

        private void GetContentByMinimumStarRating()
        {
            _console.Clear();
            _console.Write("Please enter a minimum star rating: ");
            string ratingRaw = _console.ReadLine();
            double rating = double.Parse(ratingRaw);
            //Having made commands in repository, can call upon them now versus making them again
            List<StreamingContent> listOfContent = _repo.GetByStarRatingByMinimum(rating);
            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            AnyKey();
        }

        private void UpdateContent()
        {
            _console.Clear();
            _console.Write("Please enter the title of the movie you wish to update: ");
            StreamingContent oldContent = _repo.GetContentByTitle(_console.ReadLine());

            if (oldContent != null)
            {
                _console.WriteLine("Enter updated information here, leave blank if unchanged");
                _console.Write("Please enter a title: ");
                string titleInput = _console.ReadLine();
                if (titleInput != "")
                {
                    oldContent.Title = titleInput;
                }

                //Description
                _console.Write("Please enter a description: ");
                string descInput = _console.ReadLine();
                if (descInput != "")
                {
                    oldContent.Description = descInput;
                }

                //Star Rating
                _console.Write("Please enter a star rating 0-5: ");
                string starInput = _console.ReadLine();
                if (starInput != "")
                {
                    oldContent.StarRating = double.Parse(starInput);
                }

                //Maturity Rating
                _console.WriteLine("Select maturity rating:\n" +
                "1.  G\n" +
                "2.  PG\n" +
                "3.  PG13\n" +
                "4.  R\n" +
                "5.  NC 17\n" +
                "6.  TV Y\n" +
                "7.  TV G\n" +
                "8.  TV PG\n" +
                "9.  TV 14\n" +
                "10. TV MA");

                string maturityRating = _console.ReadLine();

                if (maturityRating != "")
                {

                    switch (maturityRating)
                    {
                        case "1":
                            oldContent.MaturityRating = MaturityRating.G;
                            break;
                        case "2":
                            oldContent.MaturityRating = MaturityRating.PG;
                            break;
                        case "3":
                            oldContent.MaturityRating = MaturityRating.PG13;
                            break;
                        case "4":
                            oldContent.MaturityRating = MaturityRating.R;
                            break;
                        case "5":
                            oldContent.MaturityRating = MaturityRating.NC_17;
                            break;
                        case "6":
                            oldContent.MaturityRating = MaturityRating.TV_Y;
                            break;
                        case "7":
                            oldContent.MaturityRating = MaturityRating.TV_G;
                            break;
                        case "8":
                            oldContent.MaturityRating = MaturityRating.TV_PG;
                            break;
                        case "9":
                            oldContent.MaturityRating = MaturityRating.TV_14;
                            break;
                        case "10":
                            oldContent.MaturityRating = MaturityRating.TV_MA;
                            break;
                    }


                }

                //Genre Type
                // public enum GenreType { Horror = 1, Drama, Fantasy, Action, Comedy, SciFi, Romance, Bromance}
                _console.WriteLine("Select a Genre: \n" +
                    "1. Horror\n" +
                    "2. Drama\n" +
                    "3. Fantasy\n" +
                    "4. Action\n" +
                    "5. Comedy\n" +
                    "6. SciFi\n" +
                    "7. Romance\n" +
                    "8. Bromance");

                string genreInput = _console.ReadLine();
                if (genreInput != "")
                {
                    int genreID = int.Parse(genreInput);
                    //Casting
                    oldContent.GenreType = (GenreType)genreID;
                }

            }
            else
                _console.WriteLine("No content by that title found");

            AnyKey();
        }

        private void RemoveContent()
        {
            _console.Clear();

            List<StreamingContent> contentList = _repo.GetContents();
            int count = 0;

            foreach (StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}. {content.Title}");
            }
            _console.Write("What content do you want to remove?");
            int targetID = int.Parse(_console.ReadLine());
            int targetIndex = targetID - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if (_repo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} deleted successfully.");
                }
                else
                {
                    _console.WriteLine("Something went wrong.");
                }
            }
            else
                _console.WriteLine("No content has that ID.");

            AnyKey();
        }

        private void SeedContentList()
        {
            Movies corpseBride = new Movies("Corpse Bride", "A victorian man accidentally vows to wed the undead.", 4.8, MaturityRating.PG13, GenreType.Romance, 115, 2009);
            Movies deathOfStalin = new Movies("Death of Stalin", "Stalin has died, and his incompentent successors pursue his position", 3.7, MaturityRating.R, GenreType.Comedy, 125, 2016);
            Movies isleOfDogs = new Movies("Isle Of Dogs", "All dogs have been banned, and now a group of them help one boy prove their banishment was wrong.", 4.2, MaturityRating.PG13, GenreType.Action, 130, 2018);

            Episode episode1 = new Episode("The Forever Train", 44, 1, 1);
            Episode episode4 = new Episode("The Apalachan Turn", 44, 2, 1);
            Episode episode3 = new Episode("A New Revolution", 44, 1, 3);
            Episode episode2 = new Episode("Rougher Tracks", 44, 1, 2);

            Shows snowPiercer = new Shows("Snowpiercer", "Humanity survives the ice age on a forever running train", 4.6, MaturityRating.TV_14, GenreType.Drama, 1, new List<Episode>() { episode1, episode4, episode2, episode3});
            _repo.AddContentToDirectory(corpseBride);
            _repo.AddContentToDirectory(deathOfStalin);
            _repo.AddContentToDirectory(isleOfDogs);
            _repo.AddContentToDirectory(snowPiercer);
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title}\n" +
    $"Description {content.Description}\n" +
    $"Genre {content.GenreType}\n" +
    $"Maturity Rating {content.MaturityRating}\n" +
    $"Star Rating {content.StarRating} Stars\n");
            if(content is Movies)
            {
                _console.WriteLine($"Runtime: {((Movies)content).RunTime}\n" +
                    $"Year: {((Movies)content).Year}");
            }
            else if (content is Shows)
            {
                Shows show = content as Shows;
                _console.WriteLine($"Average Run Time: {show.AverageRunTime} \n" +
                    $"Number of Seasons: {show.NumberOfSeasons} \n");
                foreach (Episode ep in show.Episodes.OrderBy(s => s.SeasonNumber).ThenBy(e => e.EpisodeNumber))
                {
                    _console.WriteLine($"    {ep.SeasonNumber}x{ep.EpisodeNumber} {ep.Title}");
                }
            }
            _console.WriteLine();
        }

        private void AnyKey()
        {
            //DRY - Don't Repeat Yourself
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }
    }
}
