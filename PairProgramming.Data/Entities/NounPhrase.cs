using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PairProgramming.Data.Entities
{
    public class NounPhrase 
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
                sentencePhrase = $"What came first, the chicken or the {sentenceVariable}?";
                break;
                case 1:
                sentencePhrase = $"Be careful not to vacuum the {sentenceVariable} when you clean under your bed.";
                break;
                case 2:
                sentencePhrase = $"{sentenceVariable}s dont grow on trees, but cashews do.";
                break;
                case 3:
                sentencePhrase = $"Improve your {sentenceVariable}'s physical fitness by getting it a bicycle.";
                break;
                case 4:
                sentencePhrase = $"He found the end of the {sentenceVariable} and was surprised at what he found there.";
                break;
                default:
                sentencePhrase = "Consult your local developer, something went wrong.";
                break;
            }

            Console.WriteLine(sentencePhrase);
        }
    }
}