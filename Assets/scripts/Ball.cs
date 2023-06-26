using UnityEngine;

public class Ball : MonoBehaviour
{
     Rigidbody rd;
    [SerializeField]private float jumpForce;

    private int feverCount=0;
    private bool isFever;
 
    private void Start()
    {
       rd = GetComponent<Rigidbody> ();

      
    }
    private void OnTriggerEnter(Collider other) 

    {
        rd.velocity = Vector3.up * Time.deltaTime * jumpForce;
        feverCount=0;
        //string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
       // Debug.Log("Mataryal ad:"+metarialName);


       if(other.gameObject.CompareTag("empty"))
      {
         feverCount++;
       if(feverCount >= 3)
       {
        isFever = true;

       
       }
        if(other.gameObject.CompareTag ("safe"))
        {feverCount = 0;}
       
      }
      
     if (other.gameObject.CompareTag ("unsafe")){
      if(isFever=true)
      {
        return;
      }
        Debug.Log("unsafe");
        GameManager.gameOver = true;

        }
        else if (other.gameObject.CompareTag ("lastring")){
          GameManager.levelWin = true;
            
        }
    }


    
}
