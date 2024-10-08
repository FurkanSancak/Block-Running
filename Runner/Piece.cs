using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Start start;
    public int id;
    public Thread thread;

    bool selected = false;

    public void OnClick()
    {
        if (start.clickable)
        {
            if (selected)
            {
                Deselect();
            }
            else
            {
                Select();
            }
        }
    }

    void Select()
    {
        gameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1);
        selected = true;
        if(start.selectedPiece != null)
        {
            start.selectedPiece.Deselect();
        }
        start.selectedPiece = this;
    }

    public void Deselect()
    {
        gameObject.transform.localScale = Vector3.one;
        selected = false;
        start.selectedPiece = null;
    }
}
