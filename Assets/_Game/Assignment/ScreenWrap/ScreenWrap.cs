using System;
using UnityEngine;

namespace Assignment
{
    public class ScreenWrap : MonoBehaviour
    {
        [Header("Camera references: ")]
        [SerializeField] private Camera _mainCamera;
        
        private Vector3 viewportToWorldPoint;

        private void Awake()
        { 
            viewportToWorldPoint = _mainCamera.ViewportToWorldPoint(_mainCamera.transform.position);
        }

        public void OnShipBecameInvisible(Vector3 lastPosition)
        {
            Wrap(lastPosition);
        }
        
        private void Wrap(Vector3 lastPosition)
        {
            Vector3 wrappedPosition = lastPosition;
            
            if (lastPosition.x >= viewportToWorldPoint.x || lastPosition.x <= 0)
            {
                wrappedPosition.x = -wrappedPosition.x;
            }
            if (lastPosition.y >= viewportToWorldPoint.y  || lastPosition.y <= 0)
            {
                wrappedPosition.y = -wrappedPosition.y;
            }
            transform.position = wrappedPosition;
    
        }
    }
}

