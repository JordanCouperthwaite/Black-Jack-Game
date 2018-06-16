using System;
namespace Black_Jack_Game
{
    public class Card
    {
        int value;
        string path;

        public Card(int value, string path)
        {
            this.value = value;
            this.path = path;
        }

        public int GetValue() {
            return value;
        }

        public string GetPath() {
            return path;
        }
    }
}
