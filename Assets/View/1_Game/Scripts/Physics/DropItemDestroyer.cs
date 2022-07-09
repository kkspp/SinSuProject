using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemDestroyer : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<DropItem>() != null)
        {
            collision.gameObject.SetActive(false);
        }
    }
}
