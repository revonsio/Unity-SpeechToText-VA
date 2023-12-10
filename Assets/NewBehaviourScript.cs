using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public Sprite[] spriteImage;
    bool IsClick;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void helloWorld()
    {
        print("Hello World");
    }

    public void changetext()
    {
        GetComponentInChildren<Text>().text = "hello";
    }

    public void changeimage()
    {
        IsClick = !IsClick;
        if (!IsClick)
        {
            GetComponent<Image>().sprite = spriteImage[0];
        } else
        {
            GetComponent<Image>().sprite = spriteImage[1];
        }
        
    }

    public void sound()
    {
        GetComponent<AudioSource>().Play();
    }
}
