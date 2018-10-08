using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour {

    AudioSource aSource;
    public AudioClip burp, openCap, impact;

    private void Start()
    {
        aSource = GetComponent<AudioSource>();   
    }

    public void _playSound(string clip)
    {
        if (clip == "burp")
            aSource.PlayOneShot(burp);
        else if (clip == "openCap")
            aSource.PlayOneShot(openCap);
        else if (clip == "impact")
            aSource.PlayOneShot(impact);
    }
}
