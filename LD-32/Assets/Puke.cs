using UnityEngine;
using System.Collections;

public class Puke : MonoBehaviour 
{
    Vector2 mousePos;

	void Start ()
	{
	
	}
	
	void Update () 
	{
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.LookAt(mousePos);
	}
}
