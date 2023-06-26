using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
   
   
   
  [SerializeField] private float rotateSpeed;
    private float moveX;

     void Update()
     {
        moveX = Input.GetAxis("Mouse X");

        if(Input.GetMouseButton(0))
        {
           // transform.Rotate(transform.position.x, -moveX * rotateSpeed * Time.deltaTime , transform.position.z );
           Vector3 startRotation = transform.rotation.eulerAngles;
        Vector3 targetRotation = startRotation + new Vector3(0f, -moveX * rotateSpeed * Time.deltaTime, 0f);
        Quaternion targetQuaternion = Quaternion.Euler(targetRotation);

        transform.rotation = Quaternion.Lerp(transform.rotation, targetQuaternion, 1f);

        }

    

     }
}
