using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopCentreState : BaseEyeState
{
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(0, 0, -30f);
    }

    public override void Down(EyeController ec)
    {
        ec.TransitionToState(ec.ccs);
    }

    public override void Left(EyeController ec)
    {
        ec.TransitionToState(ec.tls);
    }

    public override void Right(EyeController ec)
    {
        ec.TransitionToState(ec.trs);
    }
}
