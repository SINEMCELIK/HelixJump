using UnityEngine;

public class Ring : MonoBehaviour
{
    private GameManager gm;
    private Transform player;
    [SerializeField] private GameObject[] childRing;
  

    float radius = 200f;
    float force = 300f;

  

   private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        player = GameObject.FindGameObjectWithTag ("Player").transform;
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(transform.position.y  > player.position.y )
        {
            for(int i=0; i<childRing.Length; i++)
            {
                childRing[i].GetComponent<Rigidbody> ().isKinematic = false;
                childRing[i].GetComponent<Rigidbody> ().useGravity = true;

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
            gm.GameScore(25);
        }

    }
    
}

