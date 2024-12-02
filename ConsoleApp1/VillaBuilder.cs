class VillaBuilder : IBnbBuilder
{
    List<string> BnbFeatures = new List<string>();

    public void buildland()
    {
        BnbFeatures.Add("A big Villa (4000 square feet) 6 Bed rooms");
    }
    public void reset()
    {
        this.BnbFeatures.Clear();
    }
    public void buildPool()
    {
        BnbFeatures.Add("Big Pool Available");
    }
    public void buildGarden()
    {
        BnbFeatures.Add("A nice Big garden");
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