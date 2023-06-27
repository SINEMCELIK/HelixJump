using UnityEngine;

public class Camera : MonoBehaviour
{    
    
    [SerializeField] private Transform ball;
    [SerializeField] private float smoothSpeed;

    private Vector3 offset;
    
    
    // Start is called before the first frame update
     void Start()
    {
        offset =transform.position - ball.position;
    }

    // Update is called once per frame
     void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position,offset +ball.position, smoothSpeed);
        transform.position =newPos;
    }

}
