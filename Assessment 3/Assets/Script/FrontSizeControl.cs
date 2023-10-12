using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FrontSizeControl : MonoBehaviour
{
    public Slider slider;
    public Text text;
    public void Volume()
    {
        text.fontSize =(int) (slider.value *36);
        
    }
}
