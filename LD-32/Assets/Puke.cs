using UnityEngine;
using System.Collections;

public class Puke : MonoBehaviour 
{
    public Vector2 mousePos;

	void Start ()
	{
	
	}
	
	void Update ()
	{
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(new Vector3(mousePos.x, mousePos.y, 0));
	}
}
