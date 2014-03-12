using UnityEngine;
using System.Collections;

public class DetectAccelerometer : MonoBehaviour
{
	private Vector3 acceleration = Vector3.zero;
	
	
	void Update ()
	{
		//TestAccel();
		
		
		// Input.acceleration
		//Debug.Log("acceleration: " + Input.acceleration);
		
		
		// List Acceleration Events
		//ListAccelEvents();
		
		
		// Get Acceleration Events
		GetAccelEvents();
		
		
		// Get Acceleration Events Count
		/*if(Input.accelerationEventCount == 0)
			Debug.Log("accelerationEventCount: " + Input.accelerationEventCount);*/
	}
	
	
	void ListAccelEvents ()
	{
		foreach (AccelerationEvent accEvent in Input.accelerationEvents)
		{
			acceleration += accEvent.acceleration * accEvent.deltaTime;
		}
		
		Debug.Log("acceleration from accEvent: " + acceleration);
	}
	
	
	void GetAccelEvents ()
	{
		Vector3 acceleration = Vector3.zero;
        int i = 0;
        while (i < Input.accelerationEventCount) {
            AccelerationEvent accEvent = Input.GetAccelerationEvent(i);
            acceleration += accEvent.acceleration * accEvent.deltaTime;
            ++i;
        }
		
        Debug.Log("GetAccelEvents: " + acceleration);
	}
	
	
	void TestAccel ()
	{
		if(Input.accelerationEventCount >= 2)
		{
			AccelerationEvent accEvent = Input.GetAccelerationEvent(0);
			AccelerationEvent accEvent1 = Input.GetAccelerationEvent(1);
			
			Vector3 newVector = accEvent.acceleration - accEvent1.acceleration;
			Debug.Log("TestAccel: " + newVector);
		}
	}
}
