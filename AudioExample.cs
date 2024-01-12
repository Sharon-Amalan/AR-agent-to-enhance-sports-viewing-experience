using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioExample : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip0, clip1, clip2, clip3, clip4, clip5, clip6, clip7, clip8, clip9;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("0Key"))
        {
            source.PlayOneShot(clip0);
        }
        if (Input.GetButtonDown("1Key"))
        {
            source.PlayOneShot(clip1);
        }
        if (Input.GetButtonDown("2Key"))
        {
            source.PlayOneShot(clip2);
        }
        if (Input.GetButtonDown("3Key"))
        {
            source.PlayOneShot(clip3);
        }
        if (Input.GetButtonDown("4Key"))
        {
            source.PlayOneShot(clip4);
        }
        if (Input.GetButtonDown("5Key"))
        {
            source.PlayOneShot(clip5);
        }
        if (Input.GetButtonDown("6Key"))
        {
            source.PlayOneShot(clip6);
        }
        if (Input.GetButtonDown("7Key"))
        {
            source.PlayOneShot(clip7);
        }
    }
}
