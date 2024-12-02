class BnbDirector
{
    private IBnbBuilder bnbBuilder;
    public BnbDirector(IBnbBuilder builderType)
    {
        this.bnbBuilder = builderType;
    }
    public List<string> makeSmallBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();

    }
    public List<string> makeMidBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();
    }
    public List<string> makeBigBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();
    }
    public List<string> makeVillaBnb()
    {
        this.bnbBuilder.buildland();
        this.bnbBuilder.buildGarden();
        this.bnbBuilder.buildPool();
        this.bnbBuilder.buildFence();
        return this.bnbBuilder.getBNB();
    }
}