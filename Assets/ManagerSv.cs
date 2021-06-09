using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerSv : MonoBehaviour {
    public static ManagerSv Instance { get; private set; }
    public static int Counter { get; private set; }
    // Use this for initialization
    void Start () {
        Instance = this;
    }
	
	// Update is called once per frame
	void Update () {
        if (PlayerPrefs.GetInt("Point") > PlayerPrefs.GetInt("HightScore"))
        {
            PlayerPrefs.SetInt("HightScore", PlayerPrefs.GetInt("Point"));
        }

        
        
    }
    public void IncrementCounter()
    {
        Counter++;
        UIScript.Instance.UpdatePointsText();
    }

    public void RestartGame()
    {
        PlayGamesScript.AddScoreToLeaderboard(GPGSIds.leaderboard_leaderboard, Counter);
        Counter = 0;
        UIScript.Instance.UpdatePointsText();
    }

}
