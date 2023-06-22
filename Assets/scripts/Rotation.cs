using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotateSpeed;
    public float rotateSpeedAndroid;
    //private float moveX;

     void Update()
     {
       #if UNITY_EDITOR
        
        if(Input.GetMouseButton(0))
        {
           float moveX = Input.GetAxis("Mouse X");

            transform.Rotate (transform.position.x, -moveX * rotateSpeed * Time.deltaTime , transform.position.z);

        }

        #elif UNITY_ANDROID
       //moveX = Input.GetTouch("Mouse X");

        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            float xDeltaPos = Input.GetTouch (0).deltaPosition.x;
            transform.Rotate(transform.position.x, -xDeltaPos * rotateSpeedAndroid * Time.deltaTime , transform.position.z);

        }

        #endif

     }
}
