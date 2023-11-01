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
        source.PlayFadeInOut(3,3, EaseType.EaseIn,1,() => { "FadeIn".Log(); }, () => { "FadeOut".Log(); });
/*        source.PlayFadeIn(2,EaseType.EaseOut);
        Invoke(nameof(StopAfter5Second),5);*/
    }

    // Update is called once per frame
    void StopAfter5Second()
    {
        source.StopFadeOut(2, EaseType.EaseIn);
    }
}
