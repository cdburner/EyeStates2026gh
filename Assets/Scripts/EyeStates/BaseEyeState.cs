
using UnityEngine;

public abstract class BaseEyeState
{
    public virtual void EnterState(EyeController ec) { }
    public virtual void Up(EyeController ec)  { }
    public virtual void Down(EyeController ec)  { }
    public virtual void Left(EyeController ec)  { }
    public virtual void Right(EyeController ec) { }
}
