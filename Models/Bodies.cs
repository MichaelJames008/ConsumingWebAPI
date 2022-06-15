using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumingWebAPI.Models
{
    public class Bodies
    {
        public string id { get; set; }
        public string name { get; set; }
        public string englishName { get; set; }
        public bool isPlanet { get; set; }
        //public IList<string> moons { get; set; }
        public string semimajorAxis { get; set; }
        public string perihelion { get; set; }
        public string aphelion { get; set; }
        public double eccentricity { get; set; }
        public double inclination { get; set; }
        public Mass mass { get; set; }
        public Vol vol { get; set; }
        public double density { get; set; }
        public double gravity { get; set; }
        public string escape { get; set; }
        public string meanRadius { get; set; }
        public double equaRadius { get; set; }
        public string polarRadius { get; set; }
        public double flattening { get; set; }
        public string dimension { get; set; }
        public double sideralOrbit { get; set; }
        public double sideralRotation { get; set; }
        public AroundPlanet aroundPlanet { get; set; }
        public string discoveredBy { get; set; }
        public string discoveryDate { get; set; }
        public string alternativeName { get; set; }
        public double axialTilt { get; set; }
        public string avgTemp { get; set; }
        public string mainAnomaly { get; set; }
        public string argPeriapsis { get; set; }
        public string longAscNode { get; set; }
        public string bodyType { get; set; }
        public string rel { get; set; }

    }
}
