using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
    public int score = 0;
    public Text Num;
    public GameObject win;

    public Button help;
    void Start ()
    {
        win.SetActive(false);
        help.onClick.AddListener(() => SceneManager.LoadScene("Help1"));
    }
  

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "apple")
        {
            GetComponent<AudioSource>().Play();
            Destroy(other.gameObject);
            score++;
            Num.text = "Score: " + score;
            if(score == 10)
            {
                win.SetActive(true);
            }

            
        }
    }
}