using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Data.Entities
{
    public class AdjectivePhrase 
    {
          
        string sentencePhrase=string.Empty;

        public void PhraseGenerator(string sentenceVariable)
        {
            Random _random = new Random();
            int[] availablePhrases={
                0,
                1,
                2,
                3,
                4,

            };
            int randomNumber = _random.Next(0, availablePhrases.Length);

            switch (randomNumber)
            {
                case 0: 
                sentencePhrase = $"Flip-flops are a staple of any {sentenceVariable} summer wardrobe.";
                break;
                case 1:
                sentencePhrase = $"If you're going to challenge a couple to a chicken fight during spring break, make sure they're more {sentenceVariable} than you!";
                break;
                case 2:
                sentencePhrase = $"He dreamed of eating {sentenceVariable} apples with worms.";
                break;
                case 3:
                sentencePhrase = $"I made myself a {sentenceVariable} butter sandwhich, as i didn't want to subsist on just {sentenceVariable} crackers";
                break;
                case 4:
                sentencePhrase = $"He learned the important lesson that a picnic at the beach on a {sentenceVariable} day is a bad idea.";
                break;
                default:
                sentencePhrase = "Consult your local developer, something went wrong.";
                break;
            }

            Console.WriteLine(sentencePhrase);
        }
    }
}