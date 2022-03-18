using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdApp.Repository
{
    public class BirdRepository
    {
        List<Bird> _birdList = new List<Bird>(); // Stores fauxDB of birds.

        // AWW CRUD

        // CREATE A BIRD.
        public void AddBirdToList(Bird bird)
        {
            _birdList.Add(bird);
        }


        // READ ALL BIRDS.
        public List<Bird> GetAllBirds()
        {
            return _birdList;
        }


        // READ SINGLE BIRD.
        public Bird GetBirdFromListByBand(int userInputBandSearch)
        {
            foreach (Bird bird in _birdList)
            {
                if (bird.BandNumber == userInputBandSearch)
                {
                    return bird;
                }
            }

            return null;
        }


        // UPDATE BIRD
        public bool UpdateBird(Bird bird)
        {
            foreach (Bird existingBird in _birdList)
            {
                if (existingBird.BandNumber == bird.BandNumber)
                {
                    existingBird.BandNumber = bird.BandNumber;
                    existingBird.SpeciesName = bird.SpeciesName;
                    existingBird.BirdAge = bird.BirdAge;
                    existingBird.BodyMolt = bird.BodyMolt;
                    existingBird.FlightFeatherWear = bird.FlightFeatherWear;
                    existingBird.WingLength = bird.WingLength;
                    existingBird.BodyMass = bird.BodyMass;
                    existingBird.NetNumber = bird.NetNumber;

                    return true;
                }
            }

            return false;
        }

        // OVERLOADED METHOD??
        public bool UpdateBird(Bird bird, int bandNumber)
        {
            foreach (Bird existingBird in _birdList)
            {
                if (existingBird.BandNumber == bird.BandNumber)
                {
                    existingBird.BandNumber = bird.BandNumber;
                    existingBird.SpeciesName = bird.SpeciesName;
                    existingBird.BirdAge = bird.BirdAge;
                    existingBird.BodyMolt = bird.BodyMolt;
                    existingBird.FlightFeatherWear = bird.FlightFeatherWear;
                    existingBird.WingLength = bird.WingLength;
                    existingBird.BodyMass = bird.BodyMass;
                    existingBird.NetNumber = bird.NetNumber;

                    return true;
                }
            }

            return false;
        }


        // DELETE BIRD
        public bool DeleteBirdByBand(int bandNumber)
        {
            foreach (Bird tomato in _birdList)
            {
                if (tomato.BandNumber == bandNumber)
                {
                    _birdList.Remove(tomato);
                    return true;
                }
            }

            return false;
        }


        // SEED DATA
        public void SeedBirdData()
        {
            Bird one = new Bird(132476281, "Indigo Bunting", Age.Second_Year, false, false, 304, 15.0, 09);
            Bird two = new Bird(132476752, "American Robin", Age.After_Second_Year, true, false, 309, 16.2, 02);
            Bird three = new Bird(123746283, "Carolina Chickadee", Age.Second_Year, false, false, 299, 13.9, 01);
            Bird four = new Bird(132474526, "Tufted Titmouse", Age.Hatching_Year, true, false, 311, 16.7, 12);
            Bird five = new Bird(132476255, "Northern Cardinal", Age.After_Second_Year, true, true, 312, 16.9, 13);
            Bird six = new Bird(132477699, "Downy Woodpecker", Age.Second_Year, false, true, 305, 15.6, 08);
            Bird seven = new Bird(132477526, "Prothonotary Warbler", Age.Indeterminable, false, true, 303, 14.2, 02);
            Bird eight = new Bird(132485267, "Northern Cardinal", Age.Third_Year, true, true, 312, 16.4, 09);
            Bird nine = new Bird(123746259, "Blue Jay", Age.Second_Year, true, true, 314, 16.5, 03);
            Bird ten = new Bird(103522467, "Red-Headed Woodpecker", Age.After_Second_Year, false, true, 308, 15.2, 05);

            Bird[] birdArr = { one, two, three, four, five, six, seven, eight, nine, ten }; // Builds array of birds in Seed Data.

            foreach (Bird bird in birdArr) // Adds each bird in array of birds to list of birds. Birds.
            {
                AddBirdToList(bird);
            }
        }
    }
}