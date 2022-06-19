using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemCreater : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> dropItemPrefabs;
    [SerializeField]
    private GameObject selectedDropItem;

    public bool isActivatied;

    private void Start()
    {
        isActivatied = false;
        StartCoroutine("CreateRandomItems");
    }

    IEnumerator CreateRandomItems()
    {
        while(!isActivatied)
        {
            int selectedItemIndex = Random.Range(0, 6);
            int randomGravityScale = Random.Range(0, 6) * 15;
            DropItem dropItem = Instantiate(dropItemPrefabs[selectedItemIndex]).GetComponent<DropItem>();
            dropItem.GravityScale = randomGravityScale;
            yield return null;

        }
        
    }
}
