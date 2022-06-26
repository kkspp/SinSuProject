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
    }

    private void FixedUpdate()
    {
        Vector2 direction = Vector2.right * joystic.Horizontal;
        userRigidbody.AddForce(direction * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<DropItem>() != null)
        {
            GetItem(collision);
            Destroy(collision.gameObject);
        }
    }

    private void GetItem(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<DropItem>().ItemName == "Coin")
        {
            ScoreManager.Instance.GetCoin();
        }
    }
}
