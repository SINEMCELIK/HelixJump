using UnityEngine;

public class Ring : MonoBehaviour
{

    [SerializeField] private Transform ball;
    private GameManager gm;

   private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(transform.position.y  >= ball.position.y)
        {
            Destroy(gameObject);
           gm.GameScore(25);
        }
    }
}
