using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Monitor.Component.BLL;
using Monitor.Component.Model;

namespace Monitor.Manager.WorkStationForms
{
    public partial class WorkStationsList : Form
    {
        private List<WorkStations> oList = new List<WorkStations> ( );

        public WorkStationsList ( )
        {
            InitializeComponent ( );
        }

        private void LoadData ( )
        {
            oList = WorkStationsManager.GetAllWorkStations ( );

            dgWorkStationsList.DataSource = oList;

        }

        private void UpdateDataGridCellValue ( )
        {
            List<Dorm> oList = DormManager.GetAllDormWithList ( );

            foreach (DataGridViewRow row in this.dgWorkStationsList.Rows)
            {
                row.Cells["tcDormName"].Value = (oList.Find (info => info.DormID == (Guid)row.Cells["tcDormID"].Value) ?? new Dorm ( )).DormNumber;
            }
        }

        private void WorkStationsList_Load ( object sender, EventArgs e )
        {
            this.lblTitle.Text = "工作站列表";
            groupBoxList.Text = "工作站信息列表";

            this.dgWorkStationsList.AutoGenerateColumns = false;
            LoadData ( );
        }

        private void btnSearch_Click ( object sender, EventArgs e )
        {
            if (this.txtWorkStationID.TextValue.Length > 0)
            {
                dgWorkStationsList.DataSource = oList.FindAll (station => station.StationID == this.txtWorkStationID.TextValue);
            }
            else
            {
                dgWorkStationsList.DataSource = oList;
            }
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            SaveWorkStation oSaveWorkStation = new SaveWorkStation ( );

            oSaveWorkStation.ShowDialog ( );

            this.LoadData ( );
        }

        private void dgWorkStationsList_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            SaveWorkStation oSaveWorkStation = new SaveWorkStation ( ) { StationID = (string)this.dgWorkStationsList.CurrentRow.Cells["tcStationID"].Value };

            oSaveWorkStation.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dgWorkStationsList, "tcCheck"))
            {
                CommonMethod.ShowWaringMessage ("请选择要编辑的项");
                return;
            }
            SaveWorkStation oSaveWorkStation = new SaveWorkStation ( ) { StationID = (string)this.dgWorkStationsList.SelectedRows[0].Cells["tcStationID"].Value };

            oSaveWorkStation.ShowDialog ( );

            this.LoadData ( );

        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!CommonMethod.CheckDataGridViewSelectItems (this.dgWorkStationsList, "tcCheck"))
            {
                CommonMethod.ShowWaringMessage ("请选择要删除的项");
                return;
            }

            foreach (DataGridViewRow row in this.dgWorkStationsList.Rows)
            {
                if (row.Cells["tcCheck"].Value != null && (bool)row.Cells["tcCheck"].Value)
                {
                    WorkStationsManager.DeleteWorkStations ((string)this.dgWorkStationsList.SelectedRows[0].Cells["tcStationID"].Value);
                }
            }

            CommonMethod.ShowWaringMessage ("所选信息已删除完毕。");

            this.LoadData ( );
        }

        private void dgWorkStationsList_DataBindingComplete ( object sender, DataGridViewBindingCompleteEventArgs e )
        {
            UpdateDataGridCellValue ( );
        }
    }
}
