using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInputModule : MonoBehaviour
{
    const int CharacterWidth = 180;
    [SerializeField]
    private Image characterImage;
    [SerializeField]
    private Sprite normalBear;
    [SerializeField]
    private Sprite smileBear;
    [SerializeField]
    private Sprite cryBear;
    [SerializeField]
    private Joystick joystic;
    [SerializeField]
    private float moveSpeed;

    private RectTransform characterRectTransform;
    private Rigidbody2D userRigidbody;
    private DropItem lastGetItem; 

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
        DropItem getItem = collision.gameObject.GetComponent<DropItem>();
        if (getItem != null)
        {
            lastGetItem = getItem;
            ScoreManager.Instance.GetItem(getItem);
            StopCoroutine("ChangeFace");
            StartCoroutine(ChangeFace());
        }
    }

    private IEnumerator ChangeFace()
    {
        if (lastGetItem.isGoomItem)
            characterImage.sprite = smileBear;
        else
            characterImage.sprite = cryBear;

        yield return new WaitForSeconds(1.0f);

        characterImage.sprite = normalBear;
    }
}
