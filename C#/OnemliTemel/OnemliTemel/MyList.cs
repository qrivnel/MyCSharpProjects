using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnemliTemel
{
    internal class MyList
    {
        string[] texts = new string[0];
        public MyList(params string[] texts)
        {
            this.texts = new string[texts.Length];
            for (int i = 0; i < texts.Length; i++)
            {
                this.texts[i] = texts[i];
            }
        }

        public void Add(string newText)
        {
            int length = texts.Length;
            string[] tempTexts = new string[length];
            for (int i = 0; i < length; i++) tempTexts[i] = texts[i];
            texts = new string[length + 1];
            for (int i = 0; i < length; i++) texts[i] = tempTexts[i];
            texts[length] = newText;
        }

        public string Show(int id) { return texts[id]; }

        public int Lenght() { return texts.Length; }
    }
}
