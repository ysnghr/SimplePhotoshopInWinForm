namespace ImageEffect
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
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.effect1 = new System.Windows.Forms.Button();
            this.effect2 = new System.Windows.Forms.Button();
            this.effect3 = new System.Windows.Forms.Button();
            this.effect4 = new System.Windows.Forms.Button();
            this.effect5 = new System.Windows.Forms.Button();
            this.effect6 = new System.Windows.Forms.Button();
            this.btnupload = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.effect7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbx1
            // 
            this.pbx1.ImageLocation = "C:\\Users\\Acer\\Desktop\\image-1465348_960_720.jpg";
            this.pbx1.Location = new System.Drawing.Point(17, 85);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(397, 367);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            this.pbx1.Paint += new System.Windows.Forms.PaintEventHandler(this.pbx1_Paint);
            this.pbx1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbx1_MouseDown);
            this.pbx1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbx1_MouseMove);
            this.pbx1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbx1_MouseUp);
            // 
            // pbx2
            // 
            this.pbx2.Location = new System.Drawing.Point(444, 85);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(397, 367);
            this.pbx2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.effect1);
            this.flowLayoutPanel1.Controls.Add(this.effect2);
            this.flowLayoutPanel1.Controls.Add(this.effect3);
            this.flowLayoutPanel1.Controls.Add(this.effect4);
            this.flowLayoutPanel1.Controls.Add(this.effect5);
            this.flowLayoutPanel1.Controls.Add(this.effect6);
            this.flowLayoutPanel1.Controls.Add(this.effect7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 458);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(853, 91);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // effect1
            // 
            this.effect1.Location = new System.Drawing.Point(3, 7);
            this.effect1.Name = "effect1";
            this.effect1.Size = new System.Drawing.Size(135, 64);
            this.effect1.TabIndex = 0;
            this.effect1.Text = "Effect 1";
            this.effect1.UseVisualStyleBackColor = true;
            this.effect1.Click += new System.EventHandler(this.effect1_Click);
            // 
            // effect2
            // 
            this.effect2.Location = new System.Drawing.Point(144, 7);
            this.effect2.Name = "effect2";
            this.effect2.Size = new System.Drawing.Size(135, 64);
            this.effect2.TabIndex = 1;
            this.effect2.Text = "Effect 2";
            this.effect2.UseVisualStyleBackColor = true;
            this.effect2.Click += new System.EventHandler(this.effect2_Click);
            // 
            // effect3
            // 
            this.effect3.Location = new System.Drawing.Point(285, 7);
            this.effect3.Name = "effect3";
            this.effect3.Size = new System.Drawing.Size(135, 64);
            this.effect3.TabIndex = 2;
            this.effect3.Text = "Effect 3";
            this.effect3.UseVisualStyleBackColor = true;
            this.effect3.Click += new System.EventHandler(this.effect3_Click);
            // 
            // effect4
            // 
            this.effect4.Location = new System.Drawing.Point(426, 7);
            this.effect4.Name = "effect4";
            this.effect4.Size = new System.Drawing.Size(135, 64);
            this.effect4.TabIndex = 3;
            this.effect4.Text = "Effect 4";
            this.effect4.UseVisualStyleBackColor = true;
            this.effect4.Click += new System.EventHandler(this.effect4_Click);
            // 
            // effect5
            // 
            this.effect5.Location = new System.Drawing.Point(567, 7);
            this.effect5.Name = "effect5";
            this.effect5.Size = new System.Drawing.Size(135, 64);
            this.effect5.TabIndex = 4;
            this.effect5.Text = "Effect 5";
            this.effect5.UseVisualStyleBackColor = true;
            this.effect5.Click += new System.EventHandler(this.effect5_Click);
            // 
            // effect6
            // 
            this.effect6.Location = new System.Drawing.Point(708, 7);
            this.effect6.Name = "effect6";
            this.effect6.Size = new System.Drawing.Size(135, 64);
            this.effect6.TabIndex = 5;
            this.effect6.Text = "Effect 6";
            this.effect6.UseVisualStyleBackColor = true;
            this.effect6.Click += new System.EventHandler(this.effect6_Click);
            // 
            // btnupload
            // 
            this.btnupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupload.Location = new System.Drawing.Point(17, 43);
            this.btnupload.Name = "btnupload";
            this.btnupload.Size = new System.Drawing.Size(397, 36);
            this.btnupload.TabIndex = 3;
            this.btnupload.Text = "Upload Image";
            this.btnupload.UseVisualStyleBackColor = true;
            this.btnupload.Click += new System.EventHandler(this.btnupload_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(444, 43);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(397, 36);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "Save Image";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // effect7
            // 
            this.effect7.Location = new System.Drawing.Point(849, 7);
            this.effect7.Name = "effect7";
            this.effect7.Size = new System.Drawing.Size(135, 64);
            this.effect7.TabIndex = 6;
            this.effect7.Text = "Effect 7";
            this.effect7.UseVisualStyleBackColor = true;
            this.effect7.Click += new System.EventHandler(this.effect7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 549);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnupload);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnupload;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button effect1;
        private System.Windows.Forms.Button effect2;
        private System.Windows.Forms.Button effect3;
        private System.Windows.Forms.Button effect4;
        private System.Windows.Forms.Button effect5;
        private System.Windows.Forms.Button effect6;
        private System.Windows.Forms.Button effect7;
    }
}

