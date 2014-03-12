using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	private int count;
	public GUIText countText;
	public GUIText winText;
	
	private Color newColour;
	private float smooth = 1.0f;
	
	private float timer = 60.0f;
	
	private float moveHorizontal;
	private float moveVertical;
	
	
	void Awake ()
	{
		Application.targetFrameRate = 60;
	}
	
	
	void Start ()
	{
		count = 0;
		
		SetCountText();
		winText.text = "timer: " + timer;
	}
	
	
	void Update ()
	{
		if(count < 10)
			CountDown();
	}
	
	
	void FixedUpdate ()
	{
        ColourChanging();
		
		if(Input.touchCount <= 0)
		{
			moveHorizontal = Input.GetAxis("Horizontal");
			moveVertical = Input.GetAxis("Vertical");
		}
		else
		{
			if(Input.GetTouch(0).phase == TouchPhase.Moved)
			{
				moveHorizontal = Input.GetTouch(0).deltaPosition.x * Time.deltaTime;
				moveVertical = Input.GetTouch(0).deltaPosition.y * Time.deltaTime;
			}
		}
		
		Debug.Log(moveHorizontal + ", " + moveVertical);
		
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		
		rigidbody.AddForce(movement * speed);
	}
	
	
	void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		
		if(count == 10)
		{
			winText.text = "YOU WIN!";
		}
	}
	
	
	void OnTriggerEnter(Collider collider)
	{	
		Debug.Log(collider.tag);
		
		if(collider.tag == "PickUp")
		{
			Destroy(collider.gameObject);
			count++;
			SetCountText();
			
			camera.clearFlags = CameraClearFlags.SolidColor;
		}
	}
	
	
    void ColourChanging ()
    {
        Color colourA = Color.red;
        Color colourB = Color.green;
        
        if(Input.GetKeyDown(KeyCode.Z))
		{
            newColour = colourA;
		}
		if(Input.GetKeyDown(KeyCode.C))
		{
			newColour = colourB;
		}
		
		renderer.material.color = Color.Lerp(renderer.material.color, newColour, smooth * Time.deltaTime);
    }
	
	
	void CountDown ()
	{
		float sub = timer - Time.time;
		int newT = (int)sub;
		winText.text = "" + newT;
		Debug.Log(newT);
	}
}