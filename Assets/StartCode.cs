using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class StartCode : MonoBehaviour {

    public Text HightScoreTxt;

    //On-Off Scene
    public GameObject StartScene;
    public GameObject AcPanel;
    public GameObject ShopPanel;
    public GameObject SettingPanel;
    public GameObject GameScene;
    public GameObject MainCode;
    //
    // 
    void Start () {
        

        StartScene.SetActive(true);
        AcPanel.SetActive(false);
        ShopPanel.SetActive(false);
        SettingPanel.SetActive(false);
        GameScene.SetActive(false);
        MainCode.SetActive(false);
    }

// 
void Update () {
        SettingPane();
        HightScoreTxt.text = ""+ PlayerPrefs.GetInt("HightScore");
    }
    public void StartButton()
    {
        
        StartScene.SetActive(false);
        GameScene.SetActive(true);
        MainCode.SetActive(true);


        
    }
    public void AchievementBt()
    {
        AcPanel.SetActive(true);
    }
    public void CloseAchievementBt()
    {
        AcPanel.SetActive(false);
    }
    public void ShopBt()
    {
        ShopPanel.SetActive(true);
    }
    public void CloseShopBt()
    {
        ShopPanel.SetActive(false);
    }
    public int SwitchSetting;
    public void SettingBt()
    {
        SettingPanel.SetActive(true);
        SwitchSetting = 1;
    }
    public void CloseSettingBt()
    {
        SettingPanel.SetActive(false);
        SwitchSetting = 0;
    }
    public void CreditsBt()
    {
        if (SwitchSetting == 1)
        {
            SwitchSetting = 2;
        }
        else if (SwitchSetting == 2)
        {
            SwitchSetting = 1;
        }
    }
    public GameObject SceneSound, SceneCredite;
    void SettingPane()
    {
        if (SwitchSetting == 0)
        {
            SceneSound.SetActive(false);
            SceneCredite.SetActive(false);
        }
        if(SwitchSetting == 1)
        {
            SceneSound.SetActive(true);
            SceneCredite.SetActive(false);
        }
        else if(SwitchSetting == 2)
        {
            SceneSound.SetActive(false);
            SceneCredite.SetActive(true);
        }
    }


    
}
