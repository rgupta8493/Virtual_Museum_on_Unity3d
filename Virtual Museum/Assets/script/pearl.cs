using UnityEngine;
using System.Collections;

public class pearl : MonoBehaviour {
	
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
			GUI.Label (new Rect (400, 100, textureToDisplay.width / 8.0f, textureToDisplay.height / 3.0f), textureToDisplay);

			GUI.Label (new Rect (700, 110, 300, 10000), "Girl with a Pearl Earring (Dutch: Meisje met de parel) is an oil painting by 17th-century Dutch painter Johannes Vermeer. It is a tronie of a girl with a headscarf and a pearl earring. The painting has been in the collection of the Mauritshuis in The Hague since 1902.\n\nThe painting is a tronie, the Dutch 17th-century description of a 'head' that was not meant to be a portrait. It depicts a European girl wearing an exotic dress, an oriental turban, and an improbably large pearl earring.[1] In 2014, Dutch astrophysicist Vincent Icke raised doubts about the material of the earring and argued that it looks more like polished tin than pearl on the grounds of the specular reflection, the pear shape and the large size of the earring.\n\nThe work is oil on canvas and is 44.5 cm (17.5 in) high and 39 cm (15 in) wide. It is signed \"IVMeer\" but not dated. It is estimated to be painted around 1665.");
				}
		if (show2) {
			GUI.Label (new Rect (400, 100, painterToDisplay.width/4.0f , painterToDisplay.height/4.0f ), painterToDisplay);

				GUI.Label (new Rect (700, 110, 300, 10000), "Johannes, Jan or Johan Vermeer (/vərˈmɪər/; Dutch: [joːˈɦɑnəs jɑn vərˈmeːr]; 1632 – December 1675) was a Dutch painter who specialized in domestic interior scenes of middle-class life. Vermeer was a moderately successful provincial genre painter in his lifetime. He evidently was not wealthy, leaving his wife and children in debt at his death, perhaps because he produced relatively few paintings.\n\nVermeer worked slowly and with great care, and frequently used very expensive pigments. He is particularly renowned for his masterly treatment and use of light in his work.\n\nVermeer painted mostly domestic interior scenes. \"Almost all his paintings are apparently set in two smallish rooms in his house in Delft; they show the same furniture and decorations in various arrangements and they often portray the same people, mostly women.");
				}
	}
}

}