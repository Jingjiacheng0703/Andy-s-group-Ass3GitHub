using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewBeha : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start()
    {
        Button button = this.GetComponent<Button>();
        button.onClick.AddListener(() => SceneManager.LoadScene("Yuquan Qu Scene"));
    }

   
}
