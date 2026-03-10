using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopRightState : BaseEyeState
{
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(-30, 0, -30);
    }

    public override void Down(EyeController ec)
    {
        ec.TransitionToState(ec.crs);
    }

    public override void Left(EyeController ec)
    {
        ec.TransitionToState(ec.tcs);
    }
}
