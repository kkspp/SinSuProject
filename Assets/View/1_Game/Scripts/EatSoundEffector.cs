using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatSoundEffector : MonoBehaviour
{
    [SerializeField]
    private AudioSource audioSource;

    [SerializeField]
    private AudioClip goodEatClip;
    [SerializeField]
    private AudioClip badEatClip;

    public void PlayAudio(bool isGood)
    {
        if (isGood)
            audioSource.PlayOneShot(goodEatClip);
        else
        {
            audioSource.PlayOneShot(badEatClip);
        }
    }
}
