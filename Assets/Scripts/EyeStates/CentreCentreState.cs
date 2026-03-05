using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentreCentreState : BaseEyeState
{
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(0, 0, 0);
    }

    public override void UpdateState(EyeController ec)
    {

    }

    public override void Up(EyeController ec)
    {
        ec.TransitionToState(ec.tcs);
    }

    public override void Down(EyeController ec)
    {
        ec.TransitionToState(ec.bcs);
    }

    public override void Left(EyeController ec)
    {
        ec.TransitionToState(ec.cls);
    }

    public override void Right(EyeController ec)
    {
        ec.TransitionToState(ec.crs);
    }
}
