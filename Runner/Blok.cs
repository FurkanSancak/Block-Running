using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blok : MonoBehaviour
{
    public Sprite[] sprite;
    public Action action = () => {};
    public void SetMethod(int _)
    {
        gameObject.GetComponent<Image>().sprite = sprite[_];
        switch (_)
        {
            case 0:
                action = () =>
                {};
                break;
            case 1:
                action = () =>
                {
                    gameObject.transform.localPosition += new Vector3(Time.deltaTime*130, 0, 0);
                };
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        action();
    }
}
