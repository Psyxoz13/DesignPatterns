public class LoopStreifBirdNPC : NPCFactory
{
    public LoopStreifBirdNPC(DesignCollection designCollection) : base(designCollection)
    {
    }

    public override Design GetDesign()
    {
        return new BirdDesign(_designCollection);
    }

    public override Movement GetMovement()
    {
        return new LoopStreifMovement();
    }
}
