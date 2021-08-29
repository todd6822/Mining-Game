namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.movement = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livesToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.remainingLives = new System.Windows.Forms.ToolStripTextBox();
            this.saveScore = new System.Windows.Forms.Button();
            this.shipHitBox = new System.Windows.Forms.PictureBox();
            this.asteroid7HitBox = new System.Windows.Forms.PictureBox();
            this.asteroid6HitBox = new System.Windows.Forms.PictureBox();
            this.asteroid5HitBox = new System.Windows.Forms.PictureBox();
            this.asteroid4HitBox = new System.Windows.Forms.PictureBox();
            this.asteroid3HitBox = new System.Windows.Forms.PictureBox();
            this.asteroid1HitBox = new System.Windows.Forms.PictureBox();
            this.asteroid2HitBox = new System.Windows.Forms.PictureBox();
            this.tractorBeam = new System.Windows.Forms.PictureBox();
            this.particle1 = new System.Windows.Forms.PictureBox();
            this.particle2 = new System.Windows.Forms.PictureBox();
            this.asteroid6 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.asteroid7 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.asteroid3 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.asteroid4 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.asteroid5 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.asteroid2 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.asteroid1 = new WindowsFormsApplication1.PolygonPictureBox1();
            this.pictureBox1 = new WindowsFormsApplication1.TrianglePictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipHitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid7HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid6HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid5HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid4HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid3HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid1HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid2HitBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // movement
            // 
            this.movement.Enabled = true;
            this.movement.Interval = 50;
            this.movement.Tick += new System.EventHandler(this.movement_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.score.Location = new System.Drawing.Point(692, 12);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(46, 17);
            this.score.TabIndex = 6;
            this.score.Text = "label1";
            this.score.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem,
            this.livesToolStripMenuItem,
            this.remainingLives});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(802, 31);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 27);
            this.toolStripMenuItem1.Text = "Start";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(45, 27);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // livesToolStripMenuItem
            // 
            this.livesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 1, 0);
            this.livesToolStripMenuItem.Name = "livesToolStripMenuItem";
            this.livesToolStripMenuItem.ReadOnly = true;
            this.livesToolStripMenuItem.Size = new System.Drawing.Size(80, 27);
            this.livesToolStripMenuItem.Text = "Lives:";
            this.livesToolStripMenuItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.livesToolStripMenuItem.Click += new System.EventHandler(this.label1_Click);
            // 
            // remainingLives
            // 
            this.remainingLives.Name = "remainingLives";
            this.remainingLives.ReadOnly = true;
            this.remainingLives.Size = new System.Drawing.Size(29, 27);
            this.remainingLives.Text = "3";
            this.remainingLives.Click += new System.EventHandler(this.remainingLives_Click);
            // 
            // saveScore
            // 
            this.saveScore.Enabled = false;
            this.saveScore.Location = new System.Drawing.Point(595, 301);
            this.saveScore.Name = "saveScore";
            this.saveScore.Size = new System.Drawing.Size(155, 72);
            this.saveScore.TabIndex = 18;
            this.saveScore.Text = "Save Your Score";
            this.saveScore.UseVisualStyleBackColor = true;
            this.saveScore.Click += new System.EventHandler(this.saveScore_Click);
            // 
            // shipHitBox
            // 
            this.shipHitBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.shipHitBox.BackColor = System.Drawing.Color.Black;
            this.shipHitBox.Location = new System.Drawing.Point(497, 189);
            this.shipHitBox.Name = "shipHitBox";
            this.shipHitBox.Size = new System.Drawing.Size(21, 67);
            this.shipHitBox.TabIndex = 3;
            this.shipHitBox.TabStop = false;
            this.shipHitBox.Click += new System.EventHandler(this.shipHitBox_Click);
            // 
            // asteroid7HitBox
            // 
            this.asteroid7HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid7HitBox.Location = new System.Drawing.Point(630, 113);
            this.asteroid7HitBox.Name = "asteroid7HitBox";
            this.asteroid7HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid7HitBox.TabIndex = 16;
            this.asteroid7HitBox.TabStop = false;
            // 
            // asteroid6HitBox
            // 
            this.asteroid6HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid6HitBox.Location = new System.Drawing.Point(521, 113);
            this.asteroid6HitBox.Name = "asteroid6HitBox";
            this.asteroid6HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid6HitBox.TabIndex = 15;
            this.asteroid6HitBox.TabStop = false;
            // 
            // asteroid5HitBox
            // 
            this.asteroid5HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid5HitBox.Location = new System.Drawing.Point(417, 113);
            this.asteroid5HitBox.Name = "asteroid5HitBox";
            this.asteroid5HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid5HitBox.TabIndex = 14;
            this.asteroid5HitBox.TabStop = false;
            // 
            // asteroid4HitBox
            // 
            this.asteroid4HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid4HitBox.Location = new System.Drawing.Point(298, 113);
            this.asteroid4HitBox.Name = "asteroid4HitBox";
            this.asteroid4HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid4HitBox.TabIndex = 13;
            this.asteroid4HitBox.TabStop = false;
            this.asteroid4HitBox.Click += new System.EventHandler(this.asteroid4HitBox_Click);
            // 
            // asteroid3HitBox
            // 
            this.asteroid3HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid3HitBox.Location = new System.Drawing.Point(169, 113);
            this.asteroid3HitBox.Name = "asteroid3HitBox";
            this.asteroid3HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid3HitBox.TabIndex = 12;
            this.asteroid3HitBox.TabStop = false;
            // 
            // asteroid1HitBox
            // 
            this.asteroid1HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid1HitBox.Location = new System.Drawing.Point(181, 222);
            this.asteroid1HitBox.Name = "asteroid1HitBox";
            this.asteroid1HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid1HitBox.TabIndex = 5;
            this.asteroid1HitBox.TabStop = false;
            this.asteroid1HitBox.Tag = "asteroid1HitBox";
            this.asteroid1HitBox.Click += new System.EventHandler(this.asteroid1HitBox_Click);
            // 
            // asteroid2HitBox
            // 
            this.asteroid2HitBox.BackColor = System.Drawing.Color.Black;
            this.asteroid2HitBox.Location = new System.Drawing.Point(33, 189);
            this.asteroid2HitBox.Name = "asteroid2HitBox";
            this.asteroid2HitBox.Size = new System.Drawing.Size(48, 50);
            this.asteroid2HitBox.TabIndex = 4;
            this.asteroid2HitBox.TabStop = false;
            // 
            // tractorBeam
            // 
            this.tractorBeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.tractorBeam.Location = new System.Drawing.Point(396, 219);
            this.tractorBeam.Name = "tractorBeam";
            this.tractorBeam.Size = new System.Drawing.Size(10, 53);
            this.tractorBeam.TabIndex = 19;
            this.tractorBeam.TabStop = false;
            this.tractorBeam.Visible = false;
            // 
            // particle1
            // 
            this.particle1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.particle1.Location = new System.Drawing.Point(12, 47);
            this.particle1.Name = "particle1";
            this.particle1.Size = new System.Drawing.Size(1, 10);
            this.particle1.TabIndex = 20;
            this.particle1.TabStop = false;
            // 
            // particle2
            // 
            this.particle2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.particle2.Location = new System.Drawing.Point(568, 206);
            this.particle2.Name = "particle2";
            this.particle2.Size = new System.Drawing.Size(1, 10);
            this.particle2.TabIndex = 21;
            this.particle2.TabStop = false;
            // 
            // asteroid6
            // 
            this.asteroid6.BackColor = System.Drawing.Color.Black;
            this.asteroid6.Image = global::WindowsFormsApplication1.Properties.Resources.rock6;
            this.asteroid6.Location = new System.Drawing.Point(467, 12);
            this.asteroid6.Name = "asteroid6";
            this.asteroid6.Size = new System.Drawing.Size(600, 450);
            this.asteroid6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asteroid6.TabIndex = 11;
            this.asteroid6.TabStop = false;
            this.asteroid6.Click += new System.EventHandler(this.asteroid6_Click);
            // 
            // asteroid7
            // 
            this.asteroid7.BackColor = System.Drawing.Color.Black;
            this.asteroid7.Image = global::WindowsFormsApplication1.Properties.Resources.rock7;
            this.asteroid7.Location = new System.Drawing.Point(555, 36);
            this.asteroid7.Name = "asteroid7";
            this.asteroid7.Size = new System.Drawing.Size(1600, 1066);
            this.asteroid7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asteroid7.TabIndex = 10;
            this.asteroid7.TabStop = false;
            this.asteroid7.Click += new System.EventHandler(this.asteroid7_Click);
            // 
            // asteroid3
            // 
            this.asteroid3.BackColor = System.Drawing.Color.Red;
            this.asteroid3.Image = global::WindowsFormsApplication1.Properties.Resources.fresh_textures_15;
            this.asteroid3.Location = new System.Drawing.Point(111, 222);
            this.asteroid3.Name = "asteroid3";
            this.asteroid3.Size = new System.Drawing.Size(540, 381);
            this.asteroid3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asteroid3.TabIndex = 9;
            this.asteroid3.TabStop = false;
            this.asteroid3.Click += new System.EventHandler(this.asteroid3_Click);
            // 
            // asteroid4
            // 
            this.asteroid4.BackColor = System.Drawing.Color.Black;
            this.asteroid4.Image = global::WindowsFormsApplication1.Properties.Resources.rock4;
            this.asteroid4.Location = new System.Drawing.Point(235, 12);
            this.asteroid4.Name = "asteroid4";
            this.asteroid4.Size = new System.Drawing.Size(3888, 2592);
            this.asteroid4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asteroid4.TabIndex = 8;
            this.asteroid4.TabStop = false;
            this.asteroid4.Click += new System.EventHandler(this.asteroid4_Click);
            // 
            // asteroid5
            // 
            this.asteroid5.BackColor = System.Drawing.Color.Black;
            this.asteroid5.Image = global::WindowsFormsApplication1.Properties.Resources.rock5;
            this.asteroid5.Location = new System.Drawing.Point(358, 1);
            this.asteroid5.Name = "asteroid5";
            this.asteroid5.Size = new System.Drawing.Size(4000, 2248);
            this.asteroid5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asteroid5.TabIndex = 7;
            this.asteroid5.TabStop = false;
            this.asteroid5.Click += new System.EventHandler(this.asteroid5_Click);
            // 
            // asteroid2
            // 
            this.asteroid2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.asteroid2.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.rock2;
            this.asteroid2.Location = new System.Drawing.Point(1286, 12);
            this.asteroid2.Name = "asteroid2";
            this.asteroid2.Size = new System.Drawing.Size(168, 75);
            this.asteroid2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.asteroid2.TabIndex = 1;
            this.asteroid2.TabStop = false;
            // 
            // asteroid1
            // 
            this.asteroid1.BackColor = System.Drawing.Color.Black;
            this.asteroid1.Image = global::WindowsFormsApplication1.Properties.Resources.rock3;
            this.asteroid1.Location = new System.Drawing.Point(111, 36);
            this.asteroid1.Name = "asteroid1";
            this.asteroid1.Size = new System.Drawing.Size(2560, 1920);
            this.asteroid1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.asteroid1.TabIndex = 2;
            this.asteroid1.TabStop = false;
            this.asteroid1.EnabledChanged += new System.EventHandler(this.Form1_Load);
            this.asteroid1.Click += new System.EventHandler(this.asteroid1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(378, 254);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 67);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(802, 385);
            this.Controls.Add(this.particle2);
            this.Controls.Add(this.particle1);
            this.Controls.Add(this.saveScore);
            this.Controls.Add(this.asteroid6);
            this.Controls.Add(this.asteroid7);
            this.Controls.Add(this.asteroid3);
            this.Controls.Add(this.asteroid4);
            this.Controls.Add(this.asteroid5);
            this.Controls.Add(this.score);
            this.Controls.Add(this.asteroid2);
            this.Controls.Add(this.asteroid1);
            this.Controls.Add(this.asteroid7HitBox);
            this.Controls.Add(this.asteroid6HitBox);
            this.Controls.Add(this.asteroid5HitBox);
            this.Controls.Add(this.asteroid4HitBox);
            this.Controls.Add(this.asteroid3HitBox);
            this.Controls.Add(this.asteroid1HitBox);
            this.Controls.Add(this.asteroid2HitBox);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shipHitBox);
            this.Controls.Add(this.tractorBeam);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.movementKeys);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.movementKeys);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.movementKeys);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipHitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid7HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid6HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid5HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid4HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid3HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid1HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid2HitBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tractorBeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.particle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asteroid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer movement;
        private TrianglePictureBox pictureBox1;
        private PolygonPictureBox1 asteroid2;
        private PolygonPictureBox1 asteroid1;
        private System.Windows.Forms.PictureBox shipHitBox;
        private System.Windows.Forms.PictureBox asteroid2HitBox;
        private System.Windows.Forms.PictureBox asteroid1HitBox;
        private System.Windows.Forms.Label score;
        private PolygonPictureBox1 asteroid5;
        private PolygonPictureBox1 asteroid4;
        private PolygonPictureBox1 asteroid3;
        private PolygonPictureBox1 asteroid7;
        private PolygonPictureBox1 asteroid6;
        private System.Windows.Forms.PictureBox asteroid3HitBox;
        private System.Windows.Forms.PictureBox asteroid4HitBox;
        private System.Windows.Forms.PictureBox asteroid5HitBox;
        private System.Windows.Forms.PictureBox asteroid6HitBox;
        private System.Windows.Forms.PictureBox asteroid7HitBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox remainingLives;
        internal System.Windows.Forms.ToolStripTextBox livesToolStripMenuItem;
        public System.Windows.Forms.PictureBox tractorBeam;
        public System.Windows.Forms.Button saveScore;
        public System.Windows.Forms.PictureBox particle1;
        public System.Windows.Forms.PictureBox particle2;
    }
}

