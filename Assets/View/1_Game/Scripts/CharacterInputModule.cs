using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputModule : MonoBehaviour
{
    const int CharacterWidth = 180; 
    [SerializeField]
    private float moveSpeed;

    private RectTransform characterRectTransform;

    private void Start()
    {
        characterRectTransform = GetComponent<RectTransform>();

        Debug.Log(CharacterWidth / 2.0f);
    }

    private void Update()
    {
        if (characterRectTransform.anchoredPosition.x <= (-Screen.width + CharacterWidth) / 2.0f)
            characterRectTransform.anchoredPosition = new Vector2((-Screen.width + CharacterWidth) / 2.0f, characterRectTransform.anchoredPosition.y);
        else if (characterRectTransform.anchoredPosition.x >= (Screen.width - CharacterWidth) / 2.0f)
            characterRectTransform.anchoredPosition = new Vector2((Screen.width - CharacterWidth) / 2.0f, characterRectTransform.anchoredPosition.y);

        float horizontalKey = Input.GetAxis("Horizontal");
        GetComponent<RectTransform>().anchoredPosition += new Vector2(horizontalKey * moveSpeed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.GetComponent<DropItem>().
    }
}
