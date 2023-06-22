using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   
   
   
   public float rotateSpeed;
    private float moveX;

     void Update()
     {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))
        {
            transform.Rotate(transform.position.x, -moveX * rotateSpeed * Time.deltaTime , transform.position.z );

        }

    

     }
}
