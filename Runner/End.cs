using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public bool isActive = false;
    public GameObject menu, play, next;
    float activeTime;

    void Update()
    {
        if (isActive)
        {
            activeTime += Time.deltaTime;
            if (activeTime > 1)
            {
                Deactivate();
            }
        }
    }

    public void Activate(Blok blok)
    {

        isActive = true;
        gameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1);
        blok.SetMethod(0);
    }

    public void Deactivate()
    {

        isActive = false;
        gameObject.transform.localScale = Vector3.one;
        play.SetActive(false);
        next.SetActive(true);
        menu.SetActive(true);

    }
}
