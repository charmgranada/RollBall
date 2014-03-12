using UnityEngine;
using System.Collections;

public class DisplayPickup : MonoBehaviour {
	
	public GameObject pickUpObject;
	
	private float xPosition = 1.5f;
	private float zPosition = -1.5f;
	private int radius = 10;
	private int angle = 360;
	
	// Use this for initialization
	void Start () {
		
		
		/*for(int i=0; i<12; i++){
			
			Vector3 newVector = RandomCircle(pickUpObject.transform.position, radius, i);
			Debug.Log(newVector);
			
			Instantiate(pickUpObject, newVector, Quaternion.identity);
			//Instantiate(pickUpObject, new Vector3(xPosition*i,0.5f, zPosition*i), Quaternion.identity);
			
		}*/
		
		//int sample = (int)(radius * Mathf.Sin(360 * Mathf.Deg2Rad));
		//Debug.Log(Mathf.Deg2Rad);
		
	}
	
	Vector3 RandomCircle(Vector3 center, float radiusValue, int i) {
		
	    /*xPosition = center.x * i + radiusValue * Mathf.Sin(angle * Mathf.Deg2Rad);
	    zPosition = center.z + radiusValue * i * Mathf.Cos(angle * Mathf.Deg2Rad);
		
		Vector3 pos = new Vector3(xPosition, 0.5f, zPosition);
		
	    return pos;*/
		return Vector3.zero;
	}
}
