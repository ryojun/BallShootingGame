using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORBom : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    void OnMouseDown()
    {
        PlayerPrefs.SetInt("Bom", 2);
        Destroy(gameObject);
    }
    }
