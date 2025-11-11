using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovementControls : MonoBehaviour
{
    [SerializeField] private Image leftButtonImg;
    [SerializeField] private Image rightButtonImg;
    [SerializeField] private Color colorInactive;
    [SerializeField] private Color colorActive;
    public float Speed = 1;

    public bool MovingLeft { get; private set; }
    public bool MovingRight { get; private set; }

    public void OmPointerEnterLeft()
    {
        MovingLeft = true;
        leftButtonImg.color = colorActive;
    }

    public void OmPointerExitLeft()
    {
        MovingLeft = false;
        leftButtonImg.color = colorInactive;
    }

    public void OmPointerEnterRight()
    {
        MovingRight = true;
        rightButtonImg.color = colorActive;
    }

    public void OmPointerExitRight()
    {
        MovingRight = false;
        rightButtonImg.color = colorInactive;
    }
}
