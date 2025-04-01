using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class SimpleImageBehaviour : MonoBehaviour
{
    public Image imageObj;
    public SimpleFloatData dataObj;
    // Start is called before the first frame update
    void Start()
    {
        imageObj = GetComponent<Image>();
    }

    // Update is called once per frame
    public void UpdateWithFloatData()
    {
        imageObj.fillAmount = dataObj.value;
    }


}
