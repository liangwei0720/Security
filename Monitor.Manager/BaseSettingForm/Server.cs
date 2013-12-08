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

namespace Monitor.Manager.BaseSettingForm
{
    public partial class Server : Form
    {
        private List<Dorm> oList = DormManager.GetAllDormWithList ( );

        public Server ( )
        {
            InitializeComponent ( );

        }

        private void LoadData ( )
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = ServerManager.GetAllServer ( );

        }

        private bool CheckSelectedItems
        {
            get
            {
                bool blSelected = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["tcCheck"].Value != null && (bool)row.Cells["tcCheck"].Value)
                    {
                        blSelected = true;
                        break;
                    }
                }
                return blSelected;
            }
        }

        private void UpdateGridViewStatusValue ( )
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                row.Cells["tcDorm"].Value = (oList.Find (info => info.DormID == (Guid)row.Cells["tcDormID"].Value) ?? new Dorm ( )).DormNumber;

                row.Cells["tcStatus"].Value = (bool)row.Cells["tcSuccess"].Value ? "成功" : "失败";

            }

        }

        private void Server_Load ( object sender, EventArgs e )
        {
            LoadData ( );
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            SaveServer oSaveServer = new SaveServer ( );

            oSaveServer.ShowDialog ( );
            LoadData ( );

        }

        private void dataGridView1_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            SaveServer oSaveServer = new SaveServer ( ) { ServerID = (int)this.dataGridView1.CurrentRow.Cells["tcServerID"].Value };

            oSaveServer.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnEdit_Click ( object sender, EventArgs e )
        {
            if (!CheckSelectedItems)
            {
                MessageBox.Show ("请选择要编辑项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveServer oSaveServer = new SaveServer ( ) { ServerID = (int)this.dataGridView1.SelectedRows[0].Cells["tcServerID"].Value };

            oSaveServer.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnDel_Click ( object sender, EventArgs e )
        {
            if (!CheckSelectedItems)
            {
                MessageBox.Show ("请选择要删除的项", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DialogResult.Yes == MessageBox.Show ("确定要删除所选择的项吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((bool)row.Cells["tcCheck"].Value)
                    {
                        ServerManager.DeleteServer ((int)row.Cells["tcServerID"].Value);
                    }
                }

                MessageBox.Show ("所选择的信息的已全部删除", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.LoadData ( );

            }
        }

        private void dataGridView1_DataBindingComplete ( object sender, DataGridViewBindingCompleteEventArgs e )
        {
            UpdateGridViewStatusValue ( );
        }
    }
}
