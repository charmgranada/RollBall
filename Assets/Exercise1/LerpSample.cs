using UnityEngine;
using System.Collections;

public class LerpSample : MonoBehaviour {
	
	private Color newColor;
	
	//private Color orig = gameObject.renderer.material.color;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		LerpGround();
		LerpColor();
	}
	
	void LerpColor ()
	{
		Color A = Color.blue;
		Color B = Color.red;
		
		if(Input.GetKeyDown(KeyCode.Z))
			newColor = A;
		if(Input.GetKeyDown(KeyCode.C))
			newColor = B;
		
		foreach(Transform child in gameObject.transform)
		{
			//Debug.Log(child);
			child.renderer.material.color = Color.Lerp(child.renderer.material.color, newColor, 10.0f * Time.deltaTime);
		}
	}
	
	void LerpGround ()
	{
		if(Input.GetKey(KeyCode.Q))
			transform.position = Vector3.Lerp(transform.position, new Vector3(5,0,0), Time.deltaTime);
		if(Input.GetKey(KeyCode.E))
			transform.position = Vector3.Lerp(transform.position, new Vector3(-5,0,0), Time.deltaTime);
	}
}
