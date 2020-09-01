using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Map
    {
        public int Area { get; private set; }

        public List<Town> towns = new List<Town>();

        public Map() { }

        //TODO: MAP INIT
        public Map(int size, int slots) { }
    }
}
