using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;
    public Animator gmAnimator;
    public bool IsRight = true;

    void Start()
    {
        gmAnimator = gameObject.GetComponent<Animator>();
           }
    void FixedUpdate()
    {
     
    }
    public void OnTriggeredEnter()
    {
       
    }

}
