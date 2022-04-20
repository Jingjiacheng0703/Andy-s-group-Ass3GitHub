using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class leadMove : MonoBehaviour
{
    private CharacterController characterController;
    private float rotSpeed = 1f;

    public bool ismove;
    public Animator animator;

    public Text fraction;

    public AudioSource audio;

    public GameObject Wining;
    // Start is called before the first frame update
    void Start()
    {
        characterController = this.GetComponent<CharacterController>();
    }

    private void LateUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x, 0, this.transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            ismove = true;
            animator.SetBool("ldle", false);
            animator.SetBool("walk", true);
            this.transform.eulerAngles -= new Vector3(0, rotSpeed, 0);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            if (ismove)
            {
                ismove = false;
                animator.SetBool("ldle", true);
                animator.SetBool("walk", false);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            ismove = true;
            animator.SetBool("ldle", false);
            animator.SetBool("walk", true);
            this.transform.eulerAngles += new Vector3(0, rotSpeed, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (ismove)
            {
                ismove = false;
                animator.SetBool("ldle", true);
                animator.SetBool("walk", false);
            }
        }
        if (Input.GetKey(KeyCode.W))
        {
            ismove = true;
            animator.SetBool("ldle", false);
            animator.SetBool("walk", true);
            characterController.Move(this.transform.forward * Manager.instance.Speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (ismove)
            {
                ismove = false;
                animator.SetBool("ldle", true);
                animator.SetBool("walk", false);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            ismove = true;
            animator.SetBool("ldle", false);
            animator.SetBool("walk", true);
            characterController.Move(-this.transform.forward * Manager.instance.Speed * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (ismove)
            {
                ismove = false;
                animator.SetBool("ldle", true);
                animator.SetBool("walk", false);
            }
        }


    }
    public void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "thing")
        {
            audio.Play();
            Manager.instance.number++;
            Destroy(collider.gameObject);
            fraction.text = string.Format("fraction£º" + Manager.instance.number+"/10");
            if (Manager.instance.number >= 10)
            {
                Manager.instance.timeoff = false;
                Wining.SetActive(true);
            }
        }
    }
}
