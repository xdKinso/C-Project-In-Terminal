class bigBuilder : IBnbBuilder
{
    List<string> BnbFeatures = new List<string>();

    public void buildland()
    {
        BnbFeatures.Add("Big house (2000 square feet) 4 Bed rooms");
    }
    public void reset()
    {
        this.BnbFeatures.Clear();
    }
    public void buildPool()
    {
        BnbFeatures.Add("Pool Available");
    }
    public void buildGarden()
    {
        BnbFeatures.Add("A Nice garden");
    }
    public void buildFence()
    {
        BnbFeatures.Add("Medium Metal fence on the front of the flat and around the garden");
    }
    public List<string> getBNB()
    {
        return this.BnbFeatures;
    }
}