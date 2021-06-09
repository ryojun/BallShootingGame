using System;
using System.Collections;
using System.Collections.Generic;
using GooglePlayGames;
using GooglePlayGames.BasicApi;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;

public class PlayGamesScript : MonoBehaviour {
    private MainGui mOwner;
    private string mStatus;
    // Use this for initialization
    void Start () {
        PlayGamesClientConfiguration config = new PlayGamesClientConfiguration.Builder()
        // enables saving game progress.
        .EnableSavedGames()
        .RequestEmail()
        // requests a server auth code be generated so it can be passed to an
        //  associated back end server application and exchanged for an OAuth token.
        .RequestServerAuthCode(false)
        // requests an ID token be generated.  This OAuth token can be used to
        //  identify the player to other services such as Firebase.
        .RequestIdToken()
        .Build();
        PlayGamesPlatform.InitializeInstance(config);
        // recommended for debugging:
        PlayGamesPlatform.DebugLogEnabled = true;
        // Activate the Google Play Games platform
        PlayGamesPlatform.Activate();

        SignIn();


    }
    void SignIn()
    {
        Social.localUser.Authenticate((bool success) => {
            // handle success or failure
        });
    }

    #region Achievements
    public static void UnlockAchievement(string id)
    {
        Social.ReportProgress(id, 100, success => { });
    }

    public static void IncrementAchievement(string id, int stepsToIncrement)
    {
        PlayGamesPlatform.Instance.IncrementAchievement(id, stepsToIncrement, success => { });
    }

    public static void ShowAchievementsUI()
    {
        Social.ShowAchievementsUI();
    }
    #endregion /Achievements

    #region Leaderboards
    public static void AddScoreToLeaderboard(string leaderboardId, long score)
    {
        Social.ReportScore(score, leaderboardId, success => { });
    }

    public static void ShowLeaderboardsUI()
    {
        Social.ShowLeaderboardUI();
        PlayGamesPlatform.Instance.ShowLeaderboardUI("CgkIg8XamogYEAIQAQ");
    }
    #endregion /Leaderboards

    public void ShowAc()
    {
        SignIn();
        Social.ShowAchievementsUI();
    }
   public void ShowLd()
    {
        
        ILeaderboard lb = PlayGamesPlatform.Instance.CreateLeaderboard();
        lb.id = "CgkIg8XamogYEAIQAQ";
        lb.LoadScores(ok =>
        {
            if (ok)
            {
                LoadUsersAndDisplay(lb);
            }
            else
            {
                Debug.Log("Error retrieving leaderboardi");
            }
        });

        
    }

    internal void LoadUsersAndDisplay(ILeaderboard lb)
    {
        // get the use ids
        List<string> userIds = new List<string>();

        foreach (IScore score in lb.scores)
        {
            userIds.Add(score.userID);
        }
        Social.LoadUsers(userIds.ToArray(), (users) =>
        {
            mStatus = "Leaderboard loading: " + lb.title + " count = " +
                lb.scores.Length;
            foreach (IScore score in lb.scores)
            {
                IUserProfile user = FindUser(users, score.userID);
                mStatus += "\n" + score.formattedValue + " by " +
                    (string)(
                        (user != null) ? user.userName : "**unk_" + score.userID + "**");
            }
        });
    }
    private IUserProfile FindUser(IUserProfile[] users, string userid)
    {
        foreach (IUserProfile user in users)
        {
            if (user.id == userid)
            {
                return user;
            }
        }
        return null;
    }
}

