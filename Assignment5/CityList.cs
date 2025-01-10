public static class CityList
{
    public static List<Cities> list = new List<Cities>();
    public static void addcity(Cities c)
    {
        list.Add(c);
    }
    public static List<Cities> getcity(Cities c)
    {
        return list;
    }
}
