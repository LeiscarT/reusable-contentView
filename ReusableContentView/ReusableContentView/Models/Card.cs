using System;
using System.Collections.Generic;
using System.Text;

namespace ReusableContentView.Models
{
    class Card
    {
        public string Title { get;}
        public string Image { get;}
        public string Detail  {get;}

        public Card(string title, string image, string detail)
        {
            Title = title;
            Image = image;
            Detail = detail;
        }

    }
}
