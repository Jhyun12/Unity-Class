using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public int money = 10000;

    private void Awake()
    {
        LoadData();
    }

   public void SaveData()
    {
        PlayerPrefs.SetInt("money", money);
    }

    public void LoadData()
    {
        money = PlayerPrefs.GetInt("money");
    }

    public void Increase()
    {
        money += 1000;
        SaveData();
    }

    public void Decrease()
    {
        money -= 1000;
        SaveData();
    }
}
