using UnityEngine;

using System.Collections;

public class sculpture1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}


	// Update is called once per frame
	void Update () {
		int layerMask = 1 << 8;
		layerMask = ~layerMask;

		if (Physics.CheckSphere(transform.position, 25.0f,layerMask))

			transform.Rotate (new Vector3(0,1,0) * Time.deltaTime*15.0f);

	}
}