using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public static int ItemsCount;

    public Sprite ItemImage;
    public float GravityScale;
    private Vector2 startPosition;
    public ItemCase Name;
    public bool isGoomItem;

    public enum ItemCase
    {
        Cake = 0,
        Coin,
        Cookie,
        Donut,
        Sandwich,
        Scone,
        UpgradeHat,
        BugItem
    }

    public void InitPosition()
    {
        //random x pos
        //random item
        //item에 따른 그림 및 속성 설정
    }

    private void Start()
    {
        startPosition = GetComponent<RectTransform>().anchoredPosition;
    }
}
