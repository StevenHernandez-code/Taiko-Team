using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DrumSoundController : MonoBehaviour
{

    private AudioSource soundClip;

    // Start is called before the first frame update
    void Start()
    {
        soundClip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        soundClip.Play();
    }
}
