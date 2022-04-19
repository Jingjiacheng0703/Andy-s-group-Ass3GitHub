using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Move : MonoBehaviour
{
  
   

   
    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
        {

            this.transform.Translate(Vector3.forward * Time.deltaTime * 3);
            this.GetComponent<Animator>().SetBool("Move", true);
        }
        else if (Input.GetKey(KeyCode.S))
        {

            this.transform.Translate(-Vector3.forward * Time.deltaTime * 3);
            this.GetComponent<Animator>().SetBool("Move", true);
        }
        else
        {
            this.GetComponent<Animator>().SetBool("Move", false);
        }
        if (Input.GetKey(KeyCode.A))
        {

            this.transform.Rotate(-Vector3.up * Time.deltaTime * 30);
          
        }
        else if (Input.GetKey(KeyCode.D))
        {

            this.transform.Rotate(Vector3.up * Time.deltaTime * 30);
           
        }

    }
   
}
