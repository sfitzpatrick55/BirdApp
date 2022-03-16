using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdApp.Repository
{
    public enum Age { Hatching_Year, After_Hatching_Year, Second_Year, After_Second_Year, Third_Year, After_Third_Year, Indeterminable, Not_Attempted }
    public class Bird
    {
        public int BandNumber { get; set; } // Recorded band number.
        public string SpeciesName { get; set; } // Species name, as a string.
        public Age BirdAge { get; set; } // See enum Age reference above.
        public bool BodyMolt { get; set; } // Signs of body molt, true/false.
        public bool FlightFeatherWear { get; set; } // Signs of flight feather wear, true/false.
        public int WingLength { get; set; } // Length of one wing, recorded in centimeters.
        public double BodyMass { get; set; } // Weight of bird, recorded in grams with one decimal allowed.
        public int NetNumber { get; set; } // Net number where bird was retrieved, 1 - 14.

        // Full Constructor
        public Bird(int bandNumber, string speciesName, Age birdAge, bool bodyMolt, bool flightFeatherWear, int wingLength, double bodyMass, int netNumber)
        {
            BandNumber = bandNumber;
            SpeciesName = speciesName;
            BirdAge = birdAge;
            BodyMolt = bodyMolt;
            FlightFeatherWear = flightFeatherWear;
            WingLength = wingLength;
            BodyMass = bodyMass;
            NetNumber = netNumber;
        }
    }
}