using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {
    public static UIScript Instance { get; private set; }
    // Use this for initialization
    void Start () {
        Instance = this;
    }
    [SerializeField]
    private Text pointsTxt;

    public void GetPoint()
    {
        ManagerSv.Instance.IncrementCounter();
    }

    public void Restart()
    {
        ManagerSv.Instance.RestartGame();
    }

    public void Increment()
    {
        PlayGamesScript.IncrementAchievement(GPGSIds.achievement_beginner, 5);
    }

    public void Unlock()
    {
        PlayGamesScript.UnlockAchievement(GPGSIds.achievement_beginner);
    }

    public void ShowAchievements()
    {
        PlayGamesScript.ShowAchievementsUI();
    }

    public void ShowLeaderboards()
    {
        PlayGamesScript.ShowLeaderboardsUI();
    }

    public void UpdatePointsText()
    {
        pointsTxt.text = ManagerSv.Counter.ToString();
    }
}

