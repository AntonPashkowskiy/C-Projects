using System.Windows.Forms;

namespace Game
{
	public partial class Help : Form
	{
		public Help( string header, string helpMessage )
		{
			InitializeComponent();

			this.Text = header;
			tbHelp.Text = helpMessage;
		}
	}
}
