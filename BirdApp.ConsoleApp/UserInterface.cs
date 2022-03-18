using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdApp.Repository;

namespace BirdApp.ConsoleApp
{
    public class UserInterface
    {
        bool isFlying = true; // bool that the entire UserInterface can see, turns app on/off.
        BirdRepository _repository = new BirdRepository();
        CustomConsole _console = new CustomConsole();

        public void Fly() // Run() method.
        {
            _repository.SeedBirdData();

            while (isFlying)
            {
                _console.PrintMainMenu();
                _console.EnterSelection();
                string input = GetUserInput();

                UserInputSwitchCase(input);
            }
        }

        private string GetUserInput()
        {
            return Console.ReadLine();
        }

        private void UserInputSwitchCase(string input)
        {
            switch(input)
            {
                case "1":
                    ViewAllBirds();
                    break;
                case "2":
                    ViewBird();
                    break;
                case "3":
                    CreateBird();
                    break;
                case "4":
                    EditBird();
                    break;
                case "5":
                    DeleteBird();
                    break;
                case "6":
                    isFlying = false;
                    ExitApplication();
                    break;
                default:
                    break;
            }
        }

        private void CreateBird()
        {
            _console.CreateNewBird();

            _console.BandNumber();
            int bandNumber = Convert.ToInt32(GetUserInput());

            _console.Species();
            string speciesName = GetUserInput();

            _console.AllAgeList();
            _console.SelectAge();

            string ageSelection = GetUserInput();

            Age birdAge = Age.Hatching_Year;

            switch (ageSelection)
            {
                case "1":
                    birdAge = Age.Hatching_Year;
                    break;
                case "2":
                    birdAge = Age.After_Hatching_Year;
                    break;
                case "3":
                    birdAge = Age.Second_Year;
                    break;
                case "4":
                    birdAge = Age.After_Second_Year;
                    break;
                case "5":
                    birdAge = Age.Third_Year;
                    break;
                case "6":
                    birdAge = Age.After_Third_Year;
                    break;
                case "7":
                    birdAge = Age.Indeterminable;
                    break;
                case "8":
                    birdAge = Age.Not_Attempted;
                    break;
                default:
                    break;
            }

            _console.Molting();
            string moltingSelection = GetUserInput();

            bool bodyMolt = true;

            switch (moltingSelection)
            {
                case "1":
                    bodyMolt = true;
                    break;
                case "2":
                    bodyMolt = false;
                    break;
                default:
                    break;
            }

            _console.FeatherWear();
            string featherWearSelection = GetUserInput();

            bool flightFeatherWear = true;

            switch (featherWearSelection)
            {
                case "1":
                    flightFeatherWear = true;
                    break;
                case "2":
                    flightFeatherWear = false;
                    break;
                default:
                    break;
            }

            _console.Wing();
            int wingLength = Convert.ToInt32(GetUserInput());

            _console.Mass();
            double bodyMass = Convert.ToInt32(GetUserInput());

            _console.Net();
            int netNumber = Convert.ToInt32(GetUserInput());

            Bird newBird = new Bird(bandNumber, speciesName, birdAge, bodyMolt, flightFeatherWear, wingLength, bodyMass, netNumber);

            _repository.AddBirdToList(newBird);
        }

        private void PrintBird(Bird bird)
        {
            _console.PrintABird(bird);
        }
        
        private void ViewAllBirds()
        {
            List<Bird> allBirds = _repository.GetAllBirds();

            foreach (Bird bird in allBirds)
            {
                PrintBird(bird);
            }

            _console.PressAnyKey();
            Console.ReadKey();
        }

        private void ViewBird()
        {
            _console.BandNumber();
            int bandNum = Convert.ToInt32(GetUserInput());

            Bird bird = _repository.GetBirdFromListByBand(bandNum);

            if (bird != null)
            {
                PrintBird(bird);
                _console.PressAnyKey();
            }
            else
            {
                _console.CouldntFindBird();
                _console.PressAnyKey();
            }

            Console.ReadKey();
        }

        private void EditBird()
        {
            _console.BirdToEdit();
            _console.BandNumber();
            int bandNum = Convert.ToInt32(Console.ReadLine());

            Bird bird = _repository.GetBirdFromListByBand(bandNum);

            if (bird != null)
            {
                PrintBird(bird);

                Console.WriteLine("NEW");
                _console.BandNumber();
                int bandNumber = Convert.ToInt32(GetUserInput());

                _console.Species();
                string speciesName = GetUserInput();

                _console.SelectAge();
                _console.AllAgeList();
                string ageSelection = GetUserInput();

                Age birdAge = Age.Hatching_Year;

                switch (ageSelection)
                {
                    case "1":
                        birdAge = Age.Hatching_Year;
                        break;
                    case "2":
                        birdAge = Age.After_Hatching_Year;
                        break;
                    case "3":
                        birdAge = Age.Second_Year;
                        break;
                    case "4":
                        birdAge = Age.After_Second_Year;
                        break;
                    case "5":
                        birdAge = Age.Third_Year;
                        break;
                    case "6":
                        birdAge = Age.After_Third_Year;
                        break;
                    case "7":
                        birdAge = Age.Indeterminable;
                        break;
                    case "8":
                        birdAge = Age.Not_Attempted;
                        break;
                    default:
                        break;
                }

                _console.Molting();
                string moltingSelection = GetUserInput();

                bool bodyMolt = true;

                switch (moltingSelection)
                {
                    case "1":
                        bodyMolt = true;
                        break;
                    case "2":
                        bodyMolt = false;
                        break;
                    default:
                        break;
                }

                _console.FeatherWear();
                string featherWearSelection = GetUserInput();

                bool flightFeatherWear = true;

                switch (featherWearSelection)
                {
                    case "1":
                        flightFeatherWear = true;
                        break;
                    case "2":
                        flightFeatherWear = false;
                        break;
                    default:
                        break;
                }

                _console.Wing();
                int wingLength = Convert.ToInt32(GetUserInput());

                _console.Mass();
                double bodyMass = Convert.ToInt32(GetUserInput());

                _console.Net();
                int netNumber = Convert.ToInt32(GetUserInput());

                Bird updatedBird = new Bird(bandNumber, speciesName, birdAge, bodyMolt, flightFeatherWear, wingLength, bodyMass, netNumber);

                if (updatedBird.BandNumber == bird.BandNumber)
                {
                    bool isSuccess = _repository.UpdateBird(updatedBird);
                    _console.SuccessUpdated(updatedBird);
                    _console.PressAnyKey();
                    Console.ReadKey();
                }
                else
                {
                    bool isSuccess = _repository.UpdateBird(updatedBird, bird.BandNumber);
                    _console.SuccessUpdated(updatedBird);
                    _console.PressAnyKey();
                    Console.ReadKey();
                }
            }
            else
            {
                _console.CouldntFindBird();
                _console.PressAnyKey();
                Console.ReadKey();
            }
        }

        private void DeleteBird()
        {
            _console.BirdToDelete();
            _console.BandNumber();
            int bandNum = Convert.ToInt32(Console.ReadLine());

            Bird birdToDelete = _repository.GetBirdFromListByBand(bandNum);

            bool isSuccess = _repository.DeleteBirdByBand(bandNum);

            if (isSuccess)
            {
                _console.SuccessDeleted(birdToDelete);
                _console.PressAnyKey();
                Console.ReadKey();
            }
            else
            {
                _console.CouldntFindBird();
                _console.PressAnyKey();
                Console.ReadKey();
            }
        }

        public void ExitApplication()
        {
            _console.ExitApplication();
            Console.ReadKey();
        }
    }
}