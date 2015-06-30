using Biletiki.Contracts;
using Biletiki.WindowsClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biletiki.WindowsClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<MovieModel> Movies { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Movies = new ObservableCollection<MovieModel>();
            DataContext = this;

            var clientFactory = new ChannelFactory<IBiletikiService>("BiletikiServiceEndpoint");
            var client = clientFactory.CreateChannel();

            var requestParameters = new AfficheRequestParameters() 
            { 
                PagingInfo = new PagingInfo { PageNumber = 1, PageSize = 20 } 
            };

            Task
                .Run(() => client.GetAffiche(requestParameters))
                .ContinueWith(t =>
                {
                    foreach(var movie in t.Result.Movies)
                    {
                        Movies.Add(new MovieModel 
                        {
                            Name = movie.Name,
                            ShowingDates = string.Format("{0} - {1}", movie.ShowingFrom.ToShortDateString(), movie.ShowingTo.ToShortDateString()),
                            DurationInMinutes = movie.DurationInMinutes,
                            VerticalBarDelimitedGenres = string.Join(" | ", movie.Genres),
                            IMDBRating = movie.IMDBRating.HasValue ? movie.IMDBRating.Value.ToString("F1") : "No Rating Available",
                            Description = movie.Description,
                            CommaDelimitedDirectors = string.Join(", ", movie.Directors),
                            CommaDelimitedStars = string.Join(", ", movie.Stars),
                            CommaDelimitedWriters = string.Join(", ", movie.Writers)
                        });
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
