using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece : MonoBehaviour
{
    public Start start;
    public int id;

    bool selected = false;

    public void OnClick()
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

    void Select()
    {
        gameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1);
        selected = true;
        start.selectedPiece = this;
    }

    public void Deselect()
    {
        gameObject.transform.localScale = Vector3.one;
        selected = false;
        start.selectedPiece = null;
    }
}
