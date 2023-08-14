using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace choreScore.Models
{
    public class Chore
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public bool Important  { get; set; }
        public double Duration  { get; set; }

        public Chore(string title, string body, bool important, double duration)
        {
            Title = title;
            Body = body;
            Important = important;
            Duration = duration;
        }
    }
}