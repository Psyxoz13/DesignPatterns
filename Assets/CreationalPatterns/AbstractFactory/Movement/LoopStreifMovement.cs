using DG.Tweening;
using UnityEngine;

public class LoopStreifMovement : Movement
{
    public override void Move(Transform transform)
    {
        transform.DOMoveX(
            transform.position.x - 2f,
            1f)
            .SetLoops(
                -1,
                LoopType.Yoyo);
    }
}
