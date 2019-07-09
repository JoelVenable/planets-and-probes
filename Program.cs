using System;
using System.Collections.Generic;

namespace planets_and_probes
{
  class Program
  {
    static void Main(string[] args)
    {
      var planetList = new List<string>() {
                "Mercury",
                "Venus",
                "Earth",
                "Mars",
                "Jupiter",
                "Saturn",
                "Neptune",
                "Uranus"
            };

      var probeDestinations = new List<KeyValuePair<string, string>>() {
          new KeyValuePair<string, string>("Viking 1", "Mars"),
          new KeyValuePair<string, string>("Mariner 1", "Venus"),
          new KeyValuePair<string, string>("Voyager 1", "Jupiter"),
          new KeyValuePair<string, string>("Voyager 1", "Saturn")
    };

      planetList.ForEach(planet =>
      {
        List<string> matchingProbes = new List<string>();

        probeDestinations.ForEach(visit =>
        {
          if (visit.Value == planet)
          {
            matchingProbes.Add(visit.Key);
          }
        });

        Console.WriteLine($"{planet}: {String.Join(",", matchingProbes)}");
      });
    }
  }
}
