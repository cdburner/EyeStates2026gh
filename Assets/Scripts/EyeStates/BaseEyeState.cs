
using UnityEngine;

public abstract class BaseEyeState
{
    public abstract void EnterState(EyeController ec);
    public abstract void UpdateState(EyeController ec);
    public abstract void Up(EyeController ec);
    public abstract void Down(EyeController ec);
    public abstract void Left(EyeController ec);
    public abstract void Right(EyeController ec);
}
