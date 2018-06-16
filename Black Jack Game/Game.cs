using System;
using System.Collections;
namespace Black_Jack_Game
{
    public class Game
    {
        ArrayList cardArray;

        public Game()
        {
            CreateDeck();
        }

        public void Round() {
            cardArray = ShuffleDeck(cardArray);

        }

        public Card DrawCard() {
            Card temp;
            temp = (Card) cardArray[(cardArray.Capacity)]; // retrieves the card-object from the end of the list (top of the deck)
            cardArray.RemoveAt(cardArray.Capacity); // removes the last object
            cardArray.Insert(0, temp); // places the card-object to the start of the list(bottom of the deck)

            return temp;
        }

        public void CreateDeck()
        {
            cardArray = new ArrayList();

            for (int i = 1; i <= 10; i++)
            {
                cardArray.Add(new Card(i, "../../Resources/Cards/S" + i + ".png"));
                cardArray.Add(new Card(i, "../../Resources/Cards/H" + i + ".png"));
                cardArray.Add(new Card(i, "../../Resources/Cards/C" + i + ".png"));
                cardArray.Add(new Card(i, "../../Resources/Cards/D" + i + ".png"));
            }
            for (int i = 11; i < 13; i++) { 
                cardArray.Add(new Card(10, "../../Resources/Cards/S" + i + ".png"));
                cardArray.Add(new Card(10, "../../Resources/Cards/H" + i + ".png"));
                cardArray.Add(new Card(10, "../../Resources/Cards/C" + i + ".png"));
                cardArray.Add(new Card(10, "../../Resources/Cards/D" + i + ".png"));

            }
            cardArray = ShuffleDeck(cardArray);
        }

        public ArrayList ShuffleDeck(ArrayList inputList) {
            ArrayList randomList = new ArrayList();

                Random r = new Random();
                int randomIndex = 0;
                while (inputList.Count > 0)
                {
                    randomIndex = r.Next(0, inputList.Count); //Choose a random object in the list
                    randomList.Add(inputList[randomIndex]); //add it to the new, random list
                    inputList.RemoveAt(randomIndex); //remove to avoid duplicates
                }

                return randomList; //return the new random list
            
        }


    }
}
