using DG.Tweening;
using UnityEngine;

public class JumpMovement : Movement
{
    public override void Move(Transform transform)
    {
        Sequence sequence = DOTween.Sequence();

        float startPositionY = transform.position.y;

        sequence.SetLoops(-1, LoopType.Yoyo);
        sequence.Append(
            transform.DOMoveY(
                startPositionY + 2f,
                1f));
    }
}
