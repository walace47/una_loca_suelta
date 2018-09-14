using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour {
	float speed = 1.5f;
	
	// Use this for initialization
	void Start () {
		Rigidbody2D rbala;
		Transform trans;
		Vector2 vect2;
		
		trans = GetComponent<Transform>();
		rbala = GetComponent<Rigidbody2D>();

		Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		Vector2 vect = new Vector2(mousePos.x,mousePos.y);
		vect = vect.normalized;
		//Debug.Log("X: "+mousePos.x+" Y: "+mousePos.y);
		//rbala.velocity= vect;
		/*vect2 = mousePos.normalized;
		float deltaY = vect2.y;
		float deltaX = vect2.x;
		float angleInDegrees = Mathf.Atan2 (-deltaY, deltaX) *  Mathf.Rad2Deg;// * 180 / Mathf.PI;
		Debug.Log(angleInDegrees);
		trans.eulerAngles = new Vector3 (0, 0, -angleInDegrees);*/
	}
	
	// Update is called once per frame
	void Update () {
		//transform.Translate(transform.forward*speed,Space.World);
	}
}
