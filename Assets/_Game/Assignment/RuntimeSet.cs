using System.Collections.Generic;
using Asteroids;
using UnityEngine;

namespace Assignment
{
    public abstract class RuntimeSet<TKey, TValue> : ScriptableObject
    {
        private Dictionary<TKey, TValue> _setDictionary;

        private void OnEnable()
        {
            _setDictionary = new Dictionary<TKey, TValue>();
        }

        public void Add(TKey key, TValue value)
        {
            if (!_setDictionary.ContainsKey(key))
            {
                _setDictionary.Add(key, value);
            }
        }

        public void Remove(TKey key)
        {
            if (_setDictionary.ContainsKey(key))
            {
                _setDictionary.Remove(key);
            }
        }
        
        public TValue GetValue(TKey key)
        {
            TValue valueToReturn= _setDictionary[key];
            return valueToReturn;
        }
    }
}