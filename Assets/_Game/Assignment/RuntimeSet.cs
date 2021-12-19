using System.Collections.Generic;
using Asteroids;
using UnityEngine;

namespace Assignment
{
    public abstract class RuntimeSet<T> : ScriptableObject
    {
        private Dictionary<T,T> _setDictionary;

        private void Awake()
        {
            _setDictionary = new Dictionary<T,T>();
        }

        public virtual void Add(T key, T value)
        {
            if (!_setDictionary.ContainsKey(key))
            {
                _setDictionary.Add(key,value);
            }
            
        }

        public virtual void Remove(T key, T value)
        {
            if (_setDictionary.ContainsKey(key))
            {
                _setDictionary.Remove(key);
            }
        }

    }
    
   
}