using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderB : MonoBehaviour
{
    private bool hasPackage;
    [SerializeField] float delayDestroy = 0.5f;
    [SerializeField] Color32 hasPackageColor = new Color32(0,255,0,255);
    [SerializeField] Color32 hasNotPackageColor = new Color32(255,0,255,255);
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D other){
        Debug.Log("Ouch");
    }

    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Entrando en trigger");
        if (other.tag == "Paquete" && !hasPackage){        
            hasPackage = true;
            Debug.Log("Recogío paquete");
            spriteRenderer.color=hasPackageColor;
            Destroy(other.gameObject, delayDestroy);
        }
        if (other.tag == "Cliente" && hasPackage){
            Debug.Log("Dejo paquete");
            spriteRenderer.color=hasNotPackageColor;
            hasPackage = false;
        }
    }
}
