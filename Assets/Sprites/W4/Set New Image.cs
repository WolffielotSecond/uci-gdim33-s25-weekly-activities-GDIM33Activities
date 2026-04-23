using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetNewImage : MonoBehaviour
{
    // Start is called before the first frame update
    public Image targetImage;
    public void SetDesiredImage(Sprite HeadBig)
    {
        targetImage.sprite = HeadBig;
    }
}
