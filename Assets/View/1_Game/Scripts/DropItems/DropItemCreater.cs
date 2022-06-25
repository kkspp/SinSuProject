using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemCreater : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> dropItemPrefabs;

    private void Start()
    {
        StartCoroutine("CreateRandomItems");
    }

    IEnumerator CreateRandomItems()
    {
        while(true)
        {
            int selectedItemIndex = Random.Range(0, 6);
            int randomGravityScale = Random.Range(0, 6) * 15;
            float randomTime = Random.Range(0, 1.5f);
            float randomDropItemPosX = Random.Range(0, Screen.width);
            DropItem dropItem = Instantiate(dropItemPrefabs[selectedItemIndex], new Vector2(randomDropItemPosX, Screen.height+150), Quaternion.Euler(Vector3.zero), transform).GetComponent<DropItem>();
            dropItem.GravityScale = randomGravityScale;
            yield return new WaitForSeconds(randomTime);
        }
        
    }
}
