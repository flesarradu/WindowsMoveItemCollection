using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsMoveItemCollection
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<MainItem> _items;


        public MainViewModel()
        {
            List<MainItem> items = new List<MainItem>();

            foreach (var item in Enumerable.Range(0, 20))
            {
                items.Add(new MainItem
                {
                    Label = "Label " + item,
                    Description = "Description " + item,
                });
            }

            Items = new ObservableCollection<MainItem>(items);
        }

        [RelayCommand]
        private void Move()
        {
            Items.Move(5, 7);
        }
    }


}
