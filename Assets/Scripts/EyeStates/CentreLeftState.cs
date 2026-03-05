using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreLeftState : BaseEyeState
{
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(30, 0, 0);
    }

    public override void UpdateState(EyeController ec)
    {
        
    }

    public override void Up(EyeController ec)
    {
        ec.TransitionToState(ec.tls);
    }

    public override void Down(EyeController ec)
    {
        ec.TransitionToState(ec.bls);
    }

    public override void Left(EyeController ec)
    {
        
    }

    public override void Right(EyeController ec)
    {
        ec.TransitionToState(ec.ccs);
    }
}
