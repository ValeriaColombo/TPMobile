using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] private MovementControls controls;
    [SerializeField] private Animator animator;

    void Update()
    {
        if (controls.MovingLeft)
        {
            animator.SetBool("walking", true);
            transform.localScale = new Vector3(-3, 3, 3);
            transform.Translate(- controls.Speed * Time.deltaTime, 0, 0);
        }
        else if (controls.MovingRight)
        {
            animator.SetBool("walking", true);
            transform.localScale = new Vector3(3, 3, 3);
            transform.Translate(controls.Speed * Time.deltaTime, 0, 0);
        }
        else
        {
            animator.SetBool("walking", false);
        }
    }
}
