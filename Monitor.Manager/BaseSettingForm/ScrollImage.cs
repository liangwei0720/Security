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
    public partial class ScrollImage : Form
    {
        DataTable oTableImageInfo = new DataTable ( );
        public ScrollImage ( )
        {
            InitializeComponent ( );
        }
        private void LoadData ( )
        {
            oTableImageInfo = new ImageInfoManager ( ).GetAllImageInfo ("");
            this.dgList.DataSource = oTableImageInfo;

            btnUpdateToClient.Visible = oTableImageInfo.Rows.Count > 0;
        }
        private bool CheckSelectedItems
        {
            get
            {
                bool blSelected = false;
                foreach (DataGridViewRow row in dgList.Rows)
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
        private void btnAdd_Click ( object sender, EventArgs e )
        {
            SaveImageInfo oSaveImageInfo = new SaveImageInfo ( );

            oSaveImageInfo.ShowDialog ( );

        }

        private void ScrollImage_Load ( object sender, EventArgs e )
        {
            this.dgList.AutoGenerateColumns = false;

            LoadData ( );
        }

        private void dgList_CellDoubleClick ( object sender, DataGridViewCellEventArgs e )
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            SaveImageInfo oSaveImageInfo = new SaveImageInfo ( ) { ImageID = (int)this.dgList.CurrentRow.Cells["tcID"].Value };

            oSaveImageInfo.ShowDialog ( );

            this.LoadData ( );
        }

        private void btnUpdateToClient_Click ( object sender, EventArgs e )
        {
            if (DialogResult.No == MessageBox.Show ("确定要更新当前的信息到所有客户端吗？\n\n更新所需的时间和网络有一定的关系。\n\n更新过程中，系统可能无响应。请耐心等待。", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                return;
            }

            List<Component.Model.Server> oListServer = ServerManager.GetAllServer ( );

            bool bIsFirst = true;
            foreach (Component.Model.Server oServer in oListServer)
            {
                foreach (DataRow row in oTableImageInfo.Rows)
                {
                    new ImageInfoManager ( ).SaveImageInfo (new ImageInfo ( )
                    {
                        ID = (int)row["ID"],
                        ImageData = (byte[])row["ImageData"],
                        ImageName = (string)row["ImageName"],
                        UpdateTime = DateTime.Now,
                        UpdatePerson = (string)row["UpdatePerson"],
                        OrderNumber = (int)row["OrderNumber"],
                        IsFirst=bIsFirst
                    }, oServer.Connection);
                }

                bIsFirst = false;
            }

            CommonMethod.ShowWaringMessage ("信息已全部更新到客户端");
        }
    }
}
