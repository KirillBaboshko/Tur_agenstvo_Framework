using System.Drawing;
using System.Windows.Forms;

namespace Tur_agenstvo_Framework
{
    partial class FormEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEdit));
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.Butt = new Tur_agenstvo_Framework.GoodButton();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(61, 68);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(564, 184);
            this.checkedListBox1.TabIndex = 0;
            // 
            // Butt
            // 
            this.Butt.BackColor = System.Drawing.Color.Lavender;
            this.Butt.BackgroundColor = System.Drawing.Color.Lavender;
            this.Butt.BorderColor = System.Drawing.Color.DimGray;
            this.Butt.BorderRadius = 20;
            this.Butt.BorderSize = 2;
            this.Butt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Butt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Butt.ForeColor = System.Drawing.Color.Black;
            this.Butt.Location = new System.Drawing.Point(262, 298);
            this.Butt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Butt.Name = "Butt";
            this.Butt.Size = new System.Drawing.Size(194, 56);
            this.Butt.TabIndex = 1;
            this.Butt.Text = "Редактировать выбранную запись";
            this.Butt.TextColor = System.Drawing.Color.Black;
            this.Butt.UseVisualStyleBackColor = true;
            this.Butt.Click += new System.EventHandler(this.Butt_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.Butt);
            this.Controls.Add(this.checkedListBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormEdit";
            this.Text = "Редактирование";
            this.ResumeLayout(false);

        }

        #endregion

        private CheckedListBox checkedListBox1;
        private GoodButton Butt;
    }
}