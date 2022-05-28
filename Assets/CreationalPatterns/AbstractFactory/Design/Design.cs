using UnityEngine;

public abstract class Design
{
    protected DesignCollection _designCollection;

    protected Design(DesignCollection designCollection)
    {
        _designCollection = designCollection;
    }

    public abstract void Set(SpriteRenderer spriteRenderer);
}
