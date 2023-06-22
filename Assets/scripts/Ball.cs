using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody rd;

    private GameManager gm;

    public float force;

    
    
    void Start()
    {
       gm= GameObject.FindObjectOfType<GameManager>();

        
    }

    private void OnCollisionEnter (Collision other) 
    {
        rd.AddForce(Vector3.up * force);
        string metarialName = other.gameObject.GetComponent<MeshRenderer>().material.name;
       // Debug.Log("Mataryal ad:"+metarialName);

    
     if (metarialName == "unsafe (Instance)"){
        Debug.Log("unsafe");
        gm.RestartGame();

        }
        else if (metarialName == "finish (Instance)"){
            Debug.Log("The End");
            
        }
      

}
}
