using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Monitor.Component.BLL;

namespace Monitor.Manager.BaseSettingForm
{
	public partial class FacultiesList : Form
	{
		public FacultiesList( )
		{
			InitializeComponent( );
		}

		private void FacultiesList_Load(object sender, EventArgs e)
		{
			LoadData( );
		}

		private void LoadData( )
		{
			dgFaculties.DataSource = FacultiesManager.GetAllFaculties( );
		}
	}
}
