﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_StreamingConten_Repository.Content
{
    public class Movies : StreamingContent
    {
        public Movies() { }
        public Movies(string title, string description, double stars, MaturityRating maturity, GenreType type) :base(title, description, stars, maturity, type) { }
        public Movies(string title, string description, double stars, MaturityRating maturity, GenreType type, double runTime, int year) : this(title, description, stars, maturity, type) 
        {
            RunTime = runTime;
            Year = year;
        }

        public double RunTime { get; set; }
        public int Year { get; set; }
    }
}
