using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menubtn : MonoBehaviour
{
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    bool button1off = false;
    float number = 0.5f;

    int value;
    public AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        button1.onClick.AddListener(button1enve);
        button2.onClick.AddListener(button2enve);
        button3.onClick.AddListener(button3enve);
        button4.onClick.AddListener(button4enve);
    }

    // Update is called once per frame
    void Update()
    {
        if (button1off == true)
        {
            number -= Time.deltaTime;
            if (number <= 0)
            {
                if (value==1)
                {
                    SceneManager.LoadScene("Yuquan Qu Scene");
                }
                if (value == 2)
                {
                    SceneManager.LoadScene("Desert");
                }
                if (value == 3)
                {
                    SceneManager.LoadScene("game");
                }
                if (value == 4)
                {
                    SceneManager.LoadScene("Winter Pack Example");
                }

                number = 0.5f;
                button1off = false;
            }
        }
    }

    public void button1enve()
    {
        button1off = true;
        audio.Play();
        value = 1;
    }
    public void button2enve()
    {
        button1off = true;
        audio.Play();
        value = 2;
    }
    public void button3enve()
    {
        button1off = true;
        audio.Play();
        value = 3;
    }
    public void button4enve()
    {
        button1off = true;
        audio.Play();
        value = 4;
    }
}
