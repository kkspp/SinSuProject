using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    public Sprite ItemImage;
    public float GravityScale;
    private Vector2 startPosition;

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
