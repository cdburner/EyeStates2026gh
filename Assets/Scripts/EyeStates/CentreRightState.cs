using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CentreRightState : BaseEyeState
{
    
    public override void EnterState(EyeController ec)
    {
        ec.eye.eulerAngles = new Vector3(-30, 0, 0);
    }
    
    public override void Up(EyeController ec)
    {
        ec.TransitionToState(ec.trs);
    }

    public override void Down(EyeController ec)
    {
        ec.TransitionToState(ec.brs);
    }

    public override void Left(EyeController ec)
    {
        ec.TransitionToState(ec.ccs);
    }
}
