namespace Blogging
{
    partial class edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ed = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(597, 30);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ed
            // 
            this.ed.BackColor = System.Drawing.Color.Transparent;
            this.ed.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ed.Location = new System.Drawing.Point(674, 93);
            this.ed.Name = "ed";
            this.ed.Size = new System.Drawing.Size(75, 28);
            this.ed.TabIndex = 4;
            this.ed.Text = "Edit";
            this.ed.UseVisualStyleBackColor = false;
            this.ed.Click += new System.EventHandler(this.ed_Click);
            // 
            // del
            // 
            this.del.BackColor = System.Drawing.Color.Transparent;
            this.del.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(674, 184);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 28);
            this.del.TabIndex = 5;
            this.del.Text = "delete";
            this.del.UseVisualStyleBackColor = false;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 65);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(597, 30);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(13, 122);
            this.label1.MaximumSize = new System.Drawing.Size(600, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(674, 248);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.del);
            this.Controls.Add(this.ed);
            this.Controls.Add(this.comboBox1);
            this.Name = "edit";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ed;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}