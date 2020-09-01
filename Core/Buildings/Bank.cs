using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Buildings
{
    class Bank : IBuilding
    {
        public int BuildTime => 15;

        public int Area => 8;

        public int Health => 40;

        public Storage Price => new Storage(35, 15, 45, 0, 800);
    }
}
