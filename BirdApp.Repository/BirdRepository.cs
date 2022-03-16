using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BirdApp.Repository
{
    public class BirdRepository
    {
        List<Bird> _birdList = new List<Bird>(); // Stores fauxDB of birds.

        // CRUD

        // CREATE A BIRD.





        // READ ALL BIRDS.
        public List<Bird> GetAllBirds()
        {
            return _birdList;
        }




        // SEARCH BIRD





        // SEED DATA
        public void SeedBirdData()
        {
            Bird one = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird two = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird three = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird four = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird five = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird six = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird seven = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird eight = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird nine = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);
            Bird ten = new Bird(001234567, "Cardinal", Age.Second_Year, false, true, 14, 30.5, 5);

            Bird[] birdArr = { one, two, three, four, five, six, seven, eight, nine, ten }; // Builds array of birds in Seed Data.

            foreach (Bird bird in birdArr) // Adds each bird in array of birds to list of birds. Birds.
            {
                AddBirdToList(bird);
            }
        }
    }
}