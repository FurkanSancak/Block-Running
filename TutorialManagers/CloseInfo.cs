using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInfo : MonoBehaviour
{
    public GameObject info;

    public void Close()
    {
        info.SetActive(false);
    }
}
