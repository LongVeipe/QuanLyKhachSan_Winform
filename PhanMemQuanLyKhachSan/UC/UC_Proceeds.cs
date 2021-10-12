using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PhanMemQuanLyKhachSan.UC
{
    public partial class UC_Proceeds : UserControl
    {
        public UC_Proceeds()
        {
            InitializeComponent();
        }

        #region method
        void InitChart()
        {
            for (int i = 0; i < 12; i++)
            {
                this.chart_YearProceeds.Series[0].Points.AddXY((i + 1).ToString(), 0);
            }
        }
        void LoadYearChart()
        {
            this.chart_YearProceeds.Titles[0].Text = "Doanh thu năm " + this.dateTimePicker_Onlyear.Value.Year.ToString();
            DataTable data = DAO.BillDAO.Instance.GetProceedsByYear(this.dateTimePicker_Onlyear.Value.Year.ToString());

            if (data.Rows.Count == 0)
            {
                InitChart();
                return;
            }
            if (this.panel_MonthChart.Size.Width == 0)
                this.chart_MonthProceeds.Series.Clear();

            int iRow = 0;
            for (int i = 1; i < 13; i++)
            {
                if (i.ToString() == data.Rows[iRow]["Thang"].ToString())
                {
                    this.chart_YearProceeds.Series[0].Points.AddXY(i.ToString(), Convert.ToDouble(data.Rows[iRow]["Total"].ToString()));
                    if (iRow < data.Rows.Count - 1)
                        iRow++;
                    LoadMonthChart(i.ToString());
                }
                else
                    this.chart_YearProceeds.Series[0].Points.AddXY(i.ToString(), 0);
            }
        }

        void LoadMonthChart(string month)
        {
            if (chart_MonthProceeds.Series.IndexOf("Tháng " + month) != -1)
                return;
            DataTable data = DAO.BillDAO.Instance.GetProceedsByMonth(this.dateTimePicker_Onlyear.Value.Year.ToString(), month);
            if (data.Rows.Count == 0)
                return;
            Series series = new Series();
            series.ChartType = SeriesChartType.Line;
            series.Name = "Tháng " + month;
            chart_MonthProceeds.Series.Add(series);
            int iRow = 0;
            switch (month)
            {
                case "1":
                case "3":
                case "5":
                case "7":
                case "8":
                case "10":
                case "12":
                    for (int i = 1; i < 32; i++)
                    {
                        if (i.ToString() == data.Rows[iRow]["Ngay"].ToString())
                        {
                            chart_MonthProceeds.Series["Tháng " + month].Points.AddXY(i.ToString(), Convert.ToDouble(data.Rows[iRow]["Total"].ToString()));
                            if (iRow < data.Rows.Count - 1)
                                iRow++;
                        }
                        else
                            chart_MonthProceeds.Series["Tháng " + month].Points.AddXY(i.ToString(), 0);
                    }
                    break;
                case "4":
                case "6":
                case "9":
                case "11":
                    for (int i = 1; i < 31; i++)
                    {
                        if (i.ToString() == data.Rows[iRow]["Ngay"].ToString())
                        {
                            chart_MonthProceeds.Series["Tháng " + month].Points.AddXY(i.ToString(), Convert.ToDouble(data.Rows[iRow]["Total"].ToString()));
                            if (iRow < data.Rows.Count - 1)
                                iRow++;
                        }
                        else
                            chart_MonthProceeds.Series["Tháng " + month].Points.AddXY(0, 0);
                    }
                    break;
                case "2":
                    for (int i = 1; i < 30; i++)
                    {
                        if (i.ToString() == data.Rows[iRow]["Ngay"].ToString())
                        {
                            chart_MonthProceeds.Series["Tháng " + month].Points.AddXY(i.ToString(), Convert.ToDouble(data.Rows[iRow]["Total"].ToString()));
                            if (iRow < data.Rows.Count - 1)
                                iRow++;
                        }
                        else
                            chart_MonthProceeds.Series["Tháng " + month].Points.AddXY(0, 0);
                    }
                    break;
            }

        }

        //int ColumnSelected(int x)
        //{
        //    if (this.chart_YearProceeds.Size.Width == 840)
        //    {
        //        for (int i = 0; i < 12; i++)
        //            if (x > (170 + 65.454545 * (i + 1) - 27) && x < (172 + 65.454545 * (i + 1) + 27))
        //                return i;
        //    }
        //    else
        //    {
        //        for (int i = 0; i < 12; i++)
        //            if (x > (144 + 34.363636 * (i + 1) - 14) && x < (144 + 34.363636 * (i + 1) + 14))
        //                return i;
        //    }
        //    return -1;
        //}
        //Double MaxYValue(DataTable data)
        //{

        //    Double max = Convert.ToDouble(data.Rows[0]["Total"].ToString());
        //    int imax = 0;
        //    for (int i = 1; i < data.Rows.Count; i++)
        //    {
        //        Double Total = Convert.ToDouble(data.Rows[i]["Total"].ToString());
        //        if (Total > max)
        //        {
        //            max = Total;
        //            imax = i;
        //        }
        //    }
        //    return max;
        //}
        #endregion

        private void button_Check_Click(object sender, EventArgs e)
        {
            this.panel_MonthChart.Size = new Size(0, this.Height - 10);
            this.chart_YearProceeds.Series[0].Points.Clear();
            LoadYearChart();
            if (DAO.BillDAO.Instance.GetProceedsByYear(this.dateTimePicker_Onlyear.Value.Year.ToString()).Rows.Count != 0)
                this.chart_YearProceeds.Enabled = true;
            else
                this.chart_YearProceeds.Enabled = false;
        }

        private void chart_YearProceeds_MouseClick(object sender, MouseEventArgs e)
        {
            
            this.panel_MonthChart.Size = new Size(473, 565);

            //int Column = ColumnSelected(e.X);
            //if (Column == -1)
            //    return;
            //DataTable data = DAO.BillDAO.Instance.GetProceedsByYear(this.dateTimePicker_Onlyear.Value.Year.ToString());
            //if (data.Rows.Count == 0)
            //    return;
            //MessageBox.Show(Column.ToString());
            //Double maxValue = MaxYValue(data); //Doanh thu cao nhat
            //for (int i = 0; i < data.Rows.Count; i++) // Tìm tháng được click
            //{
            //    string month = data.Rows[i]["Thang"].ToString();
            //    if ((Column + 1).ToString() == month)// đã tìm được tháng click trong data
            //    {
            //        Double yValue = Convert.ToDouble(data.Rows[i]["Total"].ToString());
            //        if (e.Y < 707 && e.Y > 707 - (yValue / maxValue) * 471) // e.Y nằm trong khoảng vẽ cột
            //        {
            //            if (this.panel_MonthChart.Size.Width == 0)
            //                this.chart_MonthProceeds.Series.Clear();
            //            this.panel_MonthChart.Size = new Size(355, 565);
            //            LoadMonthChart(month);
            //        }
            //        return;
            //    }
            //}
        }

        private void chart_MonthProceeds_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(this.chart_MonthProceeds.Series[0].ChartType.ToString());
        }
    }
}
