using UnityEngine;
using System.Collections;

public class EnemyControl : MonoBehaviour {

    public float moveSpeed;
    public bool moveRight;
    
        //Ground Check
	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask whatIsWall;
	private bool hittingWall;
        //EdgeCheck    
	private bool notAtEdge;
    public Transform edgeCheck;
	void Start () 
    {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
	 notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);
     hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);
        
        if (hittingWall || !notAtEdge)
        {
         moveRight = !moveRight;   
        }
        if (moveRight)
        {
        transform.localScale = new Vector3(-1.6f, 1.6f, 1.6f);
        GetComponent<Rigidbody2D>().velocity = new Vector2 (moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
        else
        {
        transform.localScale = new Vector3(1.6f, 1.6f, 1.6f);
        GetComponent<Rigidbody2D>().velocity = new Vector2 (-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
        }
	}
    
}
