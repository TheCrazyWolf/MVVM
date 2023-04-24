using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MVVM.Model;

namespace MVVM.ViewModel
{
    internal partial class MainWindowViewModel : ObservableObject
    {

        [ObservableProperty] private int count = 0;

        [ObservableProperty] private string textContentButton;


        [ObservableProperty] private ObservableCollection<Item> items;

        //[ObservableProperty] private Item selectedItem;

        private Item _selectedItem;
        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                SetProperty(ref _selectedItem, value);
                if (value.Name == "Два")
                    VisButton = "Hidden";
                else
                    VisButton = "Visible";
            }
        }

        [ObservableProperty] private string visButton = "Visible";


        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>
            {
                new Item() { Name = "Один" },
                new Item() { Name = "Два" },
                new Item() { Name = "Три" },
                new Item() { Name = "Четыре" }
            };


        }

        [RelayCommand]
        public void DoCount()
        {
            Count++;
            TextContentButton = $"Нажато {count} раз";
        }


        
    }
}
