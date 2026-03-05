using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class EyeController : MonoBehaviour
{
    public Transform eye;

    public InputAction upAction = new InputAction("upArrow", binding: "<Keyboard>/w");
    public InputAction downAction = new InputAction("downArrow", binding: "<Keyboard>/s");
    public InputAction leftAction = new InputAction("leftArrow", binding: "<Keyboard>/a");
    public InputAction rightAction = new InputAction("rightArrow", binding: "<Keyboard>/d");

    
    public BaseEyeState currentState;
    public readonly CentreCentreState ccs = new CentreCentreState();
    public readonly CentreLeftState cls = new CentreLeftState();
    public readonly CentreRightState crs = new CentreRightState();
    public readonly BottomCentreState bcs= new BottomCentreState();
    public readonly BottomLeftState bls= new BottomLeftState();
    public readonly BottomRightState brs= new BottomRightState();
    public readonly TopCentreState tcs = new TopCentreState();
    public readonly TopLeftState tls = new TopLeftState();
    public readonly TopRightState trs = new TopRightState();
    
    // Start is called before the first frame update
    void Start()
    {
        upAction.Enable();
        downAction.Enable();
        leftAction.Enable();
        rightAction.Enable();
        TransitionToState(ccs);
    }

    // Update is called once per frame
    void Update()
    {
        currentState.UpdateState(this);
    }

    public void TransitionToState(BaseEyeState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    public void OnUp()
    {
        currentState.Up(this);
    }
    public void OnDown()
    {
        currentState.Down(this);
    }
    public void OnLeft()
    {
        currentState.Left(this);
    }
    public void OnRight()
    {
        currentState.Right(this);
    }
}
