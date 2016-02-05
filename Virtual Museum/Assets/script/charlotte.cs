using UnityEngine;
using System.Collections;

public class charlotte : MonoBehaviour {

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
		{  windowRect = GUILayout.Window(4, windowRect, DoMyWindow, "Discription");
			if (show1) {
				GUI.Label (new Rect (400, 100, textureToDisplay.width/1.5f, textureToDisplay.height/1.5f ), textureToDisplay);

				GUI.Label (new Rect (800, 110, 300, 10000), "Charlotte Napoléone Bonaparte (31 October 1802 – 2 March 1839) was the daughter of Joseph Bonaparte, the older brother of Emperor Napoleon I, and Julie Clary. Her mother was the sister of Désirée Clary, Napoleon's first love. Charlotte married her first cousin Napoleon Louis, the second son of Louis Bonaparte and Hortense de Beauharnais. She studied engraving and lithography in Paris with the artist Louis Léopold Robert, who is reputed to have fallen in love with her.\n\nAfter her father was deposed in 1813 he moved to America and purchased \"Point Breeze\", an estate on the Delaware River near Bordentown, New Jersey. Bonaparte’s palatial house was filled with paintings and sculpture by such luminaries as Jacques-Louis David, Antonio Canova, Peter Paul Rubens, and Titian (Tiziano Vecelli). The surrounding park of 1,800 acres (7.3 km2) included landscaped gardens. Joseph Bonaparte played host to many of the national’s wealthiest and most cultivated citizens, and his art collection played a crucial role in transmitting high European taste to America.");
					}
			if (show2) {
				GUI.Label (new Rect (400, 100, painterToDisplay.width / 2.0f, painterToDisplay.height / 2.0f), painterToDisplay);

				GUI.Label (new Rect (700, 110, 300, 10000), "Jacques-Louis David (/ʒɑːkˈlwi ˈdɑːviːd/; French: [ʒak lwi david]; 30 August 1748 – 29 December 1825) was an influential French painter in the Neoclassical style, considered to be the preeminent painter of the era. In the 1780s his cerebral brand of history painting marked a change in taste away from Rococo frivolity toward a classical austerity and severity, heightened feeling[1] harmonizing with the moral climate of the final years of the Ancien Régime.\n\nDavid later became an active supporter of the French Revolution and friend of Maximilien Robespierre (1758–1794), and was effectively a dictator of the arts under the French Republic. Imprisoned after Robespierre's fall from power, he aligned himself with yet another political regime upon his release: that of Napoleon, The First Consul of France. At this time he developed his Empire style, notable for its use of warm Venetian colours. After Napoleon's fall from Imperial power and the Bourbon revival, David exiled himself to Brussels, then in the United Kingdom of the Netherlands, where he remained until his death.");
			}
		}
	}
}
