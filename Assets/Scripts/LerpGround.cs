using UnityEngine;
using System.Collections;

public class LerpGround : MonoBehaviour {
	
	private Vector3 toRight;
	private Vector3 toLeft;
	private Vector3 newPos;
	
	// Use this for initialization
	void Start () {
		
		toRight = new Vector3(5, 0, 0);
		toLeft = new Vector3(-5, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		MoveGround();
	}
	
	void MoveGround ()
	{
		if(Input.GetKeyUp(KeyCode.A))
		{
			newPos = toRight;
		}
		if(Input.GetKeyUp(KeyCode.D))
		{
			newPos = toLeft;
		}
		
		transform.position = Vector3.Lerp(transform.position, newPos, 10 * Time.deltaTime);
	}
}
