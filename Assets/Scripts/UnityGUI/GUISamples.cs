using UnityEngine;
using System.Collections;

public class GUISamples : MonoBehaviour
{
	public Texture2D icon;
	private string textFieldString = "textfield";
	private string textAreaString = "text area";
	private bool toggleBool = true;
	
	private int toolbarInt = 0;
	private string[] toolbarStrings = {"Toolbar1", "Toolbar2", "Toolbar3"};
	
	private int selectionGridInt = 0;
	private string[] selectionStrings = {"Grid 1", "Grid 2", "Grid 3", "Grid 4"};
	
	private float hSliderValue = 0.0f;
	private float vSliderValue = 0.0f;
	
	private float hScrollbarValue;
	private float vScrollbarValue;
	
	private Vector2 scrollViewVector = Vector2.zero;
	private string innerText = "I am inside the ScrollView";
	
	private Rect windowRect = new Rect (0, 0, 150, 50);
	private Rect windowRect1 = new Rect (50, 150, 220, 70);
	
	public GUIStyle customButton;
	public GUISkin mySkin;
	
	/*---- Type, Position, Content ----*/
	
	void OnGUI()
	{
		// Corners
		//CornerPositions();
		
		// text
		//GUI.Label (new Rect (0,0,150,50), "This is the text string for a Label Control");
		
		// texture2D
		//GUI.Label (new Rect (0,0,150,50), icon);
		
		// Content
		//GUI.Box (new Rect (10,10,100,50), new GUIContent("This is text", icon));
		
		//ToolTip();
		
		//Button();
		//RepeatButton();
		
		// textfield (input)
		//textFieldString = GUI.TextField (new Rect (25, 25, 100, 30), textFieldString);
		
		// text area
		//textAreaString = GUI.TextArea (new Rect (25, 25, 100, 30), textAreaString);
		
		// toggle button
		//toggleBool = GUI.Toggle (new Rect (25, 25, 100, 30), toggleBool, "Toggle");
		
		// toolbar
		//toolbarInt = GUI.Toolbar (new Rect (25, 25, 250, 30), toolbarInt, toolbarStrings);
		
		// selection grid
		//selectionGridInt = GUI.SelectionGrid (new Rect (25, 25, 300, 60), selectionGridInt, selectionStrings, 2);
		
		//Sliders();
		
		//ScrollBars();
		
		//ScrollView();
	
		// Window
		//windowRect = GUI.Window (0, windowRect, WindowFunction, "First Window");
		//windowRect1 = GUI.Window (1, windowRect1, WindowFunction, "Other Window");
		
		
		// GUI.Changed (uncomment toolbar...)
		// If the user clicked a new Toolbar button this frame, we'll process their input
		//if (GUI.changed)
			//Debug.Log("GUI CHANGED! The toolbar #" + (toolbarInt+1) + " was clicked");
		
		
		// GUI Style
		// Make a button. We pass in the GUIStyle defined above as the style to use
		//if(GUI.Button (new Rect (10,10,150,20), "I am a Custom Button", customButton))
			//Debug.Log("Clicked Custom Button");
		
		
		// GUI Skin
		// Assign the skin to be the one currently used.
		GUI.skin = mySkin;
		Button();
	}
	
	void CornerPositions ()
	{
		GUI.Box (new Rect (0,0,100,50), "Top-left");
		GUI.Box (new Rect (Screen.width - 100,0,100,50), "Top-right");
		GUI.Box (new Rect (0,Screen.height - 50,100,50), "Bottom-left");
		GUI.Box (new Rect (Screen.width - 100,Screen.height - 50,100,50), "Bottom-right");
	}

	void ToolTip ()
	{
		// This line feeds "This is the tooltip" into GUI.tooltip
		GUI.Button (new Rect (10,10,100,20), new GUIContent ("Click me", "This is the tooltip"));

		// This line reads and displays the contents of GUI.tooltip
		GUI.Label (new Rect (10,40,100,20), GUI.tooltip);
	}
	
	void Button ()
	{
		// Button
		if (GUI.Button (new Rect (25, 25, 100, 30), "Button")) {
			// This code is executed when the Button is clicked
			Debug.Log("Button is clicked!");
		}
	}
	
	void RepeatButton ()
	{
		// RepeatButton
		if (GUI.RepeatButton (new Rect (25, 25, 100, 30), "RepeatButton")) {
			// This code is executed every frame that the RepeatButton remains clicked
			Debug.Log("Repeat Button is still clicked!");
		}
	}

	void Sliders ()
	{
		// slider (horizontal/vertical)
		hSliderValue = GUI.HorizontalSlider (new Rect (50, 25, 100, 30), hSliderValue, 0.0f, 10.0f);
		
		vSliderValue = GUI.VerticalSlider (new Rect (25, 25, 30, 100), vSliderValue, 10.0f, 0.0f);
		
		
		Debug.Log("hSlider = " + hSliderValue + ", vSlider = " + vSliderValue);
	}

	void ScrollBars ()
	{
		// HorizontalScrollbar
		hScrollbarValue = GUI.HorizontalScrollbar (new Rect (50, 25, 100, 30), hScrollbarValue, 1.0f, 0.0f, 10.0f);
	
		// VerticalScrollbar
		vScrollbarValue = GUI. VerticalScrollbar (new Rect (25, 25, 100, 100), vScrollbarValue, 1.0f, 10.0f, 0.0f);
	
		
		Debug.Log("hScrollBar = " + hScrollbarValue + ", vScrollBar = " + vScrollbarValue);
	}
	
	void ScrollView ()
	{
		// Begin the ScrollView
		// ---1st: location and size of the viewable ScrollView area on the screen
		// ---2nd: the size of the space contained inside the viewable area
		scrollViewVector = GUI.BeginScrollView 
			(new Rect (25, 25, 100, 100), scrollViewVector,
			new Rect (0, 0, 400, 400));

		// Put something inside the ScrollView
		innerText = GUI.TextArea (new Rect (0, 0, 400, 400), innerText);

		// End the ScrollView
		GUI.EndScrollView();
	}
	
	void WindowFunction (int windowID) {
		// Draw any Controls inside the window here
		GUI.Label (new Rect (10,30,150,50), "WindowID: "+windowID);
	}
}
