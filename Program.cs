using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {

            List<string> planetList = new List<string> () {
                "Mercury",
                "Mars"
            };
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            List<string> lastPlanets = new List<string> () {
                "Uranus",
                "Neptune"
            };

            planetList.AddRange (lastPlanets);

            planetList.Insert (3, "Earth");
            planetList.Insert (3, "Venus");

            planetList.Add ("Pluto");

            List<string> rockyPlanets = planetList.GetRange (0, 4);

            planetList.Remove ("Pluto");

            foreach (string solarSystem in planetList) {
                Console.WriteLine (solarSystem);
            }

            foreach (string planets in rockyPlanets) {
                Console.WriteLine (planets);
            }
        }
    }
}