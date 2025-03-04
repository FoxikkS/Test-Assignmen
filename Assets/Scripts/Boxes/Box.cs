using UnityEngine;

public class Box : MonoBehaviour
{
    public Animator animator;

    void CloseBox() { animator.SetTrigger("Close"); }
    
    void OpenBox() { animator.SetTrigger("Open"); }
}
