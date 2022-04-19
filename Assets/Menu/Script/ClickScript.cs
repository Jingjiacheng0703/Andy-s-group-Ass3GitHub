using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickScript : MonoBehaviour
{
    public Button play;


    void Start()
    {
        AudioSource As = gameObject.GetComponent<AudioSource>();
        play.onClick.AddListener(delegate ()
        {
            As.Play();
        });


    }
}
