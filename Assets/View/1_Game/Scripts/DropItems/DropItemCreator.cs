using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemCreator : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> dropItemPools;
    [SerializeField]
    private bool isPlaying = true;

    public void StartToCreateRandomItems()
    {
        StartCoroutine("CreateRandomItems");
    }

    IEnumerator CreateRandomItems()
    {
        while(isPlaying)
        {
            int selectedItemIndex = Random.Range(0, DropItem.ItemsCount);
            int randomGravityScale = Random.Range(0, DropItem.ItemsCount) * 15;
            float randomTime = Random.Range(0, 1.5f);
            float randomDropItemPosX = Random.Range(0, Screen.width);
            GameObject dropItem = dropItemPools[selectedItemIndex].transform.GetChild(0).gameObject;
            dropItem.GetComponent<RectTransform>().position = new Vector2(randomDropItemPosX, Screen.height + 150);
            dropItem.GetComponent<DropItem>().GravityScale = randomGravityScale;
            dropItem.SetActive(true);
            dropItem.transform.SetAsLastSibling();

            yield return new WaitForSeconds(randomTime);
        }
        
    }
}
