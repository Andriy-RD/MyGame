using System;
using System.Collections.Generic;

namespace Core
{
    public class Town
    {
        public Storage storage;

        public int Area { get; set; }

        public List<IBuilding> buildings = new List<IBuilding>();

        public void BuildBuilding(IBuilding building) {
            if (building.Build(this))
                buildings.Add(building);
        }

        public string Name { get; set; }

        public Town(string name) {
            Name = name;
            storage = new Storage();
        }

    }
}
