using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Dictionary<Tkey, Tval>
    {
        public int Counter { set; get; } = 0;
        private Tkey[] keys = null;
        private Tval[] values = null;

        public void Add(Tkey key, Tval val)
        {
            Counter++;
            Array.Resize(ref keys, Counter);
            keys[Counter - 1] = key;

            Array.Resize(ref values, Counter);
            values[Counter - 1] = val;
        }

        public bool ContainsKey(Tkey key)
        {
            if (keys.Contains(key))
                return true;
            else
                return false;
        }

        public bool ContainsValue(Tval val)
        {
            if (values.Contains(val))
                return true;
            else
                return false;
        }

        public void Remove(Tkey key)
        {
            if(ContainsKey(key))
            {
                for(int i = 0; i < keys.Length; i++)
                {
                    if(key.Equals(keys[i]))
                    {
                        int j = i;
                        while(j < keys.Length)
                        {
                            if(j == keys.Length - 1)
                            {
                                keys[j] = default;
                                values[j] = default;
                            }
                            else
                            {
                                keys[j] = keys[j + 1];
                                values[j] = values[j + 1];
                            }
                            j++;
                        }
                        Counter--;
                        Array.Resize(ref keys, Counter);
                        Array.Resize(ref values, Counter);
                    }
                }
            }
            else
            {
                Console.WriteLine("The key was not found");
            }
        }

        public void Clear()
        {
            keys = null;
            values = null;
            Counter = 0;
        }

        public void Display()
        {
            if(Counter != 0)
            {
                for (int i = 0; i < Counter; i++)
                {
                    Console.WriteLine($"{keys[i]}  -  {values[i]}");
                }
            }
            else
            {
                Console.WriteLine("The dictionary is empty");
            }
        }
    }
}
