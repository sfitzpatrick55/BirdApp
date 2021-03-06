using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirdApp.Repository;

namespace BirdApp.ConsoleApp
{
    public class CustomConsole
    {
        public void PrintMainMenu()
        {
            Console.WriteLine
            (
            "\nWelcome to the MAPS Bird Banding Console!\n" +
            "\n" +
            "Please select from the following options:\n" +
            "1. View all birds in the database.\n" +
            "2. Search bird by band number.\n" +
            "3. Add a new bird to the database.\n" +
            "4. Edit an existing bird in the database.\n" +
            "5. Delete a bird from the database.\n" +
            "6. Exit.\n"
            );
        }

        public void EnterSelection()
        {
            Console.WriteLine("Enter selection number: ");
        }

        public void CreateNewBird()
        {
            Console.WriteLine("\nCreate a NEW BIRD: ");
        }

        public void BandNumber()
        {
            Console.WriteLine("Band Number (9 digits): ");
        }

        public void Species()
        {
            Console.WriteLine("\nSpecies: ");
        }

        public void AllAgeList()
        {
            Console.WriteLine
            (
            "\nAge:\n" +
            "1. Hatching year\n" +
            "2. After hatching year\n" +
            "3. Second year\n" +
            "4. After second year\n" +
            "5. Third year\n" +
            "6. After third year\n" +
            "7. Indeterminable\n" +
            "8. Not attempted\n"
            );
        }
        public void SelectAge()
        {
            Console.WriteLine("Select age from above list: ");
        }

        public void Molting()
        {
            Console.WriteLine
            (
            "\nDoes bird show signs of body molt?\n" +
            "1. Yes\n" +
            "2. No\n"
            );
        }

        public void FeatherWear()
        {
            Console.WriteLine
            (
            "\nDoes bird show signs of flight feather wear?\n" +
            "1. Yes\n" +
            "2. No\n"
            );
        }

        public void Wing()
        {
            Console.WriteLine("\nLength of single wing (mm): ");
        }

        public void Mass()
        {
            Console.WriteLine("\nMass of bird (g): ");
        }

        public void Net()
        {
            Console.WriteLine("\nWhich net was bird retrieved from? (1-14): ");
        }


        public void PrintABird(Bird bird)
        {
            Console.WriteLine
            ("\n" +
            $"Band Number: {bird.BandNumber}\n" +
            $"Species: {bird.SpeciesName}\n" +
            $"Age: {bird.BirdAge}\n" +
            $"Body Molt: {bird.BodyMolt}\n" +
            $"Flight Feather Wear: {bird.FlightFeatherWear}\n" +
            $"Wing Length: {bird.WingLength}mm\n" +
            $"Body Mass: {bird.BodyMass}g\n" +
            $"Net Number: {bird.NetNumber}\n"
            );
        }

        public void PressAnyKey()
        {
            Console.WriteLine("Press any key to continue...");
        }

        public void CouldntFindBird()
        {
            Console.WriteLine("\nSorry, we could not find this bird in our database.");
        }
        public void SuccessAdded(Bird bird)
        {
            Console.WriteLine("\n" + $"Successfully added bird with band number {bird.BandNumber}");
        }

        public void BirdToEdit()
        {
            Console.WriteLine("\nEDIT a bird: ");
        }
        
        public void SuccessUpdated(Bird bird)
        {
            Console.WriteLine("\n" + $"Successfully updated bird with band number {bird.BandNumber}");
        }

        public void BirdToDelete()
        {
            Console.WriteLine("\nDELETE a bird: ");
        }

        public void SuccessDeleted(Bird bird)
        {
            Console.WriteLine("\n" + $"Successfully deleted bird with band number {bird.BandNumber}");
        }

        public void ExitApplication()
        {
            Console.WriteLine
            ("\n" +
            "Thank you visiting the MAPS Bird Banding Console!\n" +
            "Press any key to EXIT..."
            );
        }
    }
}