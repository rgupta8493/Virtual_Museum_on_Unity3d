using UnityEngine;
using System.Collections;

public class triumphofvenus : MonoBehaviour {
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

	// Update is called once per frame
	//void Update () {

	//if (Physics.SphereCast (transform.position, 5.0f, Vector3.forward, out hit, 15.0f)) {
	//{
	//	print ("detected");
	//show = true;}
	//} else
	//		show = false;
	//}

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
				GUI.Label (new Rect (380, 80, textureToDisplay.width/2, textureToDisplay.height/2), textureToDisplay);

				GUI.Label (new Rect (340, 350, 600, 1000), "At the right, Venus, the goddess of love, rides in a processional chariot, assisted by blindfolded putti. Nymphs, satyrs, and other figures run, blow trumpets, or lie in languid poses on the ground. In the background, ghost-like figures swirl or lounge in front of an eerie landscape. Alessandro Magnasco painted his figures with nervous brushstrokes, adding an electric energy to the uninhibited revelry taking place amid elaborate ancient ruins. \n\nMagnasco probably painted this canvas and its pendant, Bacchanale, while in Milan early in his career. His collaborator Clemente Spera probably painted the architectural views.");
			}
			if (show2) {
				GUI.Label (new Rect (400, 100, painterToDisplay.width/2.5f , painterToDisplay.height/2.5f  ), painterToDisplay);

				GUI.Label (new Rect (700, 100, 300, 10000), "Alessandro Magnasco (February 4, 1667 – March 12, 1749), also known as il Lissandrino, was an Italian late-Baroque painter active mostly in Milan and Genoa. He is best known for stylized, fantastic, often phantasmagoric genre or landscape scenes.Born in Genoa to a minor artist, Stefano Magnasco, he apprenticed with Valerio Castello, and finally with Filippo Abbiati (1640–1715) in Milan. Except for 1703–09 (or 1709–11)[1] when working in Florence for the Grand Duke Cosimo III, Magnasco labored in Milan until 1735, when he returned to his native Genoa. Magnasco often collaborated with placing figures in the landscapes of Tavella and the ruins of Clemente Spera in Milan.");
			}
		}
	}
}