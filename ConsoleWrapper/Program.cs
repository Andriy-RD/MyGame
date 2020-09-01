using System;
using Core;
using System.Collections.Generic;

namespace ConsoleWrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Town town = new Town("project#2");
            foreach (var e in town.storage.resources) {
                Console.WriteLine($"{e.Key}: {e.Value}");
            }

            town.BuildBuilding(new House());
            foreach (var e in town.buildings) {
                Console.WriteLine($"{e.Area} - area");
            }

            Console.WriteLine();
            foreach (var e in town.storage.resources)
            {
                Console.WriteLine($"{e.Key}: {e.Value}");
            }
        }
    }
}
