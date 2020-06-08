﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class ListBox
    {
        private string listBoxContents;
        public ListBox(int top, int left, string contents) : base(top, left)
        {
            listBoxContents = contents;
        }

        public override void DrawWindow()
        {
            {
                base.DrawWindow();
                Console.WriteLine("Writing string to the listbox: {0}", listBoxContents);
            }
        }
    }
}
