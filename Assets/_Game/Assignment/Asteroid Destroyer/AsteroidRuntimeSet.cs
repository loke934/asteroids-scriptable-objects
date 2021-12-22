using System.Collections.Generic;
using Asteroids;
using UnityEngine;

namespace Assignment
{
    [CreateAssetMenu(fileName = "new Runtime Set Asteroid", menuName = "ScriptableObjects/RuntimeSets-Asteroid", order = 0)]
    public class AsteroidRuntimeSet : RuntimeSet<int, Asteroid>
    {
        
    }
}