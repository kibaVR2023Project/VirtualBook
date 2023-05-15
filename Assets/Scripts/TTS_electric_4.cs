using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TTS_electric_4 : MonoBehaviour
{

    public AudioSource _audio;

    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DownloadTheAudio() {
        string uri = string.Format("https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q={0}&tl=Ar-gb"," عنفة يدورها الماء");
        
        WWW www = new WWW(uri);
        yield return www;

        _audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        _audio.Play();
    }

    public void ButtonClick() {
        StartCoroutine(DownloadTheAudio());
    }

}
