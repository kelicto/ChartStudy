/*
 * MIT License
 *
 * Copyright(c) 2019 KeLi
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

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
	 |  |              Email: kelistudy@163.com              |  |  |     |         |      |
	 |  |              Creation Time: 10/30/2019 01:09:39 PM |  |  |     |         |      |
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

using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using KeLi.ChartStudy.App.Entities;
using KeLi.ChartStudy.App.Properties;

namespace KeLi.ChartStudy.App.Forms
{
    public partial class StudyFrm : Form
    {
        public StudyFrm()
        {
            InitializeComponent();

            SetChartStyle(crtFloorRes);
            SetChartStyle(crtDepRes);
            BindData();
        }

        private void BindData()
        {
            var resDetails = GetResDetailList();

            // Must call ToList method, otherwise runtime error.
            var floors = resDetails.Select(s => s.CategoryName).ToList();
            var usedNums = resDetails.Select(s => s.UsedNum).ToList();
            var usableNums = resDetails.Select(s => s.UsableNum).ToList();
            var reservationNums = resDetails.Select(s => s.ReservationNum).ToList();

            var totalReses = GetTotalResList();

            // Must call ToList method, otherwise runtime error.
            var ctgs = totalReses.Select(s => s.CategoryName).ToList();
            var ctgNums = totalReses.Select(s => s.CategoryNum).ToList();

            // Binding total chart data.
            crtTotalInfo.Series[0].Points.DataBindXY(ctgs, ctgNums);
            crtTotalInfo.Series[0].Points[0].Color = Color.FromArgb(0, 176, 80);
            crtTotalInfo.Series[0].Points[1].Color = Color.FromArgb(255, 192, 0);
            crtTotalInfo.Series[0].Points[2].Color = Color.FromArgb(226, 240, 217);

            // Binding floor chart data.
            crtFloorRes.Series[0].Points.DataBindXY(floors, usedNums);
            crtFloorRes.Series[1].Points.DataBindXY(floors, usableNums);
            crtFloorRes.Series[2].Points.DataBindXY(floors, reservationNums);

            // Binding department chart data.
            crtDepRes.Series[0].Points.DataBindXY(floors, usedNums);
            crtDepRes.Series[1].Points.DataBindXY(floors, usableNums);
        }

        private void SetChartStyle(Chart crt)
        {
            foreach (var seris in crt.Series)
                seris["PointWidth"] = "0.7";

            crt.ChartAreas[0].AxisX.ScaleView.Zoom(1, 10);

            // Enable range selection and zooming end user interface.
            crt.ChartAreas[0].CursorX.IsUserEnabled = true;
            crt.ChartAreas[0].CursorX.IsUserSelectionEnabled = true;

            // Sets scroll bar inside to the axis x.
            crt.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;

            // Clicks bottom or top button to scroll chart bar's size.
            crt.ChartAreas[0].AxisX.ScaleView.SmallScrollSize = 5;

            // Drags scroll button to scroll chart bar's size.
            crt.ChartAreas[0].AxisX.ScaleView.SmallScrollMinSize = 2;

            // To display all label.
            crt.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
        }

        private static List<ResDetail> GetResDetailList()
        {
            var sr = new StringReader(Resources.ResDetailInfo);
            var serializer = new XmlSerializer(typeof(List<ResDetail>));

            return serializer.Deserialize(sr) as List<ResDetail>;
        }

        private static List<ResTotal> GetTotalResList()
        {
            var sr = new StringReader(Resources.ResTotalInfo);
            var serializer = new XmlSerializer(typeof(List<ResTotal>));

            return serializer.Deserialize(sr) as List<ResTotal>;
        }
    }
}