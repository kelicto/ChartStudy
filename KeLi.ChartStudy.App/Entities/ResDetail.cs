

/*
			 ,---------------------------------------------------,              ,---------,
		,----------------------------------------------------------,          ,"        ,"|
	  ,"                                                         ,"|        ,"        ,"  |
	 +----------------------------------------------------------+  |      ,"        ,"    |
	 |  .----------------------------------------------------.  |  |     +---------+      |
	 |  | C:\>FILE -INFO                                     |  |  |     | -==----'|      |
	 |  |                                                    |  |  |     |         |      |
	 |  |                                                    |  |  |/----|`---=    |      |
	 |  |              Author: KeLi                          |  |  |     |         |      |
	 |  |              Email: kelicto@protonmail.com         |  |  |     |         |      |
	 |  |              Creation Time:  |  |  |     |         |      |
	 |  | C:\>_                                              |  |  |     | -==----'|      |
	 |  |                                                    |  |  |   ,/|==== ooo |      ;
	 |  |                                                    |  |  |  // |(((( [66]|    ,"
	 |  `----------------------------------------------------'  |," .;'| |((((     |  ,"
	 +----------------------------------------------------------+  ;;  | |         |,"
		/_)_________________________________________________(_/  //'   | +---------+
		   ___________________________/___  `,
		  /  oooooooooooooooo  .o.  oooo /,   \,"-----------
		 / ==ooooooooooooooo==.o.  ooo= //   ,`\--{)B     ,"
		/_==__==========__==_ooo__ooo=_/'   /___________,"
*/

namespace KeLi.ChartStudy.App.Entities
{
    public class ResDetail
    {
        public ResDetail()
        {
        }

        public ResDetail(string categoryName, int usedNum, int usableNum, int reservationNum)
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