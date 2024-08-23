using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour
{
    public bool clickable;
    public GameObject thread;
    public Blok blok;
    public Piece selectedPiece;

    public void onClick()
    {
        if (clickable)
        {
            thread.GetComponent<Thread>().Activate(blok);
            clickable = false;
        }
    }
}