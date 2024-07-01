using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject followObject;
    // Update is called once per frame
    void Start()
    {
    }
    void LateUpdate()
    {
        transform.position = followObject.transform.position + new Vector3(0,0,-3);        
    }
}
