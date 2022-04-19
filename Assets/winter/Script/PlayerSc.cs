using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSc : MonoBehaviour
{
    public int score = 0;
    public Text Score;
    public GameObject victory;

    void Start()
    {
        victory.SetActive(false);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "gold")
        {
            Destroy(other.gameObject);
            score++;
            Score.text = "Score£º" + score;
            GetComponent<AudioSource>().Play();
            if (score == 9)
            {
                victory.SetActive(true);
            }
        }
    }
}
