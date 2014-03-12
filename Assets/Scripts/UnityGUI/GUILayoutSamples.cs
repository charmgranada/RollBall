using UnityEngine;
using System.Collections;

public class GUILayoutSamples : MonoBehaviour
{
	private float sliderValue = 1.0f;
	private float maxSliderValue = 10.0f;
	
	private float mySlider = 1.0f;
	
	public Color myColor;
	
	
	void OnGUI ()
	{
		//FixedLayout();
		
		//AutomaticLayout();
		
		//VertiHoriLayout();
		//VertiHoriLayout1();
		
		// Compound Controls
		//mySlider = LabelSlider (new Rect (10, 100, 100, 20), mySlider, 5.0f, "Label text here");
		
		// Static Compound Controls
		//myColor = RGBSlider (new Rect (10,10,200,10), myColor);
	}
	
	
	void FixedLayout ()
	{
		// Start: (0,0) topleft corner
		GUI.BeginGroup (new Rect (Screen.width / 2 - 50, Screen.height / 2 - 50, 100, 100));

		// We'll make a box so you can see where the group is on-screen.
		GUI.Box (new Rect (0,0,100,100), "Group is here");
		GUI.Button (new Rect (10,40,80,30), "Click me");

		// End the group we started above.
		GUI.EndGroup ();
	}
	
	void AutomaticLayout ()
	{
		GUILayout.Button ("I am not inside an Area");
		
		GUILayout.BeginArea (new Rect (Screen.width/2, Screen.height/2, 300, 300));
		GUILayout.Button ("I am completely inside an Area");
		GUILayout.EndArea ();
	}
	
	void VertiHoriLayout()
	{
		// Wrap everything in the designated GUI Area
		GUILayout.BeginArea (new Rect (0,0,200,60));

		// Begin the singular Horizontal Group
		GUILayout.BeginHorizontal();

		// Place a Button normally
		if (GUILayout.RepeatButton ("Increase max\nSlider Value"))
		{
			maxSliderValue += 3.0f * Time.deltaTime;
		}

		// Arrange two more Controls vertically beside the Button
		GUILayout.BeginVertical();
		GUILayout.Box("Slider Value: " + Mathf.Round(sliderValue));
		sliderValue = GUILayout.HorizontalSlider (sliderValue, 0.0f, maxSliderValue);

		// End the Groups and Area
		GUILayout.EndVertical();
		GUILayout.EndHorizontal();
		GUILayout.EndArea();
	}
	
	void VertiHoriLayout1 ()
	{
		// Wrap everything in the designated GUI Area
		GUILayout.BeginArea (new Rect (0,0,200,60));
		{
			// Begin the singular Horizontal Group
			GUILayout.BeginHorizontal();
			{
				// Place a Button normally
				if (GUILayout.RepeatButton ("Increase max\nSlider Value"))
				{
					maxSliderValue += 3.0f * Time.deltaTime;
				}
		
				// Arrange two more Controls vertically beside the Button
				GUILayout.BeginVertical();
				{
					GUILayout.Box("Slider Value: " + Mathf.Round(sliderValue));
					sliderValue = GUILayout.HorizontalSlider (sliderValue, 0.0f, maxSliderValue);
				}
				// End the Groups and Area
				GUILayout.EndVertical();
			}
			GUILayout.EndHorizontal();
		}
		GUILayout.EndArea();
	}
	
	// Compound Controls
	float LabelSlider (Rect screenRect, float sliderValue, float sliderMaxValue, string labelText)
	{
		// Created a Label
		GUI.Label (screenRect, labelText);

		// Push the Slider to the end of the Label
		screenRect.x += screenRect.width; 
		
		// Created a Horizontal Slider
		sliderValue = GUI.HorizontalSlider (screenRect, sliderValue, 0.0f, sliderMaxValue);
		
		// Will return a Label + Slider
		return sliderValue;
	}
	
	// NO: Static Compound Controls
	/*Color RGBSlider (Rect screenRect, Color rgb)
	 {
		rgb.r = GUI.HorizontalSlider (screenRect, rgb.r, 0.0f, 1.0f);

		// Move the next control down a bit to avoid overlapping
		screenRect.y += 20; 
		rgb.g = GUI.HorizontalSlider (screenRect, rgb.g, 0.0f, 1.0f);

		// Move the next control down a bit to avoid overlapping
		screenRect.y += 20; 

		rgb.b = GUI.HorizontalSlider (screenRect, rgb.b, 0.0f, 1.0f);
		
		return rgb;
	}*/
	
	
	// YES: Static Compound Controls
	// Call function from another: "GUIStaticCompound" script
	/*Color RGBSlider (Rect screenRect, Color rgb)
	 {
		rgb.r =  GUIStaticCompound.LabelSlider (screenRect, rgb.r, 1.0f, "Red");

		// Move the next control down a bit to avoid overlapping
		screenRect.y += 20; 
		rgb.g = GUIStaticCompound.LabelSlider (screenRect, rgb.g, 1.0f, "Green");

		// Move the next control down a bit to avoid overlapping
		screenRect.y += 20; 

		rgb.b = GUIStaticCompound.LabelSlider (screenRect, rgb.b, 1.0f, "Blue");

		return rgb;
	}*/
}
