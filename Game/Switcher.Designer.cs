namespace Game
{
	partial class Switcher
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( Switcher ) );
			this.btGo = new System.Windows.Forms.Button();
			this.btCancel = new System.Windows.Forms.Button();
			this.lblChoose = new System.Windows.Forms.Label();
			this.rbCpp = new System.Windows.Forms.RadioButton();
			this.rbCs = new System.Windows.Forms.RadioButton();
			this.rbC = new System.Windows.Forms.RadioButton();
			this.rbProgrammer = new System.Windows.Forms.RadioButton();
			this.pnPicture = new System.Windows.Forms.Panel();
			this.pcProgrammer = new System.Windows.Forms.PictureBox();
			this.pcJava = new System.Windows.Forms.PictureBox();
			this.pcCs = new System.Windows.Forms.PictureBox();
			this.pcCpp = new System.Windows.Forms.PictureBox();
			this.pnPicture.SuspendLayout();
			( ( System.ComponentModel.ISupportInitialize )( this.pcProgrammer ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.pcJava ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.pcCs ) ).BeginInit();
			( ( System.ComponentModel.ISupportInitialize )( this.pcCpp ) ).BeginInit();
			this.SuspendLayout();
			// 
			// btGo
			// 
			this.btGo.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btGo.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btGo.Location = new System.Drawing.Point( 37, 394 );
			this.btGo.Name = "btGo";
			this.btGo.Size = new System.Drawing.Size( 150, 48 );
			this.btGo.TabIndex = 0;
			this.btGo.Text = "Поехали!!!";
			this.btGo.UseVisualStyleBackColor = true;
			this.btGo.Click += new System.EventHandler( this.StartTest );
			// 
			// btCancel
			// 
			this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btCancel.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.btCancel.Location = new System.Drawing.Point( 198, 394 );
			this.btCancel.Name = "btCancel";
			this.btCancel.Size = new System.Drawing.Size( 150, 48 );
			this.btCancel.TabIndex = 1;
			this.btCancel.Text = "Отмена";
			this.btCancel.UseVisualStyleBackColor = true;
			// 
			// lblChoose
			// 
			this.lblChoose.AutoSize = true;
			this.lblChoose.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.lblChoose.Location = new System.Drawing.Point( 12, 24 );
			this.lblChoose.Name = "lblChoose";
			this.lblChoose.Size = new System.Drawing.Size( 138, 21 );
			this.lblChoose.TabIndex = 2;
			this.lblChoose.Text = "Выберите тест:";
			// 
			// rbCpp
			// 
			this.rbCpp.AutoSize = true;
			this.rbCpp.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.rbCpp.Location = new System.Drawing.Point( 37, 90 );
			this.rbCpp.Name = "rbCpp";
			this.rbCpp.Size = new System.Drawing.Size( 63, 25 );
			this.rbCpp.TabIndex = 3;
			this.rbCpp.TabStop = true;
			this.rbCpp.Text = "С++";
			this.rbCpp.UseVisualStyleBackColor = true;
			// 
			// rbCs
			// 
			this.rbCs.AutoSize = true;
			this.rbCs.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.rbCs.Location = new System.Drawing.Point( 37, 160 );
			this.rbCs.Name = "rbCs";
			this.rbCs.Size = new System.Drawing.Size( 51, 25 );
			this.rbCs.TabIndex = 4;
			this.rbCs.TabStop = true;
			this.rbCs.Text = "С#";
			this.rbCs.UseVisualStyleBackColor = true;
			// 
			// rbC
			// 
			this.rbC.AutoSize = true;
			this.rbC.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.rbC.Location = new System.Drawing.Point( 37, 235 );
			this.rbC.Name = "rbC";
			this.rbC.Size = new System.Drawing.Size( 41, 25 );
			this.rbC.TabIndex = 5;
			this.rbC.TabStop = true;
			this.rbC.Text = "C";
			this.rbC.UseVisualStyleBackColor = true;
			// 
			// rbProgrammer
			// 
			this.rbProgrammer.AutoSize = true;
			this.rbProgrammer.Checked = true;
			this.rbProgrammer.Font = new System.Drawing.Font( "Mathcad UniMath Prime", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( ( byte )( 204 ) ) );
			this.rbProgrammer.Location = new System.Drawing.Point( 37, 307 );
			this.rbProgrammer.Name = "rbProgrammer";
			this.rbProgrammer.Size = new System.Drawing.Size( 180, 25 );
			this.rbProgrammer.TabIndex = 6;
			this.rbProgrammer.TabStop = true;
			this.rbProgrammer.Text = "ТыЖПрограммист";
			this.rbProgrammer.UseVisualStyleBackColor = true;
			// 
			// pnPicture
			// 
			this.pnPicture.Controls.Add( this.pcProgrammer );
			this.pnPicture.Controls.Add( this.pcJava );
			this.pnPicture.Controls.Add( this.pcCs );
			this.pnPicture.Controls.Add( this.pcCpp );
			this.pnPicture.Location = new System.Drawing.Point( 228, 66 );
			this.pnPicture.Name = "pnPicture";
			this.pnPicture.Size = new System.Drawing.Size( 144, 294 );
			this.pnPicture.TabIndex = 7;
			// 
			// pcProgrammer
			// 
			this.pcProgrammer.Image = ( ( System.Drawing.Image )( resources.GetObject( "pcProgrammer.Image" ) ) );
			this.pcProgrammer.Location = new System.Drawing.Point( 3, 223 );
			this.pcProgrammer.Name = "pcProgrammer";
			this.pcProgrammer.Size = new System.Drawing.Size( 137, 66 );
			this.pcProgrammer.TabIndex = 3;
			this.pcProgrammer.TabStop = false;
			// 
			// pcJava
			// 
			this.pcJava.Image = ( ( System.Drawing.Image )( resources.GetObject( "pcJava.Image" ) ) );
			this.pcJava.Location = new System.Drawing.Point( 3, 148 );
			this.pcJava.Name = "pcJava";
			this.pcJava.Size = new System.Drawing.Size( 137, 66 );
			this.pcJava.TabIndex = 2;
			this.pcJava.TabStop = false;
			// 
			// pcCs
			// 
			this.pcCs.Image = ( ( System.Drawing.Image )( resources.GetObject( "pcCs.Image" ) ) );
			this.pcCs.Location = new System.Drawing.Point( 3, 76 );
			this.pcCs.Name = "pcCs";
			this.pcCs.Size = new System.Drawing.Size( 137, 66 );
			this.pcCs.TabIndex = 1;
			this.pcCs.TabStop = false;
			// 
			// pcCpp
			// 
			this.pcCpp.Image = ( ( System.Drawing.Image )( resources.GetObject( "pcCpp.Image" ) ) );
			this.pcCpp.Location = new System.Drawing.Point( 4, 4 );
			this.pcCpp.Name = "pcCpp";
			this.pcCpp.Size = new System.Drawing.Size( 137, 66 );
			this.pcCpp.TabIndex = 0;
			this.pcCpp.TabStop = false;
			// 
			// Switcher
			// 
			this.AcceptButton = this.btGo;
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.CancelButton = this.btCancel;
			this.ClientSize = new System.Drawing.Size( 384, 461 );
			this.Controls.Add( this.pnPicture );
			this.Controls.Add( this.rbProgrammer );
			this.Controls.Add( this.rbC );
			this.Controls.Add( this.rbCs );
			this.Controls.Add( this.rbCpp );
			this.Controls.Add( this.lblChoose );
			this.Controls.Add( this.btCancel );
			this.Controls.Add( this.btGo );
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ( ( System.Drawing.Icon )( resources.GetObject( "$this.Icon" ) ) );
			this.MaximizeBox = false;
			this.Name = "Switcher";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.pnPicture.ResumeLayout( false );
			( ( System.ComponentModel.ISupportInitialize )( this.pcProgrammer ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.pcJava ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.pcCs ) ).EndInit();
			( ( System.ComponentModel.ISupportInitialize )( this.pcCpp ) ).EndInit();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btGo;
		private System.Windows.Forms.Button btCancel;
		private System.Windows.Forms.Label lblChoose;
		private System.Windows.Forms.RadioButton rbCpp;
		private System.Windows.Forms.RadioButton rbCs;
		private System.Windows.Forms.RadioButton rbC;
		private System.Windows.Forms.RadioButton rbProgrammer;
		private System.Windows.Forms.Panel pnPicture;
		private System.Windows.Forms.PictureBox pcJava;
		private System.Windows.Forms.PictureBox pcCs;
		private System.Windows.Forms.PictureBox pcCpp;
		private System.Windows.Forms.PictureBox pcProgrammer;
	}
}