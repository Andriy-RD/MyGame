using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Core
{
    public class Storage
    {
        public Dictionary<string, int> resources = new Dictionary<string, int>();
        
        static public bool Payment(Town town, Storage price) {
            foreach (var res in town.storage.resources) {
                if (res.Value < price.resources[res.Key])
                    return false;
            }

            List<string> _keys = new List<string>(town.storage.resources.Keys);

            foreach (var key in _keys) {
                town.storage.resources[key] -= price.resources[key];
            }

            return true;
        }

        public Storage(int stone, int tree, int metal, int coal, int money) {
            resources.Add("Stone", stone);
            resources.Add("Tree", tree);
            resources.Add("Metal", metal);
            resources.Add("Coal", coal);
            resources.Add("Money", money);
        }

        public Storage() {
            resources.Add("Stone", 150);
            resources.Add("Tree", 150);
            resources.Add("Metal", 150);
            resources.Add("Coal", 150);
            resources.Add("Money", 1750);
        }
    }
}
