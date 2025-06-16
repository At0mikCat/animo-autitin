using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveForward : MonoBehaviour
{
    // Start is called before the first frame update
    public Ease ease;
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void MoveCharacter1()
    {
        DOTween.KillAll();
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -8.52000046f), 0);
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -16.52000046f), 4).SetEase(ease).OnComplete(AfterMove1);
        GetComponent<Animator>().SetBool("walking", true);
    }

    public void AfterMove1()
    {
        MoveCharacter2();
    }
    
    
    public void MoveCharacter2()
    {
        DOTween.KillAll();
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -35.52000046f), 0);
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -42.52000046f), 4).SetEase(ease).OnComplete(AfterMove2);
        GetComponent<Animator>().SetBool("walking", true);
    }
    
    
    public void AfterMove2()
    {
        MoveCharacter3();
    }

    
    
    public void MoveCharacter3()
    {
        DOTween.KillAll();
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -55.87f), 0);
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -65.52000046f), 4).SetEase(ease).OnComplete(AfterMove3);
        GetComponent<Animator>().SetBool("walking", true);
    }
    
    
    public void AfterMove3()
    {
        MoveCharacter4();
    }


    public void MoveCharacter4()
    {
        DOTween.KillAll();
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -80.87f), 0);
        transform.DOMove(new Vector3(-68.2300034f, -7.55999994f, -100.52000046f), 3).SetEase(ease);
        GetComponent<Animator>().SetBool("running", true);
    }
}
