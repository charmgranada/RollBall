using UnityEngine;
using System.Collections;

public class DetectTouch : MonoBehaviour {

	
	void Update ()
	{
		//int i = 0;
		
		/*while(i < Input.touchCount)
		{
			if(Input.GetTouch(i).phase == TouchPhase.Began)
				Debug.Log("TOUCH BEGAN " + i);
			if(Input.GetTouch(i).phase == TouchPhase.Moved)
				Debug.Log("TOUCH MOVED " + i);
			if(Input.GetTouch(i).phase == TouchPhase.Stationary)
				Debug.Log("TOUCH STATIONARY " + i);
			if(Input.GetTouch(i).phase == TouchPhase.Ended)
				Debug.Log("TOUCH ENDED " + i);
			
			//Debug.Log(i);
			
			++i;
		}*/
		
		if(Input.touchCount > 0)
		{
			if(Input.GetTouch(1).phase == TouchPhase.Moved)
			{
				Vector2 deltaPos = Input.GetTouch(1).position;
				Debug.Log("Moved 2 fingers: " + deltaPos);
			}
		}
		
		/*int fingerCount = 0;
		foreach(Touch touch in Input.touches)
		{
			fingerCount++;
		}
		if(fingerCount > 0)
		{
			//Debug.Log(fingerCount);
		}*/
	}
}
