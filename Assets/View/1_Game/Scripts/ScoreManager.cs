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
    private TMP_Text coinScoreText;

    public void GetCoin()
    {
        CoinScore += 1;
    }
}
