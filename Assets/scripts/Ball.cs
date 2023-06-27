using UnityEngine;

public class Ball : MonoBehaviour
{
  [SerializeField]private float jumpForce;

  private GameManager gm;
  private Rigidbody rd;


  private int feverCount=0;
  private bool isFever;
  private bool isUp;
 



  private void Start()
  {
    rd = GetComponent<Rigidbody> ();
    gm= GameObject.FindObjectOfType<GameManager>();
  }




  private void OnCollisionEnter(Collision other) 
 {
    if(other.gameObject.CompareTag ("safe"))
    {
      rd.velocity = Vector3.up * Time.deltaTime * jumpForce;
      isUp=true;
     
    } 
    else if (other.gameObject.CompareTag ("unsafe"))
    {  
      Debug.Log("unsafe");
      GameManager.gameOver = true;

    }

    else if (other.gameObject.CompareTag ("lastring"))
    {
      GameManager.levelWin = true;
            
    }
    
  }
   private void OnTriggerEnter(Collider other) 
   {  
   if(other.gameObject.CompareTag("empty"))
    { 

      Debug.Log("empty");
      gm.GameScore(25);

      feverCount++;
      Debug.Log(feverCount);

      if(feverCount >= 3)
      {
        isFever = true; 
        Debug.Log("feverTRUE");
      }

      if(isUp)
      { 
         Debug.Log("platforma carpti");
        if(isFever)
        { 
          Debug.Log("FEVER COUNT 3");
          Ring ring =other.gameObject.GetComponentInParent<Ring>();
          ring.Explode();
        } 
        else feverCount = 0;
        Debug.Log("not enough");
      }  
      
    }
   }
        
}
