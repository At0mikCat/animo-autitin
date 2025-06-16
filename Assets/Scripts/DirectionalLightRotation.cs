using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DirectionalLightRotation : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
    }

    public void RotateLight()
    {
        transform.DOLocalRotate(new Vector3(357.212433f,266.847504f,267.529846f), 20f);
    }
}
