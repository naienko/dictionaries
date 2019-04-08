using System;
using System.Collections.Generic;

namespace dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
			List<string> planetList = new List<string>(){"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto"};

			List<Dictionary<string, string>> planetProbes = new List<Dictionary<string, string>>();
			planetProbes.Add(new Dictionary<string, string>(){ {"Mercury", "Mariner 10" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Mercury", "MESSENGER" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Venus", "Akatsuki" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Venus", "IKAROS" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Venus", "MESSENGER" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Mars", "Dawn" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Mars", "MAVEN" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Jupiter", "Voyager 2" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Jupiter", "Cassini" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Jupiter", "Juno" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Saturn", "Voyager 2" } });
			planetProbes.Add(new Dictionary<string, string>(){ {"Saturn", "Cassini" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Uranus", "Voyager 2" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Neptune", "Voyager 2" } });

			planetProbes.Add(new Dictionary<string, string>(){ {"Pluto", "New Horizons" } });


			foreach (string planet in planetList) {
				List<string> matchingProbes = new List<string>();
				foreach(Dictionary<string, string> probe in planetProbes) {
					if (probe.ContainsKey(planet)) {
						matchingProbes.Add(probe[planet]);
					} 
				}
				Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
			}
        }
    }
}
