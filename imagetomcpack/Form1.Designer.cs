namespace imagetomcpack
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
            this.label1 = new System.Windows.Forms.Label();
            this.verbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imagelabel = new System.Windows.Forms.Label();
            this.imagepreview = new System.Windows.Forms.PictureBox();
            this.fonttoggle = new System.Windows.Forms.CheckBox();
            this.chim = new System.Windows.Forms.Button();
            this.dirtreecheck = new System.Windows.Forms.CheckBox();
            this.Imgfilecheck = new System.Windows.Forms.CheckBox();
            this.zipcheck = new System.Windows.Forms.CheckBox();
            this.cleancheck = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.desbox = new System.Windows.Forms.TextBox();
            this.statustext = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagepreview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image To Minecraft Resource Pack";
            // 
            // verbox
            // 
            this.verbox.FormattingEnabled = true;
            this.verbox.Location = new System.Drawing.Point(544, 26);
            this.verbox.Name = "verbox";
            this.verbox.Size = new System.Drawing.Size(68, 23);
            this.verbox.TabIndex = 1;
            this.verbox.Text = "Loading";
            this.verbox.SelectedIndexChanged += new System.EventHandler(this.verbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "MC Version:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Image:";
            // 
            // imagelabel
            // 
            this.imagelabel.AutoSize = true;
            this.imagelabel.Location = new System.Drawing.Point(12, 70);
            this.imagelabel.Name = "imagelabel";
            this.imagelabel.Size = new System.Drawing.Size(120, 15);
            this.imagelabel.TabIndex = 4;
            this.imagelabel.Text = "Selected Image: none";
            // 
            // imagepreview
            // 
            this.imagepreview.Location = new System.Drawing.Point(12, 88);
            this.imagepreview.Name = "imagepreview";
            this.imagepreview.Size = new System.Drawing.Size(256, 256);
            this.imagepreview.TabIndex = 5;
            this.imagepreview.TabStop = false;
            // 
            // fonttoggle
            // 
            this.fonttoggle.AutoSize = true;
            this.fonttoggle.Location = new System.Drawing.Point(111, 353);
            this.fonttoggle.Name = "fonttoggle";
            this.fonttoggle.Size = new System.Drawing.Size(94, 19);
            this.fonttoggle.TabIndex = 8;
            this.fonttoggle.Text = "Replace Font";
            this.fonttoggle.UseVisualStyleBackColor = true;
            // 
            // chim
            // 
            this.chim.Location = new System.Drawing.Point(12, 350);
            this.chim.Name = "chim";
            this.chim.Size = new System.Drawing.Size(93, 23);
            this.chim.TabIndex = 9;
            this.chim.Text = "Change Image";
            this.chim.UseVisualStyleBackColor = true;
            this.chim.Click += new System.EventHandler(this.chim_Click);
            // 
            // dirtreecheck
            // 
            this.dirtreecheck.AutoCheck = false;
            this.dirtreecheck.AutoSize = true;
            this.dirtreecheck.Location = new System.Drawing.Point(274, 106);
            this.dirtreecheck.Name = "dirtreecheck";
            this.dirtreecheck.Size = new System.Drawing.Size(146, 19);
            this.dirtreecheck.TabIndex = 10;
            this.dirtreecheck.Text = "Creating Directory Tree";
            this.dirtreecheck.UseVisualStyleBackColor = true;
            // 
            // Imgfilecheck
            // 
            this.Imgfilecheck.AutoCheck = false;
            this.Imgfilecheck.AutoSize = true;
            this.Imgfilecheck.Location = new System.Drawing.Point(274, 131);
            this.Imgfilecheck.Name = "Imgfilecheck";
            this.Imgfilecheck.Size = new System.Drawing.Size(133, 19);
            this.Imgfilecheck.TabIndex = 11;
            this.Imgfilecheck.Text = "Creating Image Files";
            this.Imgfilecheck.UseVisualStyleBackColor = true;
            // 
            // zipcheck
            // 
            this.zipcheck.AutoCheck = false;
            this.zipcheck.AutoSize = true;
            this.zipcheck.Location = new System.Drawing.Point(274, 156);
            this.zipcheck.Name = "zipcheck";
            this.zipcheck.Size = new System.Drawing.Size(67, 19);
            this.zipcheck.TabIndex = 12;
            this.zipcheck.Text = "Zipping";
            this.zipcheck.UseVisualStyleBackColor = true;
            // 
            // cleancheck
            // 
            this.cleancheck.AutoCheck = false;
            this.cleancheck.AutoSize = true;
            this.cleancheck.Location = new System.Drawing.Point(274, 181);
            this.cleancheck.Name = "cleancheck";
            this.cleancheck.Size = new System.Drawing.Size(90, 19);
            this.cleancheck.TabIndex = 13;
            this.cleancheck.Text = "Cleaning up";
            this.cleancheck.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status";
            // 
            // startbutton
            // 
            this.startbutton.Enabled = false;
            this.startbutton.Location = new System.Drawing.Point(271, 294);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(334, 50);
            this.startbutton.TabIndex = 15;
            this.startbutton.Text = "Start Creation";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Pack Name:";
            // 
            // namebox
            // 
            this.namebox.Location = new System.Drawing.Point(271, 221);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(335, 23);
            this.namebox.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 18;
            this.label7.Text = "Pack Description:";
            // 
            // desbox
            // 
            this.desbox.Location = new System.Drawing.Point(271, 265);
            this.desbox.Name = "desbox";
            this.desbox.Size = new System.Drawing.Size(334, 23);
            this.desbox.TabIndex = 19;
            // 
            // statustext
            // 
            this.statustext.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.statustext.Location = new System.Drawing.Point(211, 360);
            this.statustext.Name = "statustext";
            this.statustext.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.statustext.Size = new System.Drawing.Size(401, 15);
            this.statustext.TabIndex = 20;
            this.statustext.Text = "idle";
            this.statustext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(597, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "This Tool Is Not Affliated With Or Approved By Minecraft, Mojang, or Microsoft In" +
    " Any Way";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 399);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.desbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cleancheck);
            this.Controls.Add(this.zipcheck);
            this.Controls.Add(this.Imgfilecheck);
            this.Controls.Add(this.dirtreecheck);
            this.Controls.Add(this.chim);
            this.Controls.Add(this.fonttoggle);
            this.Controls.Add(this.imagepreview);
            this.Controls.Add(this.imagelabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.verbox);
            this.Controls.Add(this.label1);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagepreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox verbox;
        private Label label2;
        private Label label3;
        private Label imagelabel;
        private PictureBox imagepreview;
        private RichTextBox log;
        private Label statustext;
        private CheckBox fonttoggle;
        private Button chim;
        private CheckBox dirtreecheck;
        private CheckBox Imgfilecheck;
        private CheckBox zipcheck;
        private CheckBox cleancheck;
        private Label label5;
        private Button startbutton;
        private Label label6;
        private TextBox namebox;
        private Label label7;
        private TextBox desbox;
        private CheckBox mcmetacheck;
        private Label label4;
    }
}