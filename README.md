# Challenge: Planets and Probes and KeyValuePairs

In this exercise, you are going to directly use KeyValuePairs instead of Dictionaries.

### Instructions

> **Ref:** [List of Solar System probes](https://en.wikipedia.org/wiki/List_of_Solar_System_probes)

1. Use the list of planets you created in the previous chapter or create a new one with all eight planets.

   ```cs
   List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", ...};
   ```

1. Create a list containing KeyValuePairs. Each KeyValuePair will hold the name of a spacecraft that we have launched, and the name of a planet that it has visited. The key of the KeyValuePair will be the probe name, and the value will be the planet it visited.

   ```cs
   List<KeyValuePair<string, string>> probeDestinations = new List<KeyValuePair<string, string>>();
   // Add some planet/probe combinations to the list
   ```

   This would be the equivalent of an having an array of objects in JavaScript.

   ```js
   const probeDestinations = [
     {
       "Viking 1": "Mars"
     },
     {
       "Mariner 1": "Venus"
     },
     {
       "Voyager 1": "Jupiter"
     },
     {
       "Voyager 1": "Saturn"
     }
   ];
   ```

1. Iterate over `planetList`, and inside that loop, iterate over the list of key-value pairs. Write to the console, for each planet, which probes have visited it.

   ```cs
   // Iterate planets
   foreach (string planet in planetList)
   {
       // List to store probes that visited the planet
       List<string> matchingProbes = new List<string>();

       // Iterate probeDestinations
       foreach()
       {
           /*
               Does the current probe's destination
               match the value of the `planet` variable?
               If so, add it to the list.
           */
       }

       /*
           Use String.Join(",", matchingProbes) as part of the
           solution to get the output below. It's the C# way of
           writing `array.join(",")` in JavaScript.
       */
       Console.WriteLine($"{}: {}");
   }
   ```

#### Example Output in the Terminal

```sh
Mars: Viking, Opportunity, Curiosity
Venus: Mariner, Venera
```
