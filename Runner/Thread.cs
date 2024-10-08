using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thread : MonoBehaviour
{
    public bool isActive = false;
    public Thread next;
    public End end;
    public Blok blok;
    float activeTime;
    public Piece piece;
    public Start start;

    void Update()
    {
        if (isActive)
        {
            activeTime += Time.deltaTime;
            if(activeTime > 1)
            {
                Deactivate();
            }
        }
    }

    public void Activate(Blok _blok) {

        isActive = true;
        gameObject.transform.localScale = new Vector3(1.1f, 1.1f, 1);
        blok = _blok;
            blok.SetMethod(piece == null ? 0 : piece.id);
    }

    public void Deactivate()
    {

        isActive = false;
        gameObject.transform.localScale = Vector3.one;
        if(next == null)
        {
            end.Activate(blok);
        }
        else
        {
            next.Activate(blok);
        }
        
    }

    public void OnClick()
    {
        if(start.selectedPiece != null && start.clickable)
        {
            piece = start.selectedPiece;
            piece.Deselect();
            piece.gameObject.transform.SetParent(gameObject.transform);
            piece.gameObject.transform.SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
            if( piece.thread)
            {
                piece.thread.piece = null;
            }
            piece.thread = this;
        }
    }
}
