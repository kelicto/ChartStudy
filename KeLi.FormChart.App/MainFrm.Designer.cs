namespace KeLi.FormChart.App
{
    partial class StudyFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.crtTotalInfo = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtFloorRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.crtDepRes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.crtTotalInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtFloorRes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtDepRes)).BeginInit();
            this.SuspendLayout();
            // 
            // crtTotalInfo
            // 
            chartArea4.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal;
            chartArea4.Name = "ChartArea1";
            this.crtTotalInfo.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend4.IsTextAutoFit = false;
            legend4.Name = "Legend1";
            this.crtTotalInfo.Legends.Add(legend4);
            this.crtTotalInfo.Location = new System.Drawing.Point(12, 13);
            this.crtTotalInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crtTotalInfo.Name = "crtTotalInfo";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series7.CustomProperties = "PieLineColor=Black, PieLabelStyle=Outside";
            series7.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series7.IsValueShownAsLabel = true;
            series7.Label = "#VALX: #VAL";
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.crtTotalInfo.Series.Add(series7);
            this.crtTotalInfo.Size = new System.Drawing.Size(389, 295);
            this.crtTotalInfo.TabIndex = 2;
            this.crtTotalInfo.Text = "chart3";
            title4.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(217)))));
            title4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            title4.Name = "Title1";
            title4.Text = "资源总览";
            this.crtTotalInfo.Titles.Add(title4);
            // 
            // crtFloorRes
            // 
            this.crtFloorRes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.WordWrap;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            chartArea5.AxisX.LabelStyle.Interval = 1D;
            chartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea5.AxisX.MajorGrid.Enabled = false;
            chartArea5.AxisX.MajorTickMark.Enabled = false;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea5.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.Name = "ChartArea1";
            this.crtFloorRes.ChartAreas.Add(chartArea5);
            legend5.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.ForeColor = System.Drawing.Color.Gray;
            legend5.IsTextAutoFit = false;
            legend5.Name = "Legend1";
            this.crtFloorRes.Legends.Add(legend5);
            this.crtFloorRes.Location = new System.Drawing.Point(407, 13);
            this.crtFloorRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crtFloorRes.Name = "crtFloorRes";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            series8.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "已用";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            series9.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series9.IsValueShownAsLabel = true;
            series9.LabelForeColor = System.Drawing.Color.White;
            series9.Legend = "Legend1";
            series9.Name = "可用";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series10.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series10.IsValueShownAsLabel = true;
            series10.Legend = "Legend1";
            series10.Name = "预留";
            this.crtFloorRes.Series.Add(series8);
            this.crtFloorRes.Series.Add(series9);
            this.crtFloorRes.Series.Add(series10);
            this.crtFloorRes.Size = new System.Drawing.Size(578, 295);
            this.crtFloorRes.TabIndex = 0;
            this.crtFloorRes.Text = "chart1";
            title5.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(217)))));
            title5.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            title5.Name = "Title1";
            title5.Text = "各楼层可用资源预览";
            this.crtFloorRes.Titles.Add(title5);
            // 
            // crtDepRes
            // 
            this.crtDepRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelStyle.Angle = -45;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            chartArea6.AxisX.LabelStyle.IsEndLabelVisible = false;
            chartArea6.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea6.AxisX.MajorGrid.Enabled = false;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.Empty;
            chartArea6.AxisX.MajorTickMark.Enabled = false;
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea6.AxisX.MinorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            chartArea6.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea6.Name = "ChartArea1";
            this.crtDepRes.ChartAreas.Add(chartArea6);
            legend6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.ForeColor = System.Drawing.Color.Gray;
            legend6.IsTextAutoFit = false;
            legend6.Name = "Legend1";
            this.crtDepRes.Legends.Add(legend6);
            this.crtDepRes.Location = new System.Drawing.Point(12, 316);
            this.crtDepRes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.crtDepRes.Name = "crtDepRes";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            series11.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series11.IsValueShownAsLabel = true;
            series11.Legend = "Legend1";
            series11.Name = "已用";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(80)))));
            series12.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.IsValueShownAsLabel = true;
            series12.LabelForeColor = System.Drawing.Color.White;
            series12.Legend = "Legend1";
            series12.Name = "可用";
            this.crtDepRes.Series.Add(series11);
            this.crtDepRes.Series.Add(series12);
            this.crtDepRes.Size = new System.Drawing.Size(973, 259);
            this.crtDepRes.TabIndex = 0;
            this.crtDepRes.Text = "chart1";
            title6.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            title6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(240)))), ((int)(((byte)(217)))));
            title6.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            title6.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            title6.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
            title6.Name = "Title1";
            title6.Text = "部门可用资源预览";
            this.crtDepRes.Titles.Add(title6);
            // 
            // FrmStudy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 588);
            this.Controls.Add(this.crtTotalInfo);
            this.Controls.Add(this.crtFloorRes);
            this.Controls.Add(this.crtDepRes);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStudy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "图表研究";
            ((System.ComponentModel.ISupportInitialize)(this.crtTotalInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtFloorRes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.crtDepRes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart crtTotalInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtFloorRes;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtDepRes;
    }
}

