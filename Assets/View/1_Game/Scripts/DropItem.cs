using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    private Vector2 startPosition;

    private void Start()
    {
        startPosition = GetComponent<RectTransform>().anchoredPosition;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<RectTransform>().anchoredPosition = startPosition;
        gameObject.SetActive(false);
        gameObject.SetActive(true);
        GetComponent<Rigidbody2D>().gravityScale = Random.Range(50, 80);
    }
}
