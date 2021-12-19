using DefaultNamespace.ScriptableEvents;
using UnityEngine;

namespace Assignment
{
    [CreateAssetMenu(fileName = "new Scriptable Event Vector3", menuName = "ScriptableObjects/ScriptableEvent-Vector3", order = 0)]
    public class ScriptableEventVector3 : ScriptableEvent<Vector3>
    {
        
    }
}