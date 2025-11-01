
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
   [SerializeField] private List<Sprite> _healtPic;
    [SerializeField] private Image _image;


   public void UpdateHealth(int hp)
   {
    if (hp <= 100 && hp >= 81)
    {
            _image.sprite = _healtPic[4];
    }
    else if(hp <= 80 && hp >= 61)
    {
            _image.sprite = _healtPic[3];
    }
        else if(hp <= 60 && hp >= 41)
    {
            _image.sprite = _healtPic[2];
    }
    else if(hp <= 40 && hp >= 21)
    {
            _image.sprite = _healtPic[1];
    }
    else if ( hp <= 20)
    {
            _image.sprite = _healtPic[0];
    }
   
   }
}
