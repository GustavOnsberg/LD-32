using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour 
{
    public float speed = 5;
    Rigidbody2D rb;

	void Start ()		
	{
	    rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () 
	{
        transform.position = new Vector2(transform.position.x, transform.position.y-Time.deltaTime);
        rb.velocity = new Vector2(Mathf.Lerp(0, Input.GetAxis("Horizontal") * speed, 0.8f),
                                  Mathf.Lerp(0, Input.GetAxis("Vertical") * speed, 0.8f));
	}
}
