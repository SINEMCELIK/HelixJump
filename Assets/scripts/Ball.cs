using UnityEngine;

public class Ball : MonoBehaviour
{
     Rigidbody rd;
    [SerializeField]private float jumpForce;

    
    private void Start()
    {
       rd = GetComponent<Rigidbody> ();
      
    }


    private void OnTriggerEnter(Collider other) 

    {
        rd.velocity = Vector3.up * Time.deltaTime * jumpForce;


        //string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
       // Debug.Log("Mataryal ad:"+metarialName);

    
     if (other.gameObject.CompareTag ("unsafe")){
        Debug.Log("unsafe");
        GameManager.gameOver = true;

        }
        else if (other.gameObject.CompareTag ("lastring")){
          GameManager.levelWin = true;
            
        }
    }
}
