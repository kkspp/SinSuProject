using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    private int coinScore = 0;
    public int CoinScore
    {
        get { return coinScore; }
        set { coinScore = value;
            coinScoreText.text = " x " + coinScore.ToString();
        }
    }

    [SerializeField]
    public List<int> GetItemCounter;

    [SerializeField]
    private TMP_Text coinScoreText;
    
    public void GetItem(DropItem item)
    {
        switch (item.Name)
        {
            case DropItem.ItemCase.Cake:
                break;
            case DropItem.ItemCase.Coin:
                CoinScore += 1;
                break;
            case DropItem.ItemCase.Cookie:
                break;
            case DropItem.ItemCase.Donut:
                break;
            case DropItem.ItemCase.Sandwich:
                break;
            case DropItem.ItemCase.Scone:
                break;
            case DropItem.ItemCase.UpgradeHat:
                break;
            case DropItem.ItemCase.BugItem:
                //Todo : 1.CharacterAnimation 2.Score or interaction
                Debug.LogWarning("Oh my god!!");
                break;
        }

        GetItemCounter[(int)item.Name]++;
        item.gameObject.SetActive(false);
    }

    private void Start()
    {
        ResetItemCounter();
    }

    private void ResetItemCounter()
    {
        DropItem.ItemsCount = Enum.GetNames(typeof(DropItem.ItemCase)).Length;
        for (int i=0; i < DropItem.ItemsCount; i++)
        {
            GetItemCounter.Add(0);
        }
    }
}
