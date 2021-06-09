using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball1 : MonoBehaviour {
    public GameObject EfShow;
    bool HelpOn = false;
    bool SwOn = false;
    private Animator BallAnim;
    //
    void Start () {
        BallAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        BallAnim.SetBool("SwOnClick", SwOn);
        //BallAnim.SetBool("HelpOn", HelpOn);

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
                //Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
                Destroy(gameObject);
                SwOn = false;
            }

        }
            else if (PlayerPrefs.GetInt("AfterAll") == 3)
            {
            if (SwOn == true)
            {
               // Instantiate(EfShow, gameObject.transform.position, Quaternion.identity);
                SwOn = false;
                
            }
            }

        if (PlayerPrefs.GetInt("HelpMode1") == 0 && PlayerPrefs.GetInt("HelpMode2") == 0 && PlayerPrefs.GetInt("HelpMode3") == 0)
        {
            HelpOn = false;
        }
        if (PlayerPrefs.GetInt("RandomHelp") == 1)
        {



            if (PlayerPrefs.GetInt("HelpMode1") == 1)
            {
                HelpOn = true;
                PlayerPrefs.SetInt("HelpMode1", 3);
            }
            else if (PlayerPrefs.GetInt("HelpMode2") == 1)
            {
                HelpOn = true;
                PlayerPrefs.SetInt("HelpMode2", 3);
            }
            else if (PlayerPrefs.GetInt("HelpMode3") == 1)
            {
                HelpOn = true;
                PlayerPrefs.SetInt("HelpMode3", 3);
            }
        }




    }
    void OnMouseDown()
    {
        
        if(SwOn == false)
        {
            if (PlayerPrefs.GetInt("Bucket1") == 0)
            {
                PlayerPrefs.SetInt("Bucket1", 1);
                PlayerPrefs.SetInt("AfterAll", 0);
                SwOn = true;

            }
            else
            {
                if (PlayerPrefs.GetInt("Bucket2") == 0)
                {
                    PlayerPrefs.SetInt("Bucket2", 1);
                    SwOn = true;
                }
                else
                {
                    if (PlayerPrefs.GetInt("Bucket3") == 0)
                    {
                        PlayerPrefs.SetInt("Bucket3", 1);
                        SwOn = true;
                    }
                }
            }

        }
        }


    }
