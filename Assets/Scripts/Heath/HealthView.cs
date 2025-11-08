
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private List<Sprite> _healtPic;
    [SerializeField] private Image _image;

    private void Start()
    {
      
    }

    public void UpdateHealth(int hp)
   {
     if (hp == 5)
     {
            _image.sprite = _healtPic[4];
     }
     else if(hp == 4)
     {
            _image.sprite = _healtPic[3];
     }
     else if(hp == 3)
     {
            _image.sprite = _healtPic[2];
     }
     else if(hp == 2)
     {
            _image.sprite = _healtPic[1];
     }
     else if (hp == 1)
     {
            _image.sprite = _healtPic[0];
     }
    else if (hp == 0)
     {
            _image.sprite = _healtPic[5];
     }
   }
}
