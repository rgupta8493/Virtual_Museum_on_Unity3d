using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			print ("detected");//other.gameObject.SetActive (false);
			transform.Rotate (0, 180, 0);
		}
	}

	// Update is called once per frame
	void Update () {
		//if (Input.GetKeyDown ("q"))
			//transform.Rotate (0, 180, 0);
	}
}
