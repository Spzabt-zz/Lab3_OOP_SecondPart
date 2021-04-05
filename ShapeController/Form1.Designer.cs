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
            this.createTriangleButton = new System.Windows.Forms.Button();
            this.createCircleButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.createTriangleButton);
            this.splitContainer1.Panel1.Controls.Add(this.createCircleButton);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(74, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "<-";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(141, 608);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "| -";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(203, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 521);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "I +";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(155, 579);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(42, 23);
            this.decreaseButton.TabIndex = 6;
            this.decreaseButton.Text = "-";
            this.decreaseButton.UseVisualStyleBackColor = true;
            // 
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(155, 550);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(42, 23);
            this.increaseButton.TabIndex = 5;
            this.increaseButton.Text = "+";
            this.increaseButton.UseVisualStyleBackColor = true;
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

        private System.Windows.Forms.Button createCircleButton;
        private System.Windows.Forms.Button createTriangleButton;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

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