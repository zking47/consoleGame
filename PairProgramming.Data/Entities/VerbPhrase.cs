using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace PairProgramming.Data.Entities
{
    public class VerbPhrase 
    {
        string sentencePhrase=string.Empty;

        public  void PhraseGenerator(string sentenceVariable)
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
                sentencePhrase = $"She was too busy, and always {sentenceVariable} about what she wanted to do to actually do any of it.";
                break;
                case 1:
                sentencePhrase = $"My daily exercise is {sentenceVariable} after my school bus in the morning!";
                break;
                case 2:
                sentencePhrase = $"The quick brown fox is {sentenceVariable} on top of the lazy dog.";
                break;
                case 3:
                sentencePhrase = $"It was the first time he had ever seen someone {sentenceVariable} on an elephant.";
                break;
                case 4:
                sentencePhrase = $"In the end, he realized he could {sentenceVariable} sound and hear words.";
                break;
                default:
                sentencePhrase = "Consult your local developer, something went wrong.";
                break;
            }

            Console.WriteLine(sentencePhrase);
        }
    }
}