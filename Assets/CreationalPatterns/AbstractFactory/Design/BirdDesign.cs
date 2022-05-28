using UnityEngine;

public class BirdDesign : Design
{
    public BirdDesign(DesignCollection designCollection) : base(designCollection)
    {
    }

    public override void Set(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.sprite = _designCollection.GetDesign("Bird");
    }
}
