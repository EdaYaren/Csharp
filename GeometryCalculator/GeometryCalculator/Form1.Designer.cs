namespace GeometryCalculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxSquareEdge = new System.Windows.Forms.TextBox();
            this.labelSquareArea = new System.Windows.Forms.Label();
            this.textBoxRectangleLongEdge = new System.Windows.Forms.TextBox();
            this.textBoxRectangleShortEdge = new System.Windows.Forms.TextBox();
            this.labelRectangleArea = new System.Windows.Forms.Label();
            this.textBoxCircleRadius = new System.Windows.Forms.TextBox();
            this.labelCircleArea = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxSquareEdge
            // 
            resources.ApplyResources(this.textBoxSquareEdge, "textBoxSquareEdge");
            this.textBoxSquareEdge.Name = "textBoxSquareEdge";
            // 
            // labelSquareArea
            // 
            resources.ApplyResources(this.labelSquareArea, "labelSquareArea");
            this.labelSquareArea.Name = "labelSquareArea";
            // 
            // textBoxRectangleLongEdge
            // 
            resources.ApplyResources(this.textBoxRectangleLongEdge, "textBoxRectangleLongEdge");
            this.textBoxRectangleLongEdge.Name = "textBoxRectangleLongEdge";
            // 
            // textBoxRectangleShortEdge
            // 
            resources.ApplyResources(this.textBoxRectangleShortEdge, "textBoxRectangleShortEdge");
            this.textBoxRectangleShortEdge.Name = "textBoxRectangleShortEdge";
            // 
            // labelRectangleArea
            // 
            resources.ApplyResources(this.labelRectangleArea, "labelRectangleArea");
            this.labelRectangleArea.Name = "labelRectangleArea";
            // 
            // textBoxCircleRadius
            // 
            resources.ApplyResources(this.textBoxCircleRadius, "textBoxCircleRadius");
            this.textBoxCircleRadius.Name = "textBoxCircleRadius";
            // 
            // labelCircleArea
            // 
            resources.ApplyResources(this.labelCircleArea, "labelCircleArea");
            this.labelCircleArea.Name = "labelCircleArea";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBoxSquareEdge);
            this.panel1.Controls.Add(this.labelSquareArea);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelRectangleArea);
            this.panel2.Controls.Add(this.textBoxRectangleShortEdge);
            this.panel2.Controls.Add(this.textBoxRectangleLongEdge);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Plum;
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.labelCircleArea);
            this.panel3.Controls.Add(this.textBoxCircleRadius);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // pictureBox3
            // 
            resources.ApplyResources(this.pictureBox3, "pictureBox3");
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Name = "label5";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MediumPurple;
            this.panel4.Controls.Add(this.label5);
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlText;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private TextBox textBoxSquareEdge;
        private Label labelSquareArea;
        private TextBox textBoxRectangleLongEdge;
        private TextBox textBoxRectangleShortEdge;
        private Label labelRectangleArea;
        private TextBox textBoxCircleRadius;
        private Label labelCircleArea;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Panel panel4;
    }
}