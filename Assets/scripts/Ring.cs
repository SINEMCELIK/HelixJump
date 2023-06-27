using UnityEngine;

public class Ring : MonoBehaviour
{
    [SerializeField] private GameObject[] childRing;

    
    private Transform player;

    private float radius = 200f;
    private float force = 300f;


   private void Start()
    {
        player = GameObject.FindGameObjectWithTag ("Player").transform;

        
    }

    // Update is called once per frame
    private void Update()
    {
        
       

    }


    public void Explode()
    {         
        
      for(int i=0; i<childRing.Length; i++)
          {
            Rigidbody rd = gameObject.AddComponent<Rigidbody>();
            Rigidbody rbc =  childRing[i].GetComponent<Rigidbody> ();

            rbc.useGravity = true;

            Collider[] colliders = Physics.OverlapSphere(transform.position , radius);

            foreach(Collider newCollider in colliders) 
            {
                Rigidbody rb = newCollider.GetComponent<Rigidbody>();
                if(rb!=null){  rb.AddExplosionForce (force, transform.position ,radius); }
            }

                childRing[i].transform.parent =null;
                Destroy (childRing[i].gameObject,2f);
                Destroy (this.gameObject, 5f);
            }
        this.enabled =false;
       
        
      
    }

   
    
}

