namespace Game
{
	partial class TestWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( TestWindow ) );
			this.pbTestImage = new System.Windows.Forms.PictureBox();
			this.gbHelp = new System.Windows.Forms.GroupBox();
			this.btStack = new System.Windows.Forms.Button();
			this.btCallBill = new System.Windows.Forms.Button();
			this.bt50 = new System.Windows.Forms.Button();
			this.tbQuestion = new System.Windows.Forms.TextBox();
			this.btAnswerA = new System.Windows.Forms.Button();
			this.btAnswerB = new System.Windows.Forms.Button();
			this.btAnswerD = new System.Windows.Forms.Button();
			this.btAnswerC = new System.Windows.Forms.Button();
			this.gbProgress = new System.Windows.Forms.GroupBox();
			this.lbProgress = new System.Windows.Forms.Label();
			this.lbTimer = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer( this.components );
			( ( System.ComponentModel.ISupportInitialize )( this.pbTestImage ) ).BeginInit();
			this.gbHelp.SuspendLayout();
			this.gbProgress.SuspendLayout();
			this.SuspendLayout();
			// 
			// pbTestImage
			// 
			this.pbTestImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbTestImage.Image = ( ( System.Drawing.Image )( resources.GetObject( "pbTestImage.Image" ) ) );
			this.pbTestImage.Location = new System.Drawing.Point( 13, 13 );
			this.pbTestImage.Name = "pbTestImage";
			this.pbTestImage.Size = new System.Drawing.Size( 659, 136 );
			this.pbTestImage.TabIndex = 0;
			this.pbTestImage.TabStop = false;
			// 
			// gbHelp
			// 
			this.gbHelp.Controls.Add( this.btStack );
			this.gbHelp.Controls.Add( this.btCallBill );
			this.gbHelp.Controls.Add( this.bt50 );
			this.gbHelp.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.gbHelp.Location = new System.Drawing.Point( 355, 159 );
			this.gbHelp.Name = "gbHelp";
			this.gbHelp.Size = new System.Drawing.Size( 317, 56 );
			this.gbHelp.TabIndex = 1;
			this.gbHelp.TabStop = false;
			this.gbHelp.Text = "Подсказки";
			// 
			// btStack
			// 
			this.btStack.Location = new System.Drawing.Point( 218, 19 );
			this.btStack.Name = "btStack";
			this.btStack.Size = new System.Drawing.Size( 93, 23 );
			this.btStack.TabIndex = 2;
			this.btStack.Text = "StackOverflow";
			this.btStack.UseVisualStyleBackColor = true;
			this.btStack.Click += new System.EventHandler( this.ShowHelp );
			// 
			// btCallBill
			// 
			this.btCallBill.Location = new System.Drawing.Point( 119, 19 );
			this.btCallBill.Name = "btCallBill";
			this.btCallBill.Size = new System.Drawing.Size( 93, 23 );
			this.btCallBill.TabIndex = 1;
			this.btCallBill.Text = "Звонок Биллу";
			this.btCallBill.UseVisualStyleBackColor = true;
			this.btCallBill.Click += new System.EventHandler( this.ShowHelp );
			// 
			// bt50
			// 
			this.bt50.Location = new System.Drawing.Point( 20, 19 );
			this.bt50.Name = "bt50";
			this.bt50.Size = new System.Drawing.Size( 93, 23 );
			this.bt50.TabIndex = 0;
			this.bt50.Text = "110010/110010";
			this.bt50.UseVisualStyleBackColor = true;
			this.bt50.Click += new System.EventHandler( this.FiftyByFiftyHelp );
			// 
			// tbQuestion
			// 
			this.tbQuestion.BackColor = System.Drawing.SystemColors.Control;
			this.tbQuestion.Font = new System.Drawing.Font( "Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.tbQuestion.Location = new System.Drawing.Point( 47, 227 );
			this.tbQuestion.Multiline = true;
			this.tbQuestion.Name = "tbQuestion";
			this.tbQuestion.ReadOnly = true;
			this.tbQuestion.Size = new System.Drawing.Size( 591, 64 );
			this.tbQuestion.TabIndex = 2;
			// 
			// btAnswerA
			// 
			this.btAnswerA.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btAnswerA.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btAnswerA.Location = new System.Drawing.Point( 47, 308 );
			this.btAnswerA.Name = "btAnswerA";
			this.btAnswerA.Size = new System.Drawing.Size( 283, 64 );
			this.btAnswerA.TabIndex = 3;
			this.btAnswerA.Text = "ответ A";
			this.btAnswerA.UseVisualStyleBackColor = true;
			this.btAnswerA.Click += new System.EventHandler( this.AnswerOnQuestion );
			// 
			// btAnswerB
			// 
			this.btAnswerB.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btAnswerB.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btAnswerB.Location = new System.Drawing.Point( 355, 308 );
			this.btAnswerB.Name = "btAnswerB";
			this.btAnswerB.Size = new System.Drawing.Size( 283, 64 );
			this.btAnswerB.TabIndex = 4;
			this.btAnswerB.Text = "ответ B";
			this.btAnswerB.UseVisualStyleBackColor = true;
			this.btAnswerB.Click += new System.EventHandler( this.AnswerOnQuestion );
			// 
			// btAnswerD
			// 
			this.btAnswerD.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btAnswerD.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btAnswerD.Location = new System.Drawing.Point( 355, 378 );
			this.btAnswerD.Name = "btAnswerD";
			this.btAnswerD.Size = new System.Drawing.Size( 283, 64 );
			this.btAnswerD.TabIndex = 5;
			this.btAnswerD.Text = "ответ D";
			this.btAnswerD.UseVisualStyleBackColor = true;
			this.btAnswerD.Click += new System.EventHandler( this.AnswerOnQuestion );
			// 
			// btAnswerC
			// 
			this.btAnswerC.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btAnswerC.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btAnswerC.Location = new System.Drawing.Point( 47, 378 );
			this.btAnswerC.Name = "btAnswerC";
			this.btAnswerC.Size = new System.Drawing.Size( 283, 64 );
			this.btAnswerC.TabIndex = 6;
			this.btAnswerC.Text = "ответ C";
			this.btAnswerC.UseVisualStyleBackColor = true;
			this.btAnswerC.Click += new System.EventHandler( this.AnswerOnQuestion );
			// 
			// gbProgress
			// 
			this.gbProgress.Controls.Add( this.lbProgress );
			this.gbProgress.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.gbProgress.Location = new System.Drawing.Point( 13, 159 );
			this.gbProgress.Margin = new System.Windows.Forms.Padding( 0 );
			this.gbProgress.Name = "gbProgress";
			this.gbProgress.Size = new System.Drawing.Size( 317, 56 );
			this.gbProgress.TabIndex = 7;
			this.gbProgress.TabStop = false;
			this.gbProgress.Text = "Прогресс";
			// 
			// lbProgress
			// 
			this.lbProgress.AutoSize = true;
			this.lbProgress.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.lbProgress.Location = new System.Drawing.Point( 136, 21 );
			this.lbProgress.Margin = new System.Windows.Forms.Padding( 0 );
			this.lbProgress.Name = "lbProgress";
			this.lbProgress.Size = new System.Drawing.Size( 55, 21 );
			this.lbProgress.TabIndex = 0;
			this.lbProgress.Text = "0 / 30";
			// 
			// lbTimer
			// 
			this.lbTimer.AutoSize = true;
			this.lbTimer.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.lbTimer.Location = new System.Drawing.Point( 314, 466 );
			this.lbTimer.Name = "lbTimer";
			this.lbTimer.Size = new System.Drawing.Size( 55, 21 );
			this.lbTimer.TabIndex = 8;
			this.lbTimer.Text = "00:45";
			// 
			// TestWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size( 684, 496 );
			this.Controls.Add( this.lbTimer );
			this.Controls.Add( this.gbProgress );
			this.Controls.Add( this.btAnswerC );
			this.Controls.Add( this.btAnswerD );
			this.Controls.Add( this.btAnswerB );
			this.Controls.Add( this.btAnswerA );
			this.Controls.Add( this.tbQuestion );
			this.Controls.Add( this.gbHelp );
			this.Controls.Add( this.pbTestImage );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.Name = "TestWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Кто хочет стать программистом";
			( ( System.ComponentModel.ISupportInitialize )( this.pbTestImage ) ).EndInit();
			this.gbHelp.ResumeLayout( false );
			this.gbProgress.ResumeLayout( false );
			this.gbProgress.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pbTestImage;
		private System.Windows.Forms.GroupBox gbHelp;
		private System.Windows.Forms.TextBox tbQuestion;
		private System.Windows.Forms.Button btAnswerA;
		private System.Windows.Forms.Button btAnswerB;
		private System.Windows.Forms.Button btAnswerD;
		private System.Windows.Forms.Button btAnswerC;
		private System.Windows.Forms.GroupBox gbProgress;
		private System.Windows.Forms.Label lbProgress;
		private System.Windows.Forms.Label lbTimer;
		private System.Windows.Forms.Button btStack;
		private System.Windows.Forms.Button btCallBill;
		private System.Windows.Forms.Button bt50;
		private System.Windows.Forms.Timer timer1;
	}
}