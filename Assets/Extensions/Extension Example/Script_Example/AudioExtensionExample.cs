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
        source[0].PlayFadeInOut(3, 3, EaseType.EaseIn, EaseType.EaseOut);
        Invoke(nameof(StopAfter), 5);
    }
    void StopAfter()
    {
        source[0].StopFadeOut(1, EaseType.Linear);
    }
}
