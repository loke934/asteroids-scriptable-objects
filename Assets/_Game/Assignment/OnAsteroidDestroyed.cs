using System.Collections;
using Assignment;
using Asteroids;
using UnityEngine;

public class OnAsteroidDestroyed : MonoBehaviour
{
    [Header("Runtime Sets: ")]
    [SerializeField] private AsteroidRuntimeSet _asteroidRuntimeSet;

    [Header("Variables: ")] 
    [SerializeField, Range(0.4f,0.9f)] private float minSize = 0.8f;
    [SerializeField] private Vector3 smallScale = new Vector3(0.2f, 0.2f, 0.2f);
    [SerializeField, Range(1,3)] private int spawnAmountMin = 1;
    [SerializeField, Range(4,9)] private int spawnAmountMax = 9;
    [SerializeField, Range(1f,6f)] private float destroyAfterSeconds = 3;
    
    [Header("Prefabs: ")] 
    [SerializeField] private GameObject _asteroidPrefab;
    
    private int _instanceID;

    private void OnEnable( )
    {
        _instanceID = gameObject.GetInstanceID();
    }

    public void OnAsteroidHitByLaser(int asteroidID)
    {
        if (_instanceID == asteroidID)
        {
            Asteroid asteroid = _asteroidRuntimeSet.GetValue(asteroidID);
            if (asteroid.transform.localScale.x <= minSize)
            {
                Destroy(asteroid.gameObject);
            }
            else
            {
                SpawnSmallAsteroids();
                Destroy(asteroid.gameObject);
            }
        }
    }

    private void SpawnSmallAsteroids()
    {
        int spawnAmount = Random.Range(spawnAmountMin, spawnAmountMax);
        
        for (int i = 0; i < spawnAmount; i++)
        {
            GameObject smallAsteroid = Instantiate(_asteroidPrefab, transform.position, Quaternion.identity);
            smallAsteroid.transform.localScale = smallScale;
            smallAsteroid.GetComponent<OnAsteroidDestroyed>().StartCoroutine(SelfDestroy(smallAsteroid));
        }
    }

    private IEnumerator SelfDestroy(GameObject objectToDestroy)
    {
        yield return new WaitForSeconds(destroyAfterSeconds);
        Destroy(objectToDestroy);
    }
    
}
