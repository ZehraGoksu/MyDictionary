using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
	class Dictionary<T,V>
	{
		T[] keys;
		V[] values;

		public Dictionary()
		{
			keys = new T[0];
			values = new V[0];
		}

		public void Add(T key, V value)
		{
			T[] tempkey = keys;
			V[] tempvalue = values;
			keys = new T[keys.Length+1];
			values = new V[values.Length + 1];
			

			for (int i = 0; i < tempkey.Length; i++)
			{
				keys[i] = tempkey[i];
				values[i] = tempvalue[i];
			}

			keys[keys.Length - 1] = key;
			values[values.Length - 1] = value;
		}

		public int Length { get { return keys.Length; } }

}
