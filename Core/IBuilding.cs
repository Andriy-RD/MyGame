using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IBuilding
    {
        public bool Build(Town town)
        {
            if (Storage.Payment(town, Price))
                if (town.Area >= Area) {
                    town.Area -= Area;
                    return true;
                }
            return false;
        }

        public int BuildTime { get; }

        public int Area { get; }

        public int Health { get; }  

        public Storage Price { get; }
    }
}