using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FCamera : MonoBehaviour
{
    [SerializeField] private GameObject followObject;
    // Update is called once per frame
    void Start()
    {
    }
    void LateUpdate()
    {
        transform.position = followObject.transform.position + new Vector3(0,0,-10);        
    }
}
