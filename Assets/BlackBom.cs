using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackBom : MonoBehaviour {
    public GameObject EfShow;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
            PlayerPrefs.SetInt("Bom",3);
            Destroy(gameObject);
        }
            

    }
}
