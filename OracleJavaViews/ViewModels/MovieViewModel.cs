using OracleJavaModel;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace OracleJavaViews.ViewModels
{
	public class MovieViewModel : BindableBase
	{
        private ObservableCollection<Movie> movies = 
            new ObservableCollection<Movie>();

        private Movie movie = Movie.Starwars;
        public MovieViewModel()
        {
            movies.Clear();
            foreach (string name in Enum.GetNames(typeof(Movie)))
            {
                movies.Add((Movie)Enum.Parse(typeof(Movie), name));
            }
        }

        public ObservableCollection<Movie> Movies
        {
            get { return movies; }
            set { SetProperty(ref movies, value); }
        }

        public Movie Movie
        {
            get { return movie; }
            set { 
                SetProperty(ref movie, value);
                MessageBox.Show(movie.ToString());
            }
        }
	}
}
