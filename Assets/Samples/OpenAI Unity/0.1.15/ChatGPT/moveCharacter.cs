using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCharacter : MonoBehaviour
{

    Animator animator;
    public void whenClicked()
    {
        animator.SetBool("isMoving", false);
    }
    public void notClicked()
    {
        animator.SetBool("isMoving", true);
    }
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
        animator.SetBool("isMoving", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
