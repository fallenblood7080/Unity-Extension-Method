using Extension;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioExtensionExample : MonoBehaviour
{
    [SerializeField]private AudioSource[] source;
    [SerializeField] private bool shouldLoop;
    [SerializeField] private int startingIndex;
    // Start is called before the first frame update
    void Start()
    {
        source.PlayAudioSequence(2, 2, EaseType.EaseIn, EaseType.EaseOut, shouldLoop, 1, startingIndex);
    }
}
