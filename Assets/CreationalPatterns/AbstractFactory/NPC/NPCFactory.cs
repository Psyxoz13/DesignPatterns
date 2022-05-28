using UnityEngine;

public abstract class NPCFactory
{
    protected DesignCollection _designCollection;

    protected NPCFactory(DesignCollection designCollection)
    {
        _designCollection = designCollection;
    }

    public abstract Movement GetMovement();
    public abstract Design GetDesign();
}
