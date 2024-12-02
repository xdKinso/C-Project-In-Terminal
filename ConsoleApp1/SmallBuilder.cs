class smallBnbBuilder : IBnbBuilder
{
    List<string> BnbFeatures = new List<string>();

    public void buildland()
    {
        BnbFeatures.Add("Small flat (550 square feet)");
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
        BnbFeatures.Add("No garden");
    }
    public void buildFence()
    {
        BnbFeatures.Add("small fence on the front of the flat");
    }
    public List<string> getBNB()
    {
        return this.BnbFeatures;
    }
}