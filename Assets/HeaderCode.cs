using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HeaderCode : MonoBehaviour {
    public GameObject Result;
    public Text LastPointTxt,HightScoreTxt;
    public static HeaderCode Instance { get; private set; }
    // Use this for initialization
    void Start () {
        Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        HightScoreTxt.text = ""+PlayerPrefs.GetInt("HightScore");
        LastPointTxt.text = "Point:" + PlayerPrefs.GetInt("Point");
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            Result.SetActive(true);
            
        }

    }
}
