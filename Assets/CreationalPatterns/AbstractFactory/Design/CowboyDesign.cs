using UnityEngine;

public class CowboyDesign : Design
{
    public CowboyDesign(DesignCollection designCollection) : base(designCollection)
    {
    }

    public override void Set(SpriteRenderer spriteRenderer)
    {
        spriteRenderer.sprite = _designCollection.GetDesign("Cowboy");
    }
}
