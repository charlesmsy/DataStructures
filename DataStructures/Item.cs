using System;
namespace DataStructures
{
    class Item
    {
        private int key;
        Item next;

        public Item(int key)
        {
            this.key = key;
            next = null;
        }

        public int getKey()
        {
            return key;
        }
    }
}
