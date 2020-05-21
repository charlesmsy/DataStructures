using System;
namespace DataStructures
{
    public class DoubleHashing
    {
        private int tablesize;
        private Item[] hashtable;

        public DoubleHashing(int size)
        {
            tablesize = size;
            hashtable = new Item[size];
        }

        public int hashfunc(int key)
        {
            //fancy conversion code
            int hash = key * 1;
            return hash;
        }

        public int hashfunc2(int key)
        {
            //fancy conversion 2
            int hash = key * 33;
            return hash;
        }

        public void insert(int key)
        {
            int hash = hashfunc(key);
            int hash2 = hashfunc2(key);
            Item item = new Item(key);
            int i;

            for (i = 0; hashtable[(hash + (i * hash2)) % tablesize] != null; i++)
            {
                //This loop goes to an open index
            }

            hashtable[(hash + (i * hash2)) % tablesize] = item;
        }

        public void search(int key)
        {
            int hash = hashfunc(key);
            int hash2 = hashfunc2(key);
            int i;

            for (i = 0; hashtable[(hash + (i * hash2)) % tablesize] != null; i++)
            {
                int keyofindex = hashtable[(hash + (i * hash2)) % tablesize].getKey();
                if (keyofindex == key)
                {
                    Console.WriteLine("Key {0} found in index {1}.", key, (hash + (i * hash2)) % tablesize);
                    break;
                }
                Console.WriteLine("Key {0} not found in index {1}.", key, (hash + (i * hash2)) % tablesize);
            }
        }

        public void print()
        {
            Console.WriteLine("HashTable output:");
            Console.WriteLine("Index   Key");

            for (int i = 0; i < tablesize; i++)
            {
                if (hashtable[i] != null)
                {
                    Console.WriteLine(i + "       " + hashtable[i].getKey());
                }
            }
        }

    }

}
