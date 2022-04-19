using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class btn : MonoBehaviour
{
    public Button button1;
    public Button button2;

    // Start is called before the first frame update 
    void Start()
    {
        button1.onClick.AddListener(() => SceneManager.LoadScene("menu"));

        button2.onClick.AddListener(() => SceneManager.LoadScene("Help"));
    }
}
