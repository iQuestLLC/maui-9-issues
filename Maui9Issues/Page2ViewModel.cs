using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maui9Issues
{
    public partial class Page2ViewModel : BaseViewModel
    {
        public Page2ViewModel()
        {
            // Add colors
            FavoriteColors.Add("Navy Blue");
            FavoriteColors.Add("Dark Red");
            FavoriteColors.Add("Silver");
            FavoriteColors.Add("Granite");
            FavoriteColors.Add("Pearl White");
            FavoriteColors.Add("Flourescent Green");

            // Add cars
            FavoriteCars.Add("'25 RAM 1500 Limited Longhorn");
            FavoriteCars.Add("'24 Tesla Model S");
            FavoriteCars.Add("1957 Mercedes Benz 300 SL - Roadster");
            FavoriteCars.Add("1942 Dodge Power Wagon");

            // Add towns
            FavoriteTowns.Add("Jackson Hole, WY");
            FavoriteTowns.Add("Bozeman, MT");
            FavoriteTowns.Add("Salt Lake City, UT");
            FavoriteTowns.Add("Santa Fe, NM");
            FavoriteTowns.Add("Ouray, CO");
            FavoriteTowns.Add("Killington, VT");
        }


        public ObservableCollection<string> FavoriteColors { get; } = new();

        public ObservableCollection<string> FavoriteCars { get; } = new();

        public ObservableCollection<string> FavoriteTowns { get; } = new();
    }
}