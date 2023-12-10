using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
        public Text readingEng;

        string url = "https://translate.google.com/translate_tts?ie=UTF-8&textlen=64&client=tw-ob&q=";

        AudioSource audio;
        void Start()
        {
            audio = GetComponent<AudioSource>();
        }

        IEnumerator PlaySpeak(string str)
        {
            WWW www = new WWW(str);
            yield return www;

            audio.clip = www.GetAudioClip(false, true, AudioType.MPEG);
            audio.Play();
        }

        string getString(string text)
        {
            return text + "&tl=En";
        }
    public void EngBtn()
    {
        StartCoroutine(PlaySpeak(url + getString(readingEng.text)));
    }
}


