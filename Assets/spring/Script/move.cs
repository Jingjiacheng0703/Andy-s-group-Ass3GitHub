using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimatorType
{
    Idle = 1,
    Walk = 2,
    Run = 3
}

public class move : MonoBehaviour
{
    private CharacterController character;
    private float rotate = 5f;

    public bool movesWitch;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        character = this.GetComponent<CharacterController>();
    }

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            movesWitch = true;
            SetAnimator(AnimatorType.Walk);
            character.Move(this.transform.forward * 7 * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            if (movesWitch)
            {
                movesWitch = false;
                SetAnimator(AnimatorType.Idle);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        character.Move(-Vector3.up * 10 * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
        {
            movesWitch = true;
            SetAnimator(AnimatorType.Walk);
            this.transform.eulerAngles -= new Vector3(0, rotate, 0);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            movesWitch = true;
            SetAnimator(AnimatorType.Run);
            character.Move(this.transform.forward * 9 * Time.deltaTime);
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            if (movesWitch)
            {
                movesWitch = false;       
                SetAnimator(AnimatorType.Idle);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            movesWitch = true;
            SetAnimator(AnimatorType.Walk);
            this.transform.eulerAngles += new Vector3(0, rotate, 0);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            if (movesWitch)
            {
                movesWitch = false;
                SetAnimator(AnimatorType.Idle);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            movesWitch = true;
            SetAnimator(AnimatorType.Walk);
            character.Move(-this.transform.forward * 7 * Time.deltaTime);
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            if (movesWitch)
            {
                movesWitch = false;
                SetAnimator(AnimatorType.Walk);
            }
        }
     
    }

    public void SetAnimator(AnimatorType type)
    {
        animator.SetBool("idle", type == AnimatorType.Idle);
        animator.SetBool("walk", type == AnimatorType.Walk);
        animator.SetBool("run", type == AnimatorType.Run);
    }
 }
