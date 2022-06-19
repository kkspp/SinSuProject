using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItemCreater : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> dropItemPrefabs;

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
            int randomTime = Random.Range(0, 3);
            float randomDropItemPosX = Random.Range(-Screen.width, Screen.width) / 2;
            DropItem dropItem = Instantiate(dropItemPrefabs[selectedItemIndex], new Vector2(randomDropItemPosX, Screen.height+150), Quaternion.Euler(Vector3.zero), transform).GetComponent<DropItem>();
            dropItem.GravityScale = randomGravityScale;
            yield return new WaitForSeconds(randomTime);
        }
        
    }
}
