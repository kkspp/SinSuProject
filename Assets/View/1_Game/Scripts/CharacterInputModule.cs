using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputModule : MonoBehaviour
{
    const int CharacterWidth = 180;
    [SerializeField]
    private Joystick joystic;
    [SerializeField]
    private float moveSpeed;

    private RectTransform characterRectTransform;
    private Rigidbody2D userRigidbody;

    private void Start()
    {
        characterRectTransform = GetComponent<RectTransform>();
        userRigidbody = GetComponent<Rigidbody2D>();

        Debug.Log(CharacterWidth / 2.0f);
    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.right * joystic.Horizontal;
        userRigidbody.AddForce(direction * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);

        if (characterRectTransform.anchoredPosition.x <= (-Screen.width + CharacterWidth) / 2.0f)
            characterRectTransform.anchoredPosition = new Vector2((-Screen.width + CharacterWidth) / 2.0f, characterRectTransform.anchoredPosition.y);
        else if (characterRectTransform.anchoredPosition.x >= (Screen.width - CharacterWidth) / 2.0f)
            characterRectTransform.anchoredPosition = new Vector2((Screen.width - CharacterWidth) / 2.0f, characterRectTransform.anchoredPosition.y);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.GetComponent<DropItem>().
    }
}
