using UnityEngine;
using System.Collections;

public class lastdinner : MonoBehaviour {

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
		{  windowRect = GUILayout.Window(0, windowRect, DoMyWindow, "Discription");
			if (show1) {
				GUI.Label (new Rect (500, 40, textureToDisplay.width /5.0f, textureToDisplay.height /5.0f), textureToDisplay);
			
				GUI.Label (new Rect (1000, 50, 300, 10000), "The Last Supper is the final meal that, in the Gospel accounts, Jesus shared with his Apostles in Jerusalem before his crucifixion. The Last Supper is commemorated by Christians especially on Maundy Thursday.Moreover, the Last Supper provides the scriptural basis for the Eucharist, also known as \"Holy Communion\" or \"The Lord's Supper\".The First Epistle to the Corinthians contains the earliest known mention of the Last Supper. The four canonical Gospels all state that the Last Supper took place towards the end of the week, after Jesus' triumphal entry into Jerusalem and that Jesus and his Apostles shared a meal shortly before Jesus was crucified at the end of that week.During the meal Jesus predicts his betrayal by one of the Apostles present, and foretells that before the next morning, Peter will deny knowing him.");
			}
				if (show2) {
				GUI.Label (new Rect (400, 40, painterToDisplay.width/3.0f , painterToDisplay.height/3.0f), painterToDisplay);

					GUI.Label (new Rect (700, 50, 300, 10000), "Leonardo di ser Piero da Vinci, more commonly Leonardo da Vinci (Italian: [leoˈnardo da (v)ˈvintʃi]; 15 April 1452 – 2 May 1519), was an Italian polymath whose areas of interest included invention, painting, sculpting, architecture, science, music, mathematics, engineering, literature, anatomy, geology, astronomy, botany, writing, history, and cartography. He has been variously called the father of paleontology, ichnology, and architecture, and is widely considered one of the greatest painters of all time.Sometimes credited with the inventions of the parachute, helicopter and tank, his genius epitomized the Renaissance humanist ideal.\n\nDespite the recent awareness and admiration of Leonardo as a scientist and inventor, for the better part of four hundred years his fame rested on his achievements as a painter and on a handful of works, either authenticated or attributed to him that have been regarded as among the masterpieces");
		}
	}
}
}