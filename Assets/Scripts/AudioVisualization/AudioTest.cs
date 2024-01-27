using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioTest : MonoBehaviour
{
    AudioSource _audioSource;
    public static float[] _samples = new float[256];
    public static float[] _freqBand = new float[8];

    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
    }

    void GetSpectrumAudioSource()
    {
        _audioSource.GetSpectrumData(_samples, 0, FFTWindow.Blackman);
    }

    void MakeFrequencyBands()
    {
        for (int i = 0; i < 8; i++)
        {
            float average = 0;

            int sampleCount = (int)Mathf.Pow(2, i) * 2;
            if (i == 7)
            {
                sampleCount += 2;
            }

            int count = 0; // Reset count to zero at the beginning of each iteration
            for (int j = 0; j < sampleCount; j++)
            {
                int index = count * (int)Mathf.Pow(2, 7 - i);
                if (index < _samples.Length)
                {
                    average += _samples[index] * (index + 1);
                    count++;
                }
                else
                {
                    UnityEngine.Debug.LogError("Index out of bounds in _samples array");
                    UnityEngine.Debug.LogError("i: " + i + ", j: " + j + ", count: " + count + ", index: " + index);
                    break; // Exit the loop to avoid further issues
                }
            }

            if (count > 0)
            {
                average /= count; // Move the division inside the loop
                _freqBand[i] = average * 10;
            }
            else
            {
                UnityEngine.Debug.LogError("Count is zero, division by zero avoided");
            }
        }
    }

}
