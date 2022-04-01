using System;
using System.Collections.Generic;
using System.Text;

namespace UplayFalso
{
    public abstract class Products
    {
        public string Title;
        public string Description;
        public List<Icons> Icons;
        public List<Icons> BigBanner;
        public string urlTrailer;
        public float Price;
        public DateTime publishingDate;
        public int Size;
        public List<string> Developers;
        public List<string> Producers;
        public string DLC;
    }
}
