using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fan : MonoBehaviour {
    float spingSpeed = 10f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0,0 , spingSpeed * Time.deltaTime);	
	}
}
