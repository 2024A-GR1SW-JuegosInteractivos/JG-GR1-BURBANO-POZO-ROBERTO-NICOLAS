using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float moveSpeed = 0.1f;

    [SerializeField] float slowSpeed = 2f;
    [SerializeField] float fastSpeed = 10f;


    void OnTriggerEnter2D(Collider2D other){
        if (other.tag == "Rapido"){    
            Debug.Log("Ir rapido");
            moveSpeed = fastSpeed;

        }
        if (other.tag == "Lento" ){
            Debug.Log("Ir lento");
            moveSpeed = slowSpeed;
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,moveAmount,0);
        transform.Rotate(0,0,-steerAmount);
    }
}
