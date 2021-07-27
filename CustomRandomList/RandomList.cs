using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random rnd;

        public RandomList()
            :base()
        {

        }

        public string RemoveRandomElement()
        {
            int index = rnd.Next(0, this.Count);
            string str = this[index];
            this.RemoveAt(index);
            return str;
        }
    }
}
