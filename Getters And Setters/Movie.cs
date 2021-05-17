namespace Getters_And_Setters
{
    public class Movie
    {
        public string Title;
        public string Director;
        private string _rating; // Cannot be accessed

        public Movie(string title, string director, string movieRating)
        {
            Title = title;
            Director = director;
            _rating = movieRating;
        }

        public string Rating
        {
            get { return _rating; }
            set
            {
                if (value == "Good" || value == "Bad")
                {
                    _rating = value;
                }
                else
                {
                    _rating = "Unknown";
                }
            }
        }
    }
}