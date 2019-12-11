namespace Blogging
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogType1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blogType2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.BackgroundImage = global::Blogging.Properties.Resources.Blog_Banner1;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(795, 62);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blogType1ToolStripMenuItem,
            this.blogType2ToolStripMenuItem});
            this.registerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(121, 58);
            this.registerToolStripMenuItem.Text = "New Blog";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.RegisterToolStripMenuItem_Click_1);
            // 
            // blogType1ToolStripMenuItem
            // 
            this.blogType1ToolStripMenuItem.Name = "blogType1ToolStripMenuItem";
            this.blogType1ToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.blogType1ToolStripMenuItem.Text = "Blog Type 1";
            this.blogType1ToolStripMenuItem.Click += new System.EventHandler(this.BlogType1ToolStripMenuItem_Click);
            // 
            // blogType2ToolStripMenuItem
            // 
            this.blogType2ToolStripMenuItem.Name = "blogType2ToolStripMenuItem";
            this.blogType2ToolStripMenuItem.Size = new System.Drawing.Size(201, 34);
            this.blogType2ToolStripMenuItem.Text = "Blog Type 2";
            this.blogType2ToolStripMenuItem.Click += new System.EventHandler(this.BlogType2ToolStripMenuItem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "Welcome";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 401);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create A Blog:";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(631, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 44);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(494, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 6;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(404, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(276, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Upload Picture :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 33);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Title :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Contents :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 130);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(353, 245);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::Blogging.Properties.Resources.Blog_Banner1;
            this.ClientSize = new System.Drawing.Size(795, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form5";
            this.Text = "Blogs";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem blogType1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blogType2ToolStripMenuItem;
    }
}