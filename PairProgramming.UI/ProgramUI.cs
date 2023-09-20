using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using PairProgramming.Data.Entities;
using PairProgramming.Repository.ProjectItemRepository;
using static System.Console;
namespace PairProgramming.UI
{
 
    public class ProgramUI
    {

           private readonly PhraseRepo _phraseRepo = new PhraseRepo();
            VerbPhrase _verbPhrase;
            NounPhrase _nounPhrase;
            AdjectivePhrase _adjectivePhrase;
            public ProgramUI()
            {
                _verbPhrase = new VerbPhrase();
                _adjectivePhrase = new AdjectivePhrase();
                _nounPhrase = new NounPhrase();
            }
        public void Run()
        {
            RunApplication();
        }
        private void RunApplication()
        {
            bool isRunning = true;
            while(isRunning)
            {
                Clear();
                System.Console.WriteLine(
                "Console Mad Libs\n"+
                "Please Choose a Word Type to Insert\n"+
                "1. Verb\n"+
                "2. Noun\n"+
                "3. Adjective\n"+
                "4. Exit\n");
                string userInput = ReadLine()!;

                switch(userInput)
                {
                    case "1":
                    VerbWord();
                    break;
                    case "2":
                    NounWord();
                    break;
                    case "3":
                    AdjectiveWord();
                    break;
                    case "4":
                    isRunning = ExitApplication();
                    break;
                    default:
                    WriteLine("Invalid Selection, please press any key and then choose again.");
                    ReadKey();
                    break;
                }
                
            }
        }

        private void AdjectiveWord()
        {
              Clear();
            WriteLine("Please enter a Adjective. ");
            string userInput = ReadLine()!;
           Clear();
            _adjectivePhrase.PhraseGenerator(userInput);
            WriteLine("Press any key to continue:");
            ReadKey();
        }

        private void NounWord()
        {
             Clear();
            WriteLine("Please enter a Noun. ");
            string userInput = ReadLine()!;
          Clear();
            _nounPhrase.PhraseGenerator(userInput); 
            WriteLine("Press any key to continue:");
            ReadKey();
        }

        private void VerbWord()
        {   
            Clear();
            WriteLine("Please enter a Verb that ends in 'ing.' ");
            string userInput = ReadLine()!;
           Clear();
            _verbPhrase.PhraseGenerator(userInput);
            WriteLine("Press any key to continue:");
            ReadKey();
        }

        private bool ExitApplication()
        {
            Clear();
            WriteLine("Thanks for playing. Press any Key to Exit");
            ReadKey();
            return false;
        }


    }

}