using System;
using System.ComponentModel;
using Xamarin.Forms;
using Menu.Models;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Data;
using SQLite;

[assembly: Dependency(typeof(SQLite3))]
namespace Menu.ViewModels
{
    
    public class MainViewModel : INotifyPropertyChanged
    {
        public MainViewModel(string dbPath) 
        {

            Console.WriteLine(1);

            AppetizersButton = new Command(() =>
            {
                using (var menu = new MenuContext(dbPath))
                {
                    
                    collectionItems = new ObservableCollection<string>(menu.Appetizers.ToArray().Select((a) => a.AppetizerName));
                }
            });
        }


        public ObservableCollection<string> collectionItems { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public Command AppetizersButton { get; }
        public Command DessertsButton { get; }
        public Command DonburiButton { get; }
        public Command DrinksButton { get; }
        public Command RamenButton { get; }
    }
}
