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

    public override void UpdateState(EyeController ec)
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            ec.TransitionToState(ec.trs);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            ec.TransitionToState(ec.brs);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ec.TransitionToState(ec.ccs);
        }
    }

    public override void Up(EyeController ec)
    {
        
    }

    public override void Down(EyeController ec)
    {
        
    }

    public override void Left(EyeController ec)
    {
        
    }

    public override void Right(EyeController ec)
    {
        
    }
}
