using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MovimientoCajon : MonoBehaviour
{
    public Ease easeType;
    public void MoverCajon()
    {
        transform.DOLocalMove(new Vector3(-0.838f, 0.0425553024f, 1.85599995f), 1f).SetEase(easeType);
    }
}

