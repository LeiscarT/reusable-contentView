﻿using ReusableContentView.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ReusableContentView.ViewModels
{
    class MenuViewModel : INotifyPropertyChanged
    {
        public Card Item1 { get; }
        public Card Item2 { get; }
        public Card Item3 { get; }
        public Card Item4 { get; }
        public Card Item5 { get; }
        public Card Item6 { get; }

        public MenuViewModel()
        {
            Item1 = new Card("Bar & Hotels", "beach.png", "42 places");
            Item2 = new Card("Fine Dining", "beach.png", "16 places");
            Item3 = new Card("Coffes", "beach.png", "20 places");
            Item4 = new Card("Nearby", "beach.png", "80 places");
            Item5 = new Card("Fast Food", "beach.png", "17 places");
            Item6 = new Card("Featured Foods", "beach.png", "12 places");
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}