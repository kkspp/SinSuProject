using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameViewer : MonoBehaviour
{
    [SerializeField]
    private ReadyCounter readyCounter;
    [SerializeField]
    private DropItemCreator dropItemCreator;

    void Start()
    {
        readyCounter.CountingEnd.AddListener(() => dropItemCreator.StartToCreateRandomItems());
        readyCounter.StartCounting();
    }
}
