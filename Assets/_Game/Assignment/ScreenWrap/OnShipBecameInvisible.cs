using UnityEngine;

namespace Assignment
{
    public class OnShipBecameInvisible : MonoBehaviour
    {
        [SerializeField] private ScriptableEventVector3 _onShipBecameInvisible;

        private void OnBecameInvisible()
        {
            Vector3 position = transform.position;
            _onShipBecameInvisible.Raise(position);
        }
    }
}

