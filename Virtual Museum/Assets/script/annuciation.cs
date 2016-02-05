using UnityEngine;
using System.Collections;

public class annuciation : MonoBehaviour {

	bool show=false;
	bool show1=false;
	bool show2=false;
	public Texture2D textureToDisplay;
	public Texture2D painterToDisplay;
	public Texture2D backgorund;
	RaycastHit hit;

	// Use this for initialization
	void Start () {

	}

	void OnMouseDown() {

		show = !show;

	}
	private Rect windowRect = new Rect(180, 200, 120, 50);

	void DoMyWindow(int windowID) {
		if (GUILayout.Button ("About the painting")) {
			show1 = !show1;
			show2 = false;}

		if (GUILayout.Button ("About the artist")) {
			show2 = !show2;
			show1 = false;
		}
	}

	void OnGUI() 
	{  
		if (show)
		{  windowRect = GUILayout.Window(3, windowRect, DoMyWindow, "Discription");
			if (show1) {
				GUI.Label (new Rect (400, 80, textureToDisplay.width /5.0f, textureToDisplay.height /5.0f), textureToDisplay);

				GUI.Label (new Rect (340, 350, 600, 1000), "This is a painting of the Biblical subject of the Annunciation, by the Italian Renaissance artists Leonardo da Vinci and Andrea del Verrocchio, dating from circa 1472–1475 and housed in the Uffizi gallery of Florence, Italy.\n\nThe subject matter is drawn from Luke 1.26-39 and depicts the angel Gabriel, sent by God to announce to a virgin, Mary, that she would miraculously conceive and give birth to a son, to be named Jesus, and to be called \"the Son of God\" whose reign would never end. The subject was very popular for artworks and had been depicted many times in the art of Florence, including several examples by the Early Renaissance painter Fra Angelico. The details of its commission and its early history remain obscure");
			}
			if (show2) {
				GUI.Label (new Rect (430, 70, painterToDisplay.width/3.0f , painterToDisplay.height/3.0f), painterToDisplay);

				GUI.Label (new Rect (700, 70, 300, 10000), "Leonardo di ser Piero da Vinci, more commonly Leonardo da Vinci (Italian: [leoˈnardo da (v)ˈvintʃi]; 15 April 1452 – 2 May 1519), was an Italian polymath whose areas of interest included invention, painting, sculpting, architecture, science, music, mathematics, engineering, literature, anatomy, geology, astronomy, botany, writing, history, and cartography. He has been variously called the father of paleontology, ichnology, and architecture, and is widely considered one of the greatest painters of all time.Sometimes credited with the inventions of the parachute, helicopter and tank, his genius epitomized the Renaissance humanist ideal.\n\nDespite the recent awareness and admiration of Leonardo as a scientist and inventor, for the better part of four hundred years his fame rested on his achievements as a painter and on a handful of works, either authenticated or attributed to him that have been regarded as among the masterpieces");
			}
		}
	}
}