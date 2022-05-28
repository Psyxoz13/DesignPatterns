public class JumpingCowboyNPC : NPCFactory
{
    public JumpingCowboyNPC(DesignCollection designCollection) : base(designCollection)
    {
    }

    public override Design GetDesign()
    {
        return new CowboyDesign(_designCollection);
    }

    public override Movement GetMovement()
    {
        return new JumpMovement();
    }
}
