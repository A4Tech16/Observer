using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public sealed class News
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public News(string title, string content) 
        {
            Title = title;
            Content = content;
        }
    }
}
