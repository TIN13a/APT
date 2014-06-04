using UnityEngine;
using System.Collections;

public class CamaraMovement : MonoBehaviour {

	public float CameraPositionX;
	public float CameraPositionY;


	// Use this for initialization
	void Start () {
	
		CameraPositionX = this.transform.position.x;
		CameraPositionY = this.transform.position.y;

		Debug.Log (CameraPositionX);
		Debug.Log (CameraPositionY);
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey(KeyCode.W)) {
			this.transform.Translate (new Vector3 (CameraPositionX + 0.01f, 0.0f, CameraPositionY));
		}


	}
}
