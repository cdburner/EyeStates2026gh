using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopLeftState : BaseEyeState
{
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(30, 0, -30);
    }
    
    public override void Down(EyeController ec)
    {
        ec.TransitionToState(ec.cls);
    }

    public override void Right(EyeController ec)
    {
        ec.TransitionToState(ec.tcs);
    }
}
