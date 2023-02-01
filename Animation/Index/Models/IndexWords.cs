﻿using System;
using System.Drawing;



namespace FrostSteelCorporation.Index.Models
{
    public class IndexWords
    {

        public string indexTextString { get; set; }
        public PointF indexLocation { get; set; }
        
        public IndexBezierCurve indexPath { get; set; }
        public bool indexDrawPath { get; set; }
        public string indexColor { get; set; }
        public string indexFont { get; set; }

        public IndexWords()
        {
            indexColor = "#ffffff";
            indexFont = "70px Segoe Script";
        }









    }
}
