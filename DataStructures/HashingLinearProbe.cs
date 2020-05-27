using System;
namespace DataStructures
{
    public class HashingLinearProbe
    {
        private int tablesize;
        private Item[] hashtable;

        public HashingLinearProbe(int size)
        {
            tablesize = size;
            hashtable = new Item[size];
        }

        public int hashfunc(int key) {
            //fancy conversion code
            int hash = key * 1;
            return hash /*% tablesize // can mod tablesize, I did not use to save space*/;
        }

        public void insert(int key) {
            int hash = hashfunc(key);
            Item item = new Item(key);
            int i;

            for (i = 0; hashtable[(hash + i) % tablesize] != null; i++) {
                //This loop goes to an open index
            }

            hashtable[(hash + i) % tablesize] = item;
        }

        public void search(int key) {
            int hash = hashfunc(key);
            int i;

            for (i = 0; hashtable[(hash + i) % tablesize] != null; i++)
            {
                int keyofindex = hashtable[(hash + i) % tablesize].getKey();
                if (keyofindex == key)
                {
                    Console.WriteLine("Key {0} found in index {1}.", key, (hash + i) % tablesize);
                    break;
                }
                Console.WriteLine("Key {0} not found in index {1}.", key, (hash + i) % tablesize);
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
