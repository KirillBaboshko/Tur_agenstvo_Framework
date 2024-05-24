namespace Tur_agenstvo_Framework
{
    partial class FormDiagram
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDiagram));
            this.ChartTurName = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.ChartCost = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTurName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCost)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartTurName
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartTurName.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartTurName.Legends.Add(legend1);
            this.ChartTurName.Location = new System.Drawing.Point(152, 120);
            this.ChartTurName.Name = "ChartTurName";
            this.ChartTurName.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartTurName.Series.Add(series1);
            this.ChartTurName.Size = new System.Drawing.Size(481, 432);
            this.ChartTurName.TabIndex = 0;
            this.ChartTurName.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(191, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Диаграмма по направлениям";
            // 
            // ChartCost
            // 
            chartArea2.Name = "ChartArea1";
            this.ChartCost.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChartCost.Legends.Add(legend2);
            this.ChartCost.Location = new System.Drawing.Point(774, 150);
            this.ChartCost.Name = "ChartCost";
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series2.Legend = "Legend1";
            series2.Name = "Стоимость тура относительно персон";
            series2.YValuesPerPoint = 2;
            this.ChartCost.Series.Add(series2);
            this.ChartCost.Size = new System.Drawing.Size(687, 376);
            this.ChartCost.TabIndex = 2;
            this.ChartCost.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1265, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(848, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = "Диаграмма относительно стоимости";
            // 
            // FormDiagram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 600);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ChartCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartTurName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDiagram";
            this.Text = "Диагрммы и графики";
            ((System.ComponentModel.ISupportInitialize)(this.ChartTurName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartCost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTurName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}