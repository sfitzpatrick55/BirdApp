using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdApp.Repository;

namespace BirdApp.ConsoleApp
{
    public class UserInterface
    {
        bool isRunning = true; // bool that the entire UserInterface can see, turns app on/off.
        BirdRepository _repository = new BirdRepository();
        // CustomConsole _console = new CustomConsole();

        public void Run() // Run() method.
        {
            _repository.SeedBirdData();

            while (isRunning)
            {
                _console.PrintMainMenu();
                _console.EnterSelection();
                string input = GetUserInput();

                
            }
        }
    }
}