using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimateHand : MonoBehaviour
{
    public InputActionProperty pinchAction;
    public InputActionProperty gripAction;
    public Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerValue = pinchAction.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerValue);
        float gripValue = gripAction.action.ReadValue<float>();
        animator.SetFloat("Grip", gripValue);
        
    }
}
