using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioExtensionExample : MonoBehaviour
{
    private AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayFadeIn(2, EaseType.EaseIn);
    }
}
