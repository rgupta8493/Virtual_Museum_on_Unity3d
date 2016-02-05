using UnityEngine;
using System.Collections;

public class monalisa : MonoBehaviour {
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
	void update()
	{if (Physics.Raycast (transform.position, Vector3.forward, 10.0f)) {
			print ("detected");
			show = true;
		}
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
		{  windowRect = GUILayout.Window(0, windowRect, DoMyWindow, "Discription");
			if (show1) {
				GUI.Label (new Rect (400, 40, textureToDisplay.width * 10.0f, textureToDisplay.height * 4.0f), textureToDisplay);

				GUI.Label (new Rect (700, 50, 300, 10000), "The Mona Lisa (/ˌmoʊnə ˈliːsə/; Italian: Monna Lisa [ˈmɔnna ˈliːza] or La Gioconda [la dʒoˈkonda], French: La Joconde [la ʒɔkɔ̃d]) is a half-length portrait of a woman by the Italian artist Leonardo da Vinci, which has been acclaimed as the \"best known, the most visited, the most written about, the most sung about, the most parodied work of art in the world\".\n\nThe painting, thought to be a portrait of Lisa Gherardini, the wife of Francesco del Giocondo, is in oil on a white Lombardy poplar panel, and is believed to have been painted between 1503 and 1506. Leonardo may have continued working on it as late as 1517. It was acquired by King Francis I of France and is now the property of the French Republic, on permanent display at the Louvre Museum in Paris since 1797.[2]\n\nThe subject's expression, which is frequently described as enigmatic,[3] the monumentality of the composition, the subtle modeling of forms, and the atmospheric illusionism were novel qualities that have contributed to the continuing fascination and study of the work");
			}
			if (show2) {
				GUI.Label (new Rect (430, 70, painterToDisplay.width/3.0f , painterToDisplay.height/3.0f), painterToDisplay);

				GUI.Label (new Rect (700, 70, 300, 10000), "Leonardo di ser Piero da Vinci, more commonly Leonardo da Vinci (Italian: [leoˈnardo da (v)ˈvintʃi]; 15 April 1452 – 2 May 1519), was an Italian polymath whose areas of interest included invention, painting, sculpting, architecture, science, music, mathematics, engineering, literature, anatomy, geology, astronomy, botany, writing, history, and cartography. He has been variously called the father of paleontology, ichnology, and architecture, and is widely considered one of the greatest painters of all time.Sometimes credited with the inventions of the parachute, helicopter and tank, his genius epitomized the Renaissance humanist ideal.\n\nDespite the recent awareness and admiration of Leonardo as a scientist and inventor, for the better part of four hundred years his fame rested on his achievements as a painter and on a handful of works, either authenticated or attributed to him that have been regarded as among the masterpieces");
			}
		}
	}
}