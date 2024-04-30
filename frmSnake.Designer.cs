namespace Snake_v2
{
	partial class frmSnake
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSnake));
			this.lblSpeed = new System.Windows.Forms.Label();
			this.lblSpeedLabel = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.lblScoreLabel = new System.Windows.Forms.Label();
			this.imgSpeed = new System.Windows.Forms.PictureBox();
			this.ModelApple = new System.Windows.Forms.PictureBox();
			this.Grid = new System.Windows.Forms.PictureBox();
			this.Menu = new System.Windows.Forms.PictureBox();
			this.ControlTimer = new System.Windows.Forms.Timer(this.components);
			this.Apple = new System.Windows.Forms.PictureBox();
			this.SnakeTail = new System.Windows.Forms.PictureBox();
			this.SnakeHead = new System.Windows.Forms.PictureBox();
			this.imgMenu = new System.Windows.Forms.PictureBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.ModelHead = new System.Windows.Forms.PictureBox();
			this.XEye2 = new System.Windows.Forms.PictureBox();
			this.XEye1 = new System.Windows.Forms.PictureBox();
			this.ModelBody1 = new System.Windows.Forms.PictureBox();
			this.ModelBody2 = new System.Windows.Forms.PictureBox();
			this.ModelTail = new System.Windows.Forms.PictureBox();
			this.lblSpeedLimits = new System.Windows.Forms.Label();
			this.lblSpeedTitle = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.txtSpeed = new System.Windows.Forms.TextBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imgSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelApple)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Menu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Apple)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SnakeTail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.imgMenu)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelHead)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XEye2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.XEye1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelBody1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelBody2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelTail)).BeginInit();
			this.SuspendLayout();
			// 
			// lblSpeed
			// 
			this.lblSpeed.BackColor = System.Drawing.Color.Transparent;
			this.lblSpeed.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeed.ForeColor = System.Drawing.Color.Black;
			this.lblSpeed.Location = new System.Drawing.Point(650, 268);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new System.Drawing.Size(74, 33);
			this.lblSpeed.TabIndex = 54;
			this.lblSpeed.Text = "0";
			this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblSpeedLabel
			// 
			this.lblSpeedLabel.AutoSize = true;
			this.lblSpeedLabel.BackColor = System.Drawing.Color.Transparent;
			this.lblSpeedLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeedLabel.ForeColor = System.Drawing.Color.Black;
			this.lblSpeedLabel.Location = new System.Drawing.Point(648, 235);
			this.lblSpeedLabel.Name = "lblSpeedLabel";
			this.lblSpeedLabel.Size = new System.Drawing.Size(78, 33);
			this.lblSpeedLabel.TabIndex = 53;
			this.lblSpeedLabel.Text = "Speed:";
			this.lblSpeedLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblScore
			// 
			this.lblScore.BackColor = System.Drawing.Color.Transparent;
			this.lblScore.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.ForeColor = System.Drawing.Color.Red;
			this.lblScore.Location = new System.Drawing.Point(650, 129);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(74, 33);
			this.lblScore.TabIndex = 47;
			this.lblScore.Text = "0";
			this.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblScoreLabel
			// 
			this.lblScoreLabel.AutoSize = true;
			this.lblScoreLabel.BackColor = System.Drawing.Color.Transparent;
			this.lblScoreLabel.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScoreLabel.ForeColor = System.Drawing.Color.Red;
			this.lblScoreLabel.Location = new System.Drawing.Point(650, 96);
			this.lblScoreLabel.Name = "lblScoreLabel";
			this.lblScoreLabel.Size = new System.Drawing.Size(74, 33);
			this.lblScoreLabel.TabIndex = 46;
			this.lblScoreLabel.Text = "Score:";
			this.lblScoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// imgSpeed
			// 
			this.imgSpeed.Image = global::Snake_v2.Properties.Resources.SpeedIcon;
			this.imgSpeed.Location = new System.Drawing.Point(657, 175);
			this.imgSpeed.Name = "imgSpeed";
			this.imgSpeed.Size = new System.Drawing.Size(60, 60);
			this.imgSpeed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.imgSpeed.TabIndex = 52;
			this.imgSpeed.TabStop = false;
			// 
			// ModelApple
			// 
			this.ModelApple.Image = global::Snake_v2.Properties.Resources.SnakeApple;
			this.ModelApple.Location = new System.Drawing.Point(667, 56);
			this.ModelApple.Name = "ModelApple";
			this.ModelApple.Size = new System.Drawing.Size(40, 40);
			this.ModelApple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ModelApple.TabIndex = 45;
			this.ModelApple.TabStop = false;
			// 
			// Grid
			// 
			this.Grid.BackColor = System.Drawing.Color.Transparent;
			this.Grid.Image = global::Snake_v2.Properties.Resources.SnakeBG;
			this.Grid.Location = new System.Drawing.Point(25, 25);
			this.Grid.Name = "Grid";
			this.Grid.Size = new System.Drawing.Size(600, 600);
			this.Grid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Grid.TabIndex = 29;
			this.Grid.TabStop = false;
			this.Grid.Paint += new System.Windows.Forms.PaintEventHandler(this.Grid_Paint);
			// 
			// Menu
			// 
			this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(205)))), ((int)(((byte)(53)))));
			this.Menu.Location = new System.Drawing.Point(650, 25);
			this.Menu.Name = "Menu";
			this.Menu.Size = new System.Drawing.Size(75, 600);
			this.Menu.TabIndex = 51;
			this.Menu.TabStop = false;
			// 
			// ControlTimer
			// 
			this.ControlTimer.Interval = 125;
			this.ControlTimer.Tick += new System.EventHandler(this.ControlTimer_Tick);
			// 
			// Apple
			// 
			this.Apple.BackColor = System.Drawing.Color.Transparent;
			this.Apple.Image = global::Snake_v2.Properties.Resources.SnakeApple;
			this.Apple.Location = new System.Drawing.Point(304, 305);
			this.Apple.Name = "Apple";
			this.Apple.Size = new System.Drawing.Size(40, 40);
			this.Apple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.Apple.TabIndex = 34;
			this.Apple.TabStop = false;
			// 
			// SnakeTail
			// 
			this.SnakeTail.BackColor = System.Drawing.Color.Transparent;
			this.SnakeTail.Image = global::Snake_v2.Properties.Resources.SnakeTailRight;
			this.SnakeTail.Location = new System.Drawing.Point(25, 305);
			this.SnakeTail.Name = "SnakeTail";
			this.SnakeTail.Size = new System.Drawing.Size(40, 40);
			this.SnakeTail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SnakeTail.TabIndex = 33;
			this.SnakeTail.TabStop = false;
			this.SnakeTail.Tag = "Right";
			// 
			// SnakeHead
			// 
			this.SnakeHead.BackColor = System.Drawing.Color.Transparent;
			this.SnakeHead.Image = global::Snake_v2.Properties.Resources.SnakeHeadRight;
			this.SnakeHead.Location = new System.Drawing.Point(146, 305);
			this.SnakeHead.Name = "SnakeHead";
			this.SnakeHead.Size = new System.Drawing.Size(40, 40);
			this.SnakeHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.SnakeHead.TabIndex = 30;
			this.SnakeHead.TabStop = false;
			this.SnakeHead.Tag = "Right";
			// 
			// imgMenu
			// 
			this.imgMenu.Location = new System.Drawing.Point(175, 175);
			this.imgMenu.Name = "imgMenu";
			this.imgMenu.Size = new System.Drawing.Size(300, 300);
			this.imgMenu.TabIndex = 35;
			this.imgMenu.TabStop = false;
			// 
			// lblTitle
			// 
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Font = new System.Drawing.Font("Segoe Print", 38.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(199)))));
			this.lblTitle.Location = new System.Drawing.Point(175, 176);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(300, 85);
			this.lblTitle.TabIndex = 36;
			this.lblTitle.Text = "Snake";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// ModelHead
			// 
			this.ModelHead.BackColor = System.Drawing.Color.Transparent;
			this.ModelHead.Image = global::Snake_v2.Properties.Resources.SnakeHeadRight;
			this.ModelHead.Location = new System.Drawing.Point(360, 255);
			this.ModelHead.Name = "ModelHead";
			this.ModelHead.Size = new System.Drawing.Size(40, 40);
			this.ModelHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ModelHead.TabIndex = 39;
			this.ModelHead.TabStop = false;
			this.ModelHead.Tag = "Right";
			// 
			// XEye2
			// 
			this.XEye2.BackColor = System.Drawing.Color.Transparent;
			this.XEye2.Image = global::Snake_v2.Properties.Resources.SnakeXEyes;
			this.XEye2.Location = new System.Drawing.Point(365, 276);
			this.XEye2.Name = "XEye2";
			this.XEye2.Size = new System.Drawing.Size(17, 17);
			this.XEye2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.XEye2.TabIndex = 44;
			this.XEye2.TabStop = false;
			this.XEye2.Visible = false;
			// 
			// XEye1
			// 
			this.XEye1.BackColor = System.Drawing.Color.Transparent;
			this.XEye1.Image = global::Snake_v2.Properties.Resources.SnakeXEyes;
			this.XEye1.Location = new System.Drawing.Point(365, 257);
			this.XEye1.Name = "XEye1";
			this.XEye1.Size = new System.Drawing.Size(17, 17);
			this.XEye1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.XEye1.TabIndex = 43;
			this.XEye1.TabStop = false;
			this.XEye1.Visible = false;
			// 
			// ModelBody1
			// 
			this.ModelBody1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
			this.ModelBody1.Location = new System.Drawing.Point(320, 255);
			this.ModelBody1.Name = "ModelBody1";
			this.ModelBody1.Size = new System.Drawing.Size(40, 40);
			this.ModelBody1.TabIndex = 40;
			this.ModelBody1.TabStop = false;
			this.ModelBody1.Tag = "Right";
			// 
			// ModelBody2
			// 
			this.ModelBody2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
			this.ModelBody2.Location = new System.Drawing.Point(280, 255);
			this.ModelBody2.Name = "ModelBody2";
			this.ModelBody2.Size = new System.Drawing.Size(40, 40);
			this.ModelBody2.TabIndex = 41;
			this.ModelBody2.TabStop = false;
			this.ModelBody2.Tag = "Right";
			// 
			// ModelTail
			// 
			this.ModelTail.BackColor = System.Drawing.Color.Transparent;
			this.ModelTail.Image = global::Snake_v2.Properties.Resources.SnakeTailRight;
			this.ModelTail.Location = new System.Drawing.Point(240, 255);
			this.ModelTail.Name = "ModelTail";
			this.ModelTail.Size = new System.Drawing.Size(40, 40);
			this.ModelTail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.ModelTail.TabIndex = 42;
			this.ModelTail.TabStop = false;
			this.ModelTail.Tag = "Right";
			// 
			// lblSpeedLimits
			// 
			this.lblSpeedLimits.AutoSize = true;
			this.lblSpeedLimits.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeedLimits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(199)))));
			this.lblSpeedLimits.Location = new System.Drawing.Point(290, 327);
			this.lblSpeedLimits.Name = "lblSpeedLimits";
			this.lblSpeedLimits.Size = new System.Drawing.Size(63, 21);
			this.lblSpeedLimits.TabIndex = 55;
			this.lblSpeedLimits.Text = "(1-250)";
			// 
			// lblSpeedTitle
			// 
			this.lblSpeedTitle.AutoSize = true;
			this.lblSpeedTitle.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblSpeedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(199)))));
			this.lblSpeedTitle.Location = new System.Drawing.Point(284, 298);
			this.lblSpeedTitle.Name = "lblSpeedTitle";
			this.lblSpeedTitle.Size = new System.Drawing.Size(78, 33);
			this.lblSpeedTitle.TabIndex = 49;
			this.lblSpeedTitle.Text = "Speed:";
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblError.ForeColor = System.Drawing.Color.Red;
			this.lblError.Location = new System.Drawing.Point(256, 382);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(141, 23);
			this.lblError.TabIndex = 50;
			this.lblError.Text = "Error, Invalid Input";
			this.lblError.Visible = false;
			// 
			// txtSpeed
			// 
			this.txtSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(125)))), ((int)(((byte)(42)))));
			this.txtSpeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtSpeed.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSpeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(64)))), ((int)(((byte)(199)))));
			this.txtSpeed.Location = new System.Drawing.Point(270, 353);
			this.txtSpeed.Name = "txtSpeed";
			this.txtSpeed.Size = new System.Drawing.Size(100, 29);
			this.txtSpeed.TabIndex = 48;
			this.txtSpeed.Text = "125";
			this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(105)))), ((int)(((byte)(33)))));
			this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(47)))));
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(335, 405);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(95, 51);
			this.btnClose.TabIndex = 38;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnStart
			// 
			this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStart.FlatAppearance.BorderSize = 0;
			this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(105)))), ((int)(((byte)(33)))));
			this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(47)))));
			this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStart.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(205, 405);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(95, 51);
			this.btnStart.TabIndex = 37;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// frmSnake
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(138)))), ((int)(((byte)(52)))));
			this.ClientSize = new System.Drawing.Size(750, 650);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblSpeed);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.lblSpeedLabel);
			this.Controls.Add(this.txtSpeed);
			this.Controls.Add(this.imgSpeed);
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.lblSpeedTitle);
			this.Controls.Add(this.lblScoreLabel);
			this.Controls.Add(this.lblSpeedLimits);
			this.Controls.Add(this.ModelApple);
			this.Controls.Add(this.ModelTail);
			this.Controls.Add(this.Menu);
			this.Controls.Add(this.ModelBody2);
			this.Controls.Add(this.ModelBody1);
			this.Controls.Add(this.XEye1);
			this.Controls.Add(this.XEye2);
			this.Controls.Add(this.Apple);
			this.Controls.Add(this.ModelHead);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.imgMenu);
			this.Controls.Add(this.SnakeHead);
			this.Controls.Add(this.SnakeTail);
			this.Controls.Add(this.Grid);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.Name = "frmSnake";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Snake Game";
			this.Load += new System.EventHandler(this.frmSnake_Load);
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmSnake_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.imgSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelApple)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Menu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Apple)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SnakeTail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SnakeHead)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.imgMenu)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelHead)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XEye2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.XEye1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelBody1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelBody2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ModelTail)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		internal System.Windows.Forms.Label lblSpeed;
		internal System.Windows.Forms.Label lblSpeedLabel;
		internal System.Windows.Forms.PictureBox imgSpeed;
		internal System.Windows.Forms.Label lblScore;
		internal System.Windows.Forms.Label lblScoreLabel;
		internal System.Windows.Forms.PictureBox ModelApple;
		internal System.Windows.Forms.PictureBox Grid;
		internal System.Windows.Forms.PictureBox Menu;
		internal System.Windows.Forms.Timer ControlTimer;
		internal System.Windows.Forms.PictureBox Apple;
		internal System.Windows.Forms.PictureBox SnakeTail;
		internal System.Windows.Forms.PictureBox SnakeHead;
		internal System.Windows.Forms.PictureBox imgMenu;
		internal System.Windows.Forms.Label lblTitle;
		internal System.Windows.Forms.PictureBox ModelHead;
		internal System.Windows.Forms.PictureBox XEye2;
		internal System.Windows.Forms.PictureBox XEye1;
		internal System.Windows.Forms.PictureBox ModelBody1;
		internal System.Windows.Forms.PictureBox ModelBody2;
		internal System.Windows.Forms.PictureBox ModelTail;
		internal System.Windows.Forms.Label lblSpeedLimits;
		internal System.Windows.Forms.Label lblSpeedTitle;
		internal System.Windows.Forms.Label lblError;
		internal System.Windows.Forms.TextBox txtSpeed;
		internal System.Windows.Forms.Button btnClose;
		internal System.Windows.Forms.Button btnStart;
	}
}

