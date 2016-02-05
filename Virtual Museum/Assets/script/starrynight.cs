using UnityEngine;
using System.Collections;

public class starrynight : MonoBehaviour {

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
				GUI.Label (new Rect (380, 100, textureToDisplay.width/3.0f , textureToDisplay.height/3.0f), textureToDisplay);

				GUI.Label (new Rect (750, 110, 300, 10000), "The Starry Night is an oil on canvas by the Dutch post-impressionist painter Vincent van Gogh. Painted in June, 1889, it depicts the view from the east-facing window of his asylum room at Saint-Rémy-de-Provence, just before sunrise, with the addition of an idealized village. It has been in the permanent collection of the Museum of Modern Art in New York City since 1941, acquired through the Lillie P. Bliss Bequest. It is regarded as among Van Gogh's finest works, and is one of the most recognized paintings in the history of Western culture.\n\nAlthough The Starry Night was painted during the day in Van Gogh's ground-floor studio, it would be inaccurate to state that the picture was painted from memory. The view has been identified as the one from his bedroom window, facing east, a view which Van Gogh painted variations of no fewer than twenty-one times,including The Starry Night. \"Through the iron-barred window,\" he wrote to his brother, Theo, around 23 May 1889, \"I can see an enclosed square of wheat\"");
			}
			if (show2) {
				GUI.Label (new Rect (400, 100, painterToDisplay.width / 10.0f, painterToDisplay.height / 10.0f), painterToDisplay);

				GUI.Label (new Rect (700, 110, 300, 10000), "Vincent Willem van Gogh (Dutch: [ˈvɪnsɛnt ˈʋɪləm vɑn ˈɣɔx] ( listen);[note 1][1] (30 March 1853 – 29 July 1890) was a Dutch post-Impressionist painter whose work had far-reaching influence on 20th-century art. His paintings include portraits, self portraits, landscapes, still lifes, olive trees and cypresses, wheat fields and sunflowers. Van Gogh was born to upper middle class parents and spent his early adulthood working for a firm of art dealers before traveling to The Hague, London and Paris, after which he taught in England at Isleworth and Ramsgate. He drew as a child but did not paint until his late twenties; most of his best-known works were completed during the last two years of his life. In just over a decade, he produced more than 2,100 artworks, including 860 oil paintings and more than 1,300 watercolors, drawings, sketches and prints.\n\nAfter years of anxiety and frequent bouts of mental illness he died aged 37 from a self-inflicted gunshot wound. The extent to which his mental health affected his painting has been widely debated.");
			}
		}
	}
}