using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class House : IBuilding
    {
        public int BuildTime => 4;

        public int Area => 3;

        public int Health => 20;

        public Storage Price => new Storage(15, 10, 10, 0, 65);
    }
}
