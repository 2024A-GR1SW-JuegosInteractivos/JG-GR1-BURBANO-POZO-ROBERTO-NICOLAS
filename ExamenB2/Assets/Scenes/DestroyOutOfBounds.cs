using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float lowerBound;

    void Start()
    {
        Camera cam = Camera.main;
        Vector3 screenBottom = cam.ScreenToWorldPoint(new Vector3(0, 0, cam.nearClipPlane));
        lowerBound = screenBottom.y;
    }

    void Update()
    {
        if (transform.position.y < lowerBound)
        {
            Destroy(gameObject);
        }
    }
}
