using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class VBTN : MonoBehaviour
{
    public Animator angelFishAnim;
    public VirtualButtonBehaviour button;
    void Start()
    {
        button.RegisterOnButtonPressed(OnButtonPressed);
    }

    public void OnButtonPressed(VirtualButtonBehaviour button)
    {
        Debug.Log("Button Pressed");
        angelFishAnim.Play("Take 001");
    }
}
