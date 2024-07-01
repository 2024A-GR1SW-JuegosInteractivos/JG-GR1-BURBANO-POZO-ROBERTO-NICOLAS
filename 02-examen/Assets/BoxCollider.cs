using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxCollider : MonoBehaviour
{
    [SerializeField] float delayDestroy = 0.5f;
    public int boxFound = 0;

    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "box" ){        
            Debug.Log("Part found");
            boxFound+=1;
            Destroy(other.gameObject, delayDestroy);
        }
    }
}
