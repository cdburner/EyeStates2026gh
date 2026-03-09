using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomCentreState : BaseEyeState
{
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(0, 0, 30);
    }

    public override void UpdateState(EyeController ec)
    {

    }

    public override void Up(EyeController ec)
    {
        ec.TransitionToState(ec.ccs);
    }

    public override void Left(EyeController ec)
    {
        ec.TransitionToState(ec.bls);
    }

    public override void Right(EyeController ec)
    {
        ec.TransitionToState(ec.brs);
    }
}
