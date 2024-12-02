class midBuilder : IBnbBuilder
{
    List<string> BnbFeatures = new List<string>();

    public void buildland()
    {
        BnbFeatures.Add("Medium flat (1000 square feet) 2 Bed rooms");
    }
    public void reset()
    {
        this.BnbFeatures.Clear();
    }
    public void buildPool()
    {
        BnbFeatures.Add("No pool Available");
    }
    public void buildGarden()
    {
        BnbFeatures.Add("A nice garden");
    }
    public void buildFence()
    {
        BnbFeatures.Add("small fence on the front of the flat and around the garden");
    }
    public List<string> getBNB()
    {
        return this.BnbFeatures;
    }
}