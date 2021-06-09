using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MainCode : MonoBehaviour {
    
    public int AdminSpeed =1;
    public Text TestText;
    /// <summary>
    /// /////////////////////////////////////////////
    /// Switch Number AfterAll
    /// 0 is Nomal
    /// 1 is AllSame
    /// 2 is Alldeference
    /// 3 is Not
    /// </summary>
    /// 
    // float GameTime = 0; //TIME

    public GameObject EfShow;

    public Text PointText;
    GameObject[] Ball;
    public GameObject Buble1,Buble2,Buble3,Buble4,Buble5;
    float SpeedCount = 3;
    int RandomeColor;
    public int BallStart; //จำนวนลูกบอลตอนเริ่มเกม
    public GameObject PlayAgianScene;
    float HelpTime = 0;
    
    void Start () {
        StartSystem();
        LevelControll();
        PlayerPrefs.SetInt("CountBall", BallStart);//นับจำนวนลูกแก้วที่มีอยู่
        PlayerPrefs.SetInt("Bucket1", 0);
        PlayerPrefs.SetInt("Bucket2", 0);
        PlayerPrefs.SetInt("Bucket3", 0);
        PlayerPrefs.SetInt("AfterAll", 0);

        PlayerPrefs.SetInt("Point", 0);
        PlayerPrefs.SetInt("HelpMode1",0);
        PlayerPrefs.SetInt("HelpMode2", 0);
        PlayerPrefs.SetInt("HelpMode3", 0);
        PlayerPrefs.SetInt("Bom", 0);
    }
	

	void Update () {
     //   GameTime = Time.deltaTime;
        Time.timeScale = AdminSpeed;
        PointText.text = "" + PlayerPrefs.GetInt("Point");
        CheckBucket();
        HelpSt();
        


    }
    

    void StartSystem()
    {
        
        while (BallStart > 0)
        {
            RandomSystem();
            BallStart--;
        }
    }

    void RandomSystem()
    {
        RandomeColor = Random.Range(1, 9);
        if (RandomeColor == 1) {
            Instantiate(Buble1, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
        PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
    }
        else if (RandomeColor == 2) { 
            Instantiate(Buble2, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
        else if (RandomeColor == 3) { 
            Instantiate(Buble3, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
        else if (RandomeColor == 4) { 
            Instantiate(Buble4, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
        else if (RandomeColor == 5) { 
            Instantiate(Buble5, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
        else if (RandomeColor == 6)
        {
            Instantiate(Buble5, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
        else if (RandomeColor == 7)
        {
            Instantiate(Buble5, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
        else if (RandomeColor == 8)
        {
            Instantiate(Buble5, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
            PlayerPrefs.SetInt("CountBall", PlayerPrefs.GetInt("CountBall") + 1);
        }
    }

    public void ClickResetBall()
    {
        Ball = GameObject.FindGameObjectsWithTag("Ball");
        foreach (GameObject Ball in Ball)
        {
            Destroy(Ball);
            RandomSystem();
        }
        PlayerPrefs.SetInt("Bucket1", 0);
        PlayerPrefs.SetInt("Bucket2", 0);
        PlayerPrefs.SetInt("Bucket3", 0);
        PlayerPrefs.SetInt("AfterAll", 0);

    }
   
    void CheckBucket()
    {
        if (PlayerPrefs.GetInt("Bucket3") != 0)
        {
            if (PlayerPrefs.GetInt("Bucket1") == PlayerPrefs.GetInt("Bucket2") && PlayerPrefs.GetInt("Bucket2") == PlayerPrefs.GetInt("Bucket3"))
            {
                PlayerPrefs.SetInt("Point",PlayerPrefs.GetInt("Point")+1);
                TestText.text = "True";
                PlayerPrefs.SetInt("AfterAll",1);
                PlayerPrefs.SetInt("Bucket1", 0);
                PlayerPrefs.SetInt("Bucket2", 0);
                PlayerPrefs.SetInt("Bucket3", 0);
                HelpTime = 0;
                PlayerPrefs.SetInt("HelpMode1", 0);
                PlayerPrefs.SetInt("HelpMode2", 0);
                PlayerPrefs.SetInt("HelpMode3", 0);
                
            }
            else
            {
                /*if (PlayerPrefs.GetInt("Bucket1") != PlayerPrefs.GetInt("Bucket2")
               && PlayerPrefs.GetInt("Bucket2") != PlayerPrefs.GetInt("Bucket3")
               && PlayerPrefs.GetInt("Bucket1") != PlayerPrefs.GetInt("Bucket3"))
                {
                    PlayerPrefs.SetInt("Point", PlayerPrefs.GetInt("Point") + 1);
                    TestText.text = "True";
                    PlayerPrefs.SetInt("AfterAll", 2);
                    PlayerPrefs.SetInt("Bucket1", 0);
                    PlayerPrefs.SetInt("Bucket2", 0);
                    PlayerPrefs.SetInt("Bucket3", 0);
                    HelpTime = 0;
                    PlayerPrefs.SetInt("HelpMode1", 0);
                    PlayerPrefs.SetInt("HelpMode2", 0);
                    PlayerPrefs.SetInt("HelpMode3", 0);
                    
                }*/

                //else
                //{
                    TestText.text = "false";
                    PlayerPrefs.SetInt("AfterAll", 3);
                    PlayerPrefs.SetInt("Bucket1", 0);
                    PlayerPrefs.SetInt("Bucket2", 0);
                    PlayerPrefs.SetInt("Bucket3", 0);
                //}
            }

           
        }
    }

    void LevelControll()
    {
        InvokeRepeating("ORBomRandom", 1, 5);
        InvokeRepeating("BlackBomRandom", 1, 5);
        InvokeRepeating("BlackStar", 1, 5);
        InvokeRepeating("ResetConfig", 1, 3);
        
        //HarderControll
        InvokeRepeating("RandomSystem", 2.0f, SpeedCount);
        InvokeRepeating("RandomSystem", 20, SpeedCount);
        InvokeRepeating("RandomSystem", 30, SpeedCount);
        InvokeRepeating("RandomSystem", 40, SpeedCount);
        InvokeRepeating("RandomSystem", 120, 2);

    }

    public void ClickPlayAgian()
    {
        PlayerPrefs.SetInt("Point", 0);
        Ball = GameObject.FindGameObjectsWithTag("Ball");
        foreach (GameObject Ball in Ball)
        {
            Destroy(Ball);
        }
        CancelInvoke("RandomSystem");
        LevelControll();
        BallStart = 20;
        StartSystem();
        PlayAgianScene.SetActive(false);
        PlayerPrefs.SetInt("Bucket1", 0);
        PlayerPrefs.SetInt("Bucket2", 0);
        PlayerPrefs.SetInt("Bucket3", 0);
        PlayerPrefs.SetInt("AfterAll", 0);
    }

    
    void HelpSt()
    {
        
        HelpTime += Time.deltaTime;
        if (HelpTime >= 10)
        {
            PlayerPrefs.SetInt("RandomHelp",  2);
            for (int i = 0; i < 1; i++)
            {
                PlayerPrefs.SetInt("HelpMode1", 1);
                PlayerPrefs.SetInt("HelpMode2", 1);
                PlayerPrefs.SetInt("HelpMode3", 1);
            }
        }
    }
    void ResetConfig()
    {
        PlayerPrefs.SetInt("Bom",0);
    }
    int ORBR = 0;
    int BBRD = 0;
    int BSRD = 0;
    public GameObject ORBom, BlackBomRd, BlacsStarRd;
    
    void ORBomRandom()
    {
        ORBR = Random.Range(1,20);
        if (ORBR == 3)
        {
            
            Instantiate(ORBom, new Vector3(Random.Range(-2f, 3f), Random.Range(-2f, 5f), 0), Quaternion.identity);
            ORBR = 0;
        }
    }
    void BlackBomRandom()
    {
        BBRD = Random.Range(1, 20);
        if(BBRD == 3)
        Instantiate(BlackBomRd, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
    }
    void BlackStar()
    {
        BSRD = Random.Range(1, 20);
        if (BSRD == 4)
            Instantiate(BlacsStarRd, new Vector3(Random.Range(-2f, 3f), 3, 0), Quaternion.identity);
    }

    public void ExiteBt()
    {
        Application.LoadLevel(1);
    }
}
