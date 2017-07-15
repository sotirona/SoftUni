﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.BookShop
{
  public  class GoldenEditionBook : Book
    {
        public GoldenEditionBook( string author, string title, decimal price)
            : base(author, title, price)
        {

        }

        public override decimal Price
        {
            get
            {
                return base.Price*1.3m;
            }

            set
            {
                base.Price = value;
            }
        }
    }
}
