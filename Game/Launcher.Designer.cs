namespace Game
{
	partial class Launcher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Launcher ) );
			this.pbLogo = new System.Windows.Forms.PictureBox();
			this.btNewGame = new System.Windows.Forms.Button();
			this.btRecordTable = new System.Windows.Forms.Button();
			this.btExit = new System.Windows.Forms.Button();
			( ( System.ComponentModel.ISupportInitialize )( this.pbLogo ) ).BeginInit();
			this.SuspendLayout();
			// 
			// pbLogo
			// 
			this.pbLogo.Anchor = ( ( System.Windows.Forms.AnchorStyles )( ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left )
						| System.Windows.Forms.AnchorStyles.Right ) ) );
			this.pbLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pbLogo.Image = ( ( System.Drawing.Image )( resources.GetObject( "pbLogo.Image" ) ) );
			this.pbLogo.Location = new System.Drawing.Point( 9, 9 );
			this.pbLogo.Margin = new System.Windows.Forms.Padding( 0 );
			this.pbLogo.Name = "pbLogo";
			this.pbLogo.Size = new System.Drawing.Size( 366, 153 );
			this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pbLogo.TabIndex = 0;
			this.pbLogo.TabStop = false;
			// 
			// btNewGame
			// 
			this.btNewGame.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btNewGame.Location = new System.Drawing.Point( 59, 214 );
			this.btNewGame.Name = "btNewGame";
			this.btNewGame.Size = new System.Drawing.Size( 266, 58 );
			this.btNewGame.TabIndex = 1;
			this.btNewGame.Text = "Новая игра";
			this.btNewGame.UseVisualStyleBackColor = true;
			this.btNewGame.Click += new System.EventHandler( this.NewGame );
			// 
			// btRecordTable
			// 
			this.btRecordTable.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btRecordTable.Location = new System.Drawing.Point( 59, 278 );
			this.btRecordTable.Name = "btRecordTable";
			this.btRecordTable.Size = new System.Drawing.Size( 266, 58 );
			this.btRecordTable.TabIndex = 2;
			this.btRecordTable.Text = "Таблица рекордов";
			this.btRecordTable.UseVisualStyleBackColor = true;
			this.btRecordTable.Click += new System.EventHandler( this.ShowRecordTable );
			// 
			// btExit
			// 
			this.btExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btExit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
			this.btExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Highlight;
			this.btExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
			this.btExit.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btExit.Location = new System.Drawing.Point( 59, 342 );
			this.btExit.Name = "btExit";
			this.btExit.Size = new System.Drawing.Size( 266, 58 );
			this.btExit.TabIndex = 3;
			this.btExit.Text = "Выход";
			this.btExit.UseVisualStyleBackColor = true;
			this.btExit.Click += new System.EventHandler( this.Exit );
			// 
			// Launcher
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size( 384, 461 );
			this.Controls.Add( this.btExit );
			this.Controls.Add( this.btRecordTable );
			this.Controls.Add( this.btNewGame );
			this.Controls.Add( this.pbLogo );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.Name = "Launcher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Кто хочет стать программистом";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler( this.ClosingHandler );
			( ( System.ComponentModel.ISupportInitialize )( this.pbLogo ) ).EndInit();
			this.ResumeLayout( false );

		}

		#endregion

		private System.Windows.Forms.PictureBox pbLogo;
		private System.Windows.Forms.Button btNewGame;
		private System.Windows.Forms.Button btRecordTable;
		private System.Windows.Forms.Button btExit;

	}
}

