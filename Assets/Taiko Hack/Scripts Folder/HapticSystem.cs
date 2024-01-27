using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Oculus.Haptics;
using System;

public class HapticSystem : MonoBehaviour
{

    public HapticClip clip;
    HapticClipPlayer player;

    // Start is called before the first frame update
    void Start()
    {
      player = new HapticClipPlayer(clip);
    }

    public void playClip(Controller hand) {
      player.Stop();
      player.Play(hand);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Upon exiting the application (or when playmode is stopped) we release the haptic clip players and uninitialize (dispose) the SDK.
    protected virtual void OnApplicationQuit()
    {
        Haptics.Instance.Dispose();
    }
}

