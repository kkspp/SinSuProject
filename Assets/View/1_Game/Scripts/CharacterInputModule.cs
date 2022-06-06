using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInputModule : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private void Update()
    {
        float horizontalKey = Input.GetAxis("Horizontal");
        this.GetComponent<RectTransform>().anchoredPosition += new Vector2(horizontalKey * moveSpeed, 0);
    }
}
