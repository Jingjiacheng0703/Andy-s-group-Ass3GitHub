using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class times : MonoBehaviour
{
    public Text timeText;
    float time = 120;

    public AudioSource audiobtn;
    public Button back;
    bool backoff = false;
    float backtime = 0.8f;
    public GameObject lostimg;
    private int value;


    public Button help;
    public GameObject helpimg;
    public Button helpbtn;
    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(backEnve);
        help.onClick.AddListener(() => helpimg.SetActive(true));
        helpbtn.onClick.AddListener(() => helpimg.SetActive(false));
    }

    // Update is called once per frame
    void Update()
    {
        if (backoff == true)
        {
            backtime -= Time.deltaTime;
            if (backtime <= 0)
            {
                SceneManager.LoadScene("menu");
                backtime = 0.8f;
            }
        }
        if (time > 0 && Manager.instance.timeoff == true)
        {
            time -= Time.deltaTime;
            value = (int)time % 181;
            timeText.text = string.Format("time£º" + value);
        }
        if (value <= 0 && Manager.instance.number < 10)
        {
            Manager.instance.timeoff = false;
            Manager.instance.Speed = 0f;
            lostimg.SetActive(true);
        }
    }

    public void backEnve()
    {
        backoff = true;
        audiobtn.Play();
    }
}
