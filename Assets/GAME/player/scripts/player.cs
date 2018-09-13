﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    private Rigidbody2D rb;
    public int fuerza;
    public int velocidad;
    private Transform trans;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody2D>();
		trans = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
        //Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
        //float angulo=Mathf.Atan2(mousePos.x, mousePos.y);
        //angulo = angulo /  Mathf.Deg2Rad;
        
        
        Vector3 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		//mousePos.y = trans.position.y;
		//mousePointer.trans.position = mousePos;
		float deltaY = mousePos.y - trans.position.y;
		float deltaX = mousePos.x - trans.position.x;
		float angleInDegrees = Mathf.Atan2 (-deltaY, deltaX) * 180 / Mathf.PI;
		trans.eulerAngles = new Vector3 (0, 0, -angleInDegrees);
		
        //float angulo =Vector3.Angle(new Vector3(0,0,0),mousePos); 
        //Debug.Log(mousePos.y);
        //Debug.Log(angulo);
        //trans.rotation = new Quaternion(0, 0 , angulo , 0);; 
        //rotacion.z =mousePos.z;
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0) {
			Vector2 vector = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
            float inputHorizontal = Input.GetAxis ("Horizontal");
            float inputVertical = Input.GetAxis ("Vertical");
	
            Vector3 newVelocity=new Vector3(inputHorizontal*velocidad,inputVertical*velocidad,0.0f );
            rb.velocity = newVelocity;
			//rb.AddForce(vector * fuerza);
			//rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -velocidad, velocidad), Mathf.Clamp(rb.velocity.y, -velocidad, velocidad));

			//transform.position = new Vector2(Mathf.Clamp(transform.position.x, -7.195f, 7.195f), transform.position.y);
		}
		else {
			rb.velocity = new Vector3(0,0,0);
		}

		
	}
}
