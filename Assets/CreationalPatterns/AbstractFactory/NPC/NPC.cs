using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class NPC : MonoBehaviour
{
    private SpriteRenderer _spriteRenderer;

    private void Awake()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Init(NPCFactory factory)
    {
        factory.GetMovement().Move(transform);
        factory.GetDesign().Set(_spriteRenderer);
    }
}
