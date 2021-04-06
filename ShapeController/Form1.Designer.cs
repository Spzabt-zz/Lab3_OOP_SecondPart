namespace ShapeController
{
    partial class Form1
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ySuperDownButton = new System.Windows.Forms.Button();
            this.xSuperRightButton = new System.Windows.Forms.Button();
            this.xSuperLeftButton = new System.Windows.Forms.Button();
            this.ySuperUpButton = new System.Windows.Forms.Button();
            this.createTriangleButton = new System.Windows.Forms.Button();
            this.createCircleButton = new System.Windows.Forms.Button();
            this.xLeftButton = new System.Windows.Forms.Button();
            this.yDownButton = new System.Windows.Forms.Button();
            this.xRightButton = new System.Windows.Forms.Button();
            this.yUpButton = new System.Windows.Forms.Button();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.increaseButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.createSquareButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.objectSelector = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ySuperDownButton);
            this.splitContainer1.Panel1.Controls.Add(this.xSuperRightButton);
            this.splitContainer1.Panel1.Controls.Add(this.xSuperLeftButton);
            this.splitContainer1.Panel1.Controls.Add(this.ySuperUpButton);
            this.splitContainer1.Panel1.Controls.Add(this.createTriangleButton);
            this.splitContainer1.Panel1.Controls.Add(this.createCircleButton);
            this.splitContainer1.Panel1.Controls.Add(this.xLeftButton);
            this.splitContainer1.Panel1.Controls.Add(this.yDownButton);
            this.splitContainer1.Panel1.Controls.Add(this.xRightButton);
            this.splitContainer1.Panel1.Controls.Add(this.yUpButton);
            this.splitContainer1.Panel1.Controls.Add(this.decreaseButton);
            this.splitContainer1.Panel1.Controls.Add(this.increaseButton);
            this.splitContainer1.Panel1.Controls.Add(this.showButton);
            this.splitContainer1.Panel1.Controls.Add(this.hideButton);
            this.splitContainer1.Panel1.Controls.Add(this.createSquareButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.objectSelector);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 681);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            // 
            // ySuperDownButton
            // 
            this.ySuperDownButton.Location = new System.Drawing.Point(155, 637);
            this.ySuperDownButton.Name = "ySuperDownButton";
            this.ySuperDownButton.Size = new System.Drawing.Size(42, 23);
            this.ySuperDownButton.TabIndex = 16;
            this.ySuperDownButton.Text = "Y++";
            this.ySuperDownButton.UseVisualStyleBackColor = true;
            this.ySuperDownButton.Click += new System.EventHandler(this.ySuperDownButton_Click);
            // 
            // xSuperRightButton
            // 
            this.xSuperRightButton.Location = new System.Drawing.Point(251, 564);
            this.xSuperRightButton.Name = "xSuperRightButton";
            this.xSuperRightButton.Size = new System.Drawing.Size(42, 23);
            this.xSuperRightButton.TabIndex = 15;
            this.xSuperRightButton.Text = "-->>";
            this.xSuperRightButton.UseVisualStyleBackColor = true;
            this.xSuperRightButton.Click += new System.EventHandler(this.xSuperRightButton_Click);
            // 
            // xSuperLeftButton
            // 
            this.xSuperLeftButton.Location = new System.Drawing.Point(59, 564);
            this.xSuperLeftButton.Name = "xSuperLeftButton";
            this.xSuperLeftButton.Size = new System.Drawing.Size(42, 23);
            this.xSuperLeftButton.TabIndex = 14;
            this.xSuperLeftButton.Text = "<<--";
            this.xSuperLeftButton.UseVisualStyleBackColor = true;
            this.xSuperLeftButton.Click += new System.EventHandler(this.xSuperLeftButton_Click);
            // 
            // ySuperUpButton
            // 
            this.ySuperUpButton.Location = new System.Drawing.Point(155, 492);
            this.ySuperUpButton.Name = "ySuperUpButton";
            this.ySuperUpButton.Size = new System.Drawing.Size(42, 23);
            this.ySuperUpButton.TabIndex = 13;
            this.ySuperUpButton.Text = "Y- -";
            this.ySuperUpButton.UseVisualStyleBackColor = true;
            this.ySuperUpButton.Click += new System.EventHandler(this.ySuperUpButton_Click);
            // 
            // createTriangleButton
            // 
            this.createTriangleButton.Location = new System.Drawing.Point(183, 174);
            this.createTriangleButton.Name = "createTriangleButton";
            this.createTriangleButton.Size = new System.Drawing.Size(118, 25);
            this.createTriangleButton.TabIndex = 12;
            this.createTriangleButton.Text = "Create triangle";
            this.createTriangleButton.UseVisualStyleBackColor = true;
            this.createTriangleButton.Click += new System.EventHandler(this.createTriangleButton_Click);
            // 
            // createCircleButton
            // 
            this.createCircleButton.Location = new System.Drawing.Point(183, 143);
            this.createCircleButton.Name = "createCircleButton";
            this.createCircleButton.Size = new System.Drawing.Size(118, 25);
            this.createCircleButton.TabIndex = 11;
            this.createCircleButton.Text = "Create circle";
            this.createCircleButton.UseVisualStyleBackColor = true;
            this.createCircleButton.Click += new System.EventHandler(this.createCircleButton_Click);
            // 
            // xLeftButton
            // 
            this.xLeftButton.Location = new System.Drawing.Point(107, 564);
            this.xLeftButton.Name = "xLeftButton";
            this.xLeftButton.Size = new System.Drawing.Size(42, 23);
            this.xLeftButton.TabIndex = 10;
            this.xLeftButton.Text = "<-";
            this.xLeftButton.UseVisualStyleBackColor = true;
            this.xLeftButton.Click += new System.EventHandler(this.xLeftButton_Click);
            // 
            // yDownButton
            // 
            this.yDownButton.Location = new System.Drawing.Point(155, 608);
            this.yDownButton.Name = "yDownButton";
            this.yDownButton.Size = new System.Drawing.Size(42, 23);
            this.yDownButton.TabIndex = 9;
            this.yDownButton.Text = "Y+";
            this.yDownButton.UseVisualStyleBackColor = true;
            this.yDownButton.Click += new System.EventHandler(this.yDownButton_Click);
            // 
            // xRightButton
            // 
            this.xRightButton.Location = new System.Drawing.Point(203, 564);
            this.xRightButton.Name = "xRightButton";
            this.xRightButton.Size = new System.Drawing.Size(42, 23);
            this.xRightButton.TabIndex = 8;
            this.xRightButton.Text = "->";
            this.xRightButton.UseVisualStyleBackColor = true;
            this.xRightButton.Click += new System.EventHandler(this.xRightButton_Click);
            // 
            // yUpButton
            // 
            this.yUpButton.Location = new System.Drawing.Point(155, 521);
            this.yUpButton.Name = "yUpButton";
            this.yUpButton.Size = new System.Drawing.Size(42, 23);
            this.yUpButton.TabIndex = 7;
            this.yUpButton.Text = "Y-";
            this.yUpButton.UseVisualStyleBackColor = true;
            this.yUpButton.Click += new System.EventHandler(this.yUpButton_Click);
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(155, 579);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(42, 23);
            this.decreaseButton.TabIndex = 6;
            this.decreaseButton.Text = "-";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(155, 550);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(42, 23);
            this.increaseButton.TabIndex = 5;
            this.increaseButton.Text = "+";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(183, 314);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(118, 25);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show object";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(183, 283);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(118, 25);
            this.hideButton.TabIndex = 3;
            this.hideButton.Text = "Hide object";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // createSquareButton
            // 
            this.createSquareButton.Location = new System.Drawing.Point(183, 112);
            this.createSquareButton.Name = "createSquareButton";
            this.createSquareButton.Size = new System.Drawing.Size(118, 25);
            this.createSquareButton.TabIndex = 2;
            this.createSquareButton.Text = "Create square";
            this.createSquareButton.UseVisualStyleBackColor = true;
            this.createSquareButton.Click += new System.EventHandler(this.createSquareButton_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вибір об\'єкта";
            // 
            // objectSelector
            // 
            this.objectSelector.FormattingEnabled = true;
            this.objectSelector.Location = new System.Drawing.Point(10, 50);
            this.objectSelector.Name = "objectSelector";
            this.objectSelector.Size = new System.Drawing.Size(149, 21);
            this.objectSelector.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(905, 677);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button xSuperLeftButton;
        private System.Windows.Forms.Button xSuperRightButton;
        private System.Windows.Forms.Button ySuperDownButton;
        private System.Windows.Forms.Button ySuperUpButton;

        private System.Windows.Forms.Button createCircleButton;
        private System.Windows.Forms.Button createTriangleButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button yUpButton;
        private System.Windows.Forms.Button xRightButton;
        private System.Windows.Forms.Button yDownButton;
        private System.Windows.Forms.Button xLeftButton;

        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.Button createSquareButton;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox objectSelector;
        private System.Windows.Forms.Button showButton;

        private System.Windows.Forms.SplitContainer splitContainer1;

        #endregion
    }
}