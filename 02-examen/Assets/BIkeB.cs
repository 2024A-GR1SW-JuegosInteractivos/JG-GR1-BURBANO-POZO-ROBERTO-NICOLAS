using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BIke : MonoBehaviour
{
    [SerializeField] float steerSpeed = 0.1f;
    [SerializeField] float speed = 0;
    public float maxSpeed = 10f;
    public float minSpeed = 0f; 
    [SerializeField] float velocityIncrement = 0.001f; 
    private bool gameOver;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (speed<maxSpeed){
                speed += velocityIncrement;
            }
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            speed -=velocityIncrement * 2;
        }
        if (speed>0){
            speed -= velocityIncrement*0.01f;
        }
        if (speed<0){
            speed = 0;
        }
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = speed * Time.deltaTime;
        transform.Translate(0,moveAmount,0);
        transform.Rotate(0,0,-steerAmount);
    }


    void OnTriggerEnter2D(Collider2D other){
        Debug.Log(other.tag); 
        if (other.tag == "building" && speed>5){    
            gameOver=true;
            Debug.Log("Game Loss"); 
        }
        if (other.tag == "tree" && speed>3){    
            gameOver=true;
            Debug.Log("Game Loss"); 
        }
        if (other.tag == "person" && speed>1){    
            gameOver=true;
            Debug.Log("Game Loss"); 
        }
        if (other.tag == "vehicle" && speed>2){    
            gameOver=true;
            Debug.Log("Game Loss"); 
        }
        if (other.tag == "water"){    
            gameOver=true;
            Debug.Log("Game Loss"); 
        }
        speed = 0;
    }
}
