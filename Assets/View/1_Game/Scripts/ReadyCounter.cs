using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class ReadyCounter : MonoBehaviour
{
    [SerializeField]
    private TMP_Text readyCounter;
    [SerializeField]
    private int time = 3;

    public UnityEvent CountingEnd;

    public void StartCounting()
    {
        gameObject.SetActive(true);
        StartCoroutine(CountingCoroutine( () =>
        {
            gameObject.SetActive(false);
            CountingEnd.Invoke();
            CountingEnd.RemoveAllListeners();
        }));
    }
    
    public IEnumerator CountingCoroutine(Action callback)
    {
        while(time >= 0)
        {
            if (time == 0)
                readyCounter.text = "Start!!";
            else
                readyCounter.text = time.ToString();
            time--;

            yield return new WaitForSeconds(1);
        }
        time = 0;

        callback.Invoke();
        yield return null;
    }
}
