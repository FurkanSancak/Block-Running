using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial1Manager : MonoBehaviour
{
    public GameObject info1, info2;
    public Animator animator;

    public void CloseInfo1()
    {
        info1.SetActive(false);
        info2.SetActive(true);
    }

    public void CloseInfo2()
    {
        info2.SetActive(false);
        animator.SetBool("active", true);
    }

    public void Started()
    {
        animator.SetBool("active", false);
    }
}
