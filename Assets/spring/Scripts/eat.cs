using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eat : MonoBehaviour
{
    public int score = 0;
    public Text Score;
    public GameObject win;

    void Start()
    {
        win = GameObject.Find("Win");
        win.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            Destroy(other.gameObject);
            score++;
            Score.text = "Number of cakes: " + score;
            GetComponent<AudioSource>().Play();
            if (score == 15)
            {
                win.SetActive(true);
            }
        }
    }
}
