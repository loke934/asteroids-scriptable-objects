using System.Collections.Generic;
using UnityEngine;

namespace Assignment
{
    [CreateAssetMenu(fileName = "new Runtime Set Asteroid", menuName = "ScriptableObjects/RuntimeSets-Asteroid", order = 0)]
    public class AsteroidRuntimeSet : ScriptableObject
    {
        private Dictionary<int, GameObject> _setDictionary;

        private void OnEnable()
        {
            _setDictionary = new Dictionary<int, GameObject>(); 
        }

        public void Add(int key, GameObject value)
        {
            if (!_setDictionary.ContainsKey(key))
            {
                _setDictionary.Add(key,value);
            }
        }

        public void Remove(int key, GameObject value)
        {
            if (_setDictionary.ContainsKey(key))
            {
                _setDictionary.Remove(key);
            }
        }
        
        public GameObject GetAsteroid(int key)
        {
            GameObject objectToReturn= _setDictionary[key];
            return objectToReturn;
        }

        // public Vector2 GetAsteroidLocalScale(int key)
        // {
        //     Vector2 localScale= _setDictionary[key].transform.localScale;
        //     return localScale;
        // }

    }
}