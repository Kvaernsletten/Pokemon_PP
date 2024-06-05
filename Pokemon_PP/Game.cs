using Pokemon_PP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_PP
{
    internal class Game
    {
        string input;
        Trainer trainer;
        public Random random = new Random();
        List<Pokemon> trainerPokemon = new List<Pokemon>();
        List<Pokemon> wildPokemon = new List<Pokemon>()
        {
            new Pokemon("Bulbasaur", 100, "Grass", 20),
            new Pokemon("Squirtle", 100, "Water", 20),
            new Pokemon("Charmander", 100, "Fire", 20),
            new Pokemon("Psyduck", 80, "Water", 15),
            new Pokemon("Poliwag", 60, "Water", 25),
            new Pokemon("Slowpoke", 120, "Water", 10),
            new Pokemon("Oddish", 80, "Grass", 15),
            new Pokemon("Paras", 60, "Grass", 25),
            new Pokemon("Bellsprout", 120, "Grass", 10),
        };
        public void Run()
        {
            Console.WriteLine("Halla, hva heter du?");
            input = Console.ReadLine();
            trainer = new Trainer(input);
            ChooseStarterPokemon();
        }



        public void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Du valgte " + trainerPokemon[0].Name);
                Console.WriteLine(trainer.Name + ", hva vil du gjøre nå?");
                Console.WriteLine("1. Start eventyret");
                Console.WriteLine("2. Sjekk ryggsekken");
                Console.WriteLine("3. Gå på butta");
                Console.WriteLine("4. Logg av");

                var userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        StartAdventure();
                        break;
                    case "2":
                        OpenBackpack();
                        break;
                    case "3":
                        GoShop();
                        break;
                    default:
                        System.Environment.Exit(0);
                        break;
                }
            }
        }

            

        public void ChooseStarterPokemon()
            {
            Console.Clear();
            Console.WriteLine(trainer.Name + ", hvilken pokemon vil du starte med?");
            Console.WriteLine("1. Bulbasaur");
            Console.WriteLine("2. Squirtle");
            Console.WriteLine("3. Charmander");
            input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                    trainerPokemon.Add(new Pokemon("Bulbasaur", 100, "Grass", 20));
                        MainMenu();
                    break;
                    case "2":
                    trainerPokemon.Add(new Pokemon("Squirtle", 100, "Water", 20));
                        MainMenu();
                    break;
                    case "3":
                    trainerPokemon.Add(new Pokemon("Charmander", 100, "Fire", 20));
                        MainMenu();
                        break;
                    default:
                    break;
                }
        }
        private void StartAdventure()
        {
            Console.Clear();
            bool inMenu = true;
            while (inMenu) 
            {
                Console.WriteLine("What terrain do u want to go to");
                Console.WriteLine("1. Hopp i buskene");
                Console.WriteLine("2. Ta deg en svømmetur");
                Console.WriteLine("3. Gå tilbake");

                Pokemon opponent = new Pokemon("Charizard", 500, "Fire", 100);
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        opponent = GetRandomPokemon("Grass");
                        break;
                        case "2":
                        opponent = GetRandomPokemon("Water");
                        break;
                    default:
                        inMenu = false;
                        break;
                }
                Battle(opponent);
            }
        }

        public Pokemon GetRandomPokemon(string type)
        {
            var possiblePokemon = wildPokemon.Where(pokemon => pokemon.Type == type).ToList();
            var index = random.Next(0, possiblePokemon.Count);
            return possiblePokemon[index];
        }

        public void Battle(Pokemon opponent)
        {
            bool inBattle = true;
            while (inBattle)
            {
                Console.WriteLine($"Du møtte på en vill {opponent.Name}, med {opponent.Health} HP");
                Console.WriteLine("Hva vil du gjøre?");
                Console.WriteLine("1. Angrip");
                Console.WriteLine("2. Kast pokeball");
                Console.WriteLine("3. Bytt pokemon");
                Console.WriteLine("4. Bruk item");
                Console.WriteLine("5. Stikk av");

                var menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    if(opponent.Health > trainerPokemon[0].Strenght)
                    {
                        opponent.Health -= trainerPokemon[0].Strenght;
                    }
                    else
                    {
                        Console.WriteLine(opponent.Name + " døde!");
                        input = Console.ReadLine();
                        StartAdventure();
                    }
                }
                else if (menuChoice == "2")
                {

                }
                else if (menuChoice == "3")
                {

                }
                else if (menuChoice == "4")
                {

                }
                else if (menuChoice == "5")
                {
                    StartAdventure();
                }
                else
                { }
            }

        }

            private void OpenBackpack()
            {
                throw new NotImplementedException();
            }
            private void GoShop()
            {
                throw new NotImplementedException();
            }
    }
}  
    

