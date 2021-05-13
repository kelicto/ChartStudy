namespace KeLi.FormChart.App.DataModels
{
    public class ResourceTotal
    {
        public ResourceTotal()
        {
        }

        public ResourceTotal(string categoryName, int categoryNum)
        {
            CategoryName = categoryName;
            CategoryNum = categoryNum;
        }

        public string CategoryName { get; set; }

        public int CategoryNum { get; set; }
    }
}