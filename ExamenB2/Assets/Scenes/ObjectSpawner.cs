using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objects; 
    public float spawnRate = 1f; 

    private float nextSpawn = 0f;
    private float xMin, xMax;

    void Start()
    {
        Camera cam = Camera.main;
        Vector3 screenBounds = cam.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, cam.transform.position.z));
        xMin = -screenBounds.x;
        xMax = screenBounds.x;
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnObject();
        }
    }

    void SpawnObject()
    {
        float randomX = Random.Range(xMin, xMax);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, 0);
        Instantiate(objects[Random.Range(0, objects.Length)], spawnPosition, Quaternion.identity);
    }
}
