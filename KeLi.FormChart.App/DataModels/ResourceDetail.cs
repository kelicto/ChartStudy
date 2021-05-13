namespace KeLi.FormChart.App.DataModels
{
    public class ResourceDetail
    {
        public ResourceDetail()
        {
        }

        public ResourceDetail(string categoryName, int usedNum, int usableNum, int reservationNum)
        {
            CategoryName = categoryName;
            UsedNum = usedNum;
            UsableNum = usableNum;
            ReservationNum = reservationNum;
        }

        public string CategoryName { get; set; }

        public int UsedNum { get; set; }

        public int UsableNum { get; set; }

        public int ReservationNum { get; set; }
    }
}