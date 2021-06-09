using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball4 : MonoBehaviour {
    public GameObject Ball1, Ball2, Ball3, Ball4 ;
    int RandomBall = 0;
    public GameObject EfShow;
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update ()
    {

        if (PlayerPrefs.GetInt("Bom") == 3)
        {
            Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (PlayerPrefs.GetInt("Bom") == 4)
        {
            ChangCor();
           
        }

        }
    void OnMouseDown()
    {
        RandomBall = Random.Range(1, 5);
        if (RandomBall == 1)
        {
            Instantiate(Ball1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
        else if (RandomBall == 2)
        {
            Instantiate(Ball2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
        else if (RandomBall == 3)
        {
            Instantiate(Ball3, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
        else if (RandomBall == 4)
        {
            Instantiate(Ball4, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }

    }
    void ChangCor()
    {
        RandomBall = Random.Range(1, 5);
        if (RandomBall == 1)
        {
            Instantiate(Ball1, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
        else if (RandomBall == 2)
        {
            Instantiate(Ball2, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
        else if (RandomBall == 3)
        {
            Instantiate(Ball3, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
        else if (RandomBall == 4)
        {
            Instantiate(Ball4, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0), Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
