



using System;
using System.Collections.Generic;





namespace FrostSteelCorporation.Index.Models
{
    public class IndexAnimation
    {
        public float indexPercent { get; set; }
        public float indexSpeed { get; set; }

        public List<IndexWords> indexWords { get; set; }

        public IndexAnimation()
        {
            indexSpeed = 1;
            indexPercent = 0;
            indexWords = new List<IndexWords>();
        }








    }
}
