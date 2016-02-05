using UnityEngine;
using System.Collections;

public class ticket : MonoBehaviour {
	bool show=false;
	bool show1=true;
	bool show2=false;
	public Texture2D textureToDisplay;
	public Texture2D mapToDisplay;
	private Rect windowRect = new Rect(20, 20, 120, 50);
	private Rect windowRect2 = new Rect(570, 500, 120, 50);

	// Use this for initialization
	void Start () {
	
	}
	void OnMouseDown() {

		show = !show;

	}
	void update(){
		if(show)
			gameObject.SetActive (false);
			//Destroy(gameObject,.5f);
	}
	void DoMyWindow(int a) {
		if (GUILayout.Button ("Introduction")) {
			show1 = !show1;
			show2 = false;}

		if (GUILayout.Button ("Map")) {
			show2 = !show2;
			show1 = false;
		}
	}
	void DoMyWindow2(int b) {
		if (GUILayout.Button ("Got it")) {
			show1 = false;
			show2 = false;
		}
	}

	void OnGUI()
	{    if (show)
		{    windowRect = GUILayout.Window(2, windowRect, DoMyWindow,"Welcome");
			if (show1) {
				GUI.Label (new Rect (380, 40, textureToDisplay.width/2.0f , textureToDisplay.height/2.0f), textureToDisplay);
			    windowRect2 = GUILayout.Window(1, windowRect2,  DoMyWindow2,"");
				}
			if (show2) {
					GUI.Label (new Rect (380, 40, mapToDisplay.width*2.0f , mapToDisplay.height*2.0f), mapToDisplay);
				}
			}
		}
	

	// Update is called once per frame
	void Update () {
	
	}
}
