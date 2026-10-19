using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    public InputActionProperty gripAction;
    public InputActionProperty triggerAction;
    public Animator animator;

    void OnEnable()
    {
        gripAction.action.Enable();
        triggerAction.action.Enable();
    }

    void Update()
    {
        float grip = gripAction.action.ReadValue<float>();
        if (Keyboard.current != null && Keyboard.current.gKey.isPressed)
            grip = 1f;

        if (Keyboard.current != null && Keyboard.current.hKey.wasPressedThisFrame)
            Debug.Log("H apasat");


        animator.SetFloat("Grip", grip);
        animator.SetFloat("Trigger", triggerAction.action.ReadValue<float>());
    }
}