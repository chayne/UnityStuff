using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		//transform.position += Vector3.right;
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.position += Vector3.right*Time.deltaTime;
	}
}
