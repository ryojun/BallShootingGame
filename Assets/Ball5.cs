using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball5 : MonoBehaviour {
    public GameObject EfShow;
    bool SwOn = false;
    private Animator BallAnim;
    // Use this for initialization
    void Start()
    {
        BallAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        BallAnim.SetBool("SwOnClick", SwOn);

        if (PlayerPrefs.GetInt("AfterAll") == 1)
        {
            if (SwOn == true)
            {
                Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
                SwOn = false;
            }

        }
        else if (PlayerPrefs.GetInt("AfterAll") == 2)
        {
            if (SwOn == true)
            {
              //  Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
                SwOn = false;
            }

        }
        else if (PlayerPrefs.GetInt("AfterAll") == 3)
        {
            if (SwOn == true)
            {
              //  Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
                SwOn = false;
                
            }
        }



    }
    void OnMouseDown()
    {

        if (SwOn == false)
        {
            if (PlayerPrefs.GetInt("Bucket1") == 0)
            {
                PlayerPrefs.SetInt("Bucket1", 5);
                PlayerPrefs.SetInt("AfterAll", 0);
                SwOn = true;

            }
            else
            {
                if (PlayerPrefs.GetInt("Bucket2") == 0)
                {
                    PlayerPrefs.SetInt("Bucket2", 5);
                    SwOn = true;
                }
                else
                {
                    if (PlayerPrefs.GetInt("Bucket3") == 0)
                    {
                        PlayerPrefs.SetInt("Bucket3", 5);
                        SwOn = true;
                    }
                }
            }

        }
    }


}
