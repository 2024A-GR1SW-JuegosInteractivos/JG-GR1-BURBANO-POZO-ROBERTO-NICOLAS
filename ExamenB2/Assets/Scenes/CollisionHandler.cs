using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    public int lives = 3;
    public string binType; 

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(binType))
        {
            Destroy(collision.gameObject);
        }
        else
        {
            lives--;
            Destroy(collision.gameObject);

            if (lives <= 0)
            {
                Debug.Log("Game Over");
            }
        }
    }
}
