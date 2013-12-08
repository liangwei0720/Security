using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Monitor.Component.Model;
using System.IO;
using System.Drawing.Imaging;
using Monitor.Component.BLL;

namespace Monitor.Manager.BaseSettingForm
{
    public partial class SaveImageInfo : Form
    {
        private ImageInfo oInfo = new ImageInfo ( );
        public int ImageID { get; set; }

        public SaveImageInfo ( )
        {
            InitializeComponent ( );
        }

        /// <summary>
        /// 获取用户上传的图片信息
        /// </summary>
        /// <returns></returns>
        private byte[] GetImage ( )
        {
            if (this.textBox1.Text.Trim ( ).Length == 0 )
            {
                if (oInfo.ImageData == null)
                {
                    return null;
                }
                return oInfo.ImageData;
            }
            try
            {
                FileInfo fi = new FileInfo (this.textBox1.Text);
                long imgLength = fi.Length;

                //将图片转为2进制保存
                MemoryStream stream = new MemoryStream ( );
                Image.FromFile (this.textBox1.Text).Save (stream, ImageFormat.Bmp);
                byte[] byteImage = new byte[imgLength];
                byteImage = stream.ToArray ( );

                return byteImage;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        /// <summary>
        /// 为图片控件赋值
        /// </summary>
        /// <param name="byteImage"></param>
        private void SetImageToPicture ( byte[] byteImage )
        {
            try
            {
                MemoryStream stream = new MemoryStream ( );
                stream.Write (byteImage, 0, byteImage.Length);
                this.pictureBox1.Image = Image.FromStream (stream);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void SaveImageInfo_Load ( object sender, EventArgs e )
        {
            if (ImageID == 0)
            {
                return;
            }
            DataTable dt = new ImageInfoManager ( ).GetImageInfo (ImageID);

            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show ("信息未找到", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            oInfo.ID = (int)dt.Rows[0]["id"];
            oInfo.ImageData = (byte[])dt.Rows[0]["ImageData"];
            oInfo.ImageName = (string)dt.Rows[0]["ImageName"];
            oInfo.OrderNumber = (int)dt.Rows[0]["OrderNumber"];
            oInfo.UpdatePerson = (string)dt.Rows[0]["UpdatePerson"];
            oInfo.UpdateTime = (DateTime)dt.Rows[0]["UpdateTime"];
            this.Text = this.label1.Text = "编辑图片信息";

            this.txtImageName.TextValue = oInfo.ImageName;
            this.txtSort.TextValue = oInfo.OrderNumber.ToString ( );
            SetImageToPicture (oInfo.ImageData);

        }

        private void btnCancel_Click ( object sender, EventArgs e )
        {
            this.Close ( );
        }

        private void btnAdd_Click ( object sender, EventArgs e )
        {
            if (this.txtImageName.TextValue.Length == 0)
            {
                MessageBox.Show ("请输入图片名称", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int iSort;
            int.TryParse (this.txtSort.TextValue, out iSort);

            byte[] bImage = GetImage ( );
            if (bImage == null || bImage.Length == 0)
            {
                MessageBox.Show ("请选择要上传的图片", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            oInfo = new ImageInfo ( ) { ImageData = bImage, UpdateTime = DateTime.Now, UpdatePerson = string.Empty, ImageName = txtImageName.TextValue };
            if (ImageID > 0)
            {
                oInfo.ID = ImageID;
            }
            new ImageInfoManager ( ).SaveImageInfo (oInfo);

            if (oInfo.ID > 0)
            {
                if (ImageID == 0)
                {
                    if (DialogResult.Yes == MessageBox.Show ("信息添加成功。是否继续添加信息?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    {
                        this.textBox1.Text = this.txtImageName.TextValue = txtSort.TextValue = string.Empty;
                        this.pictureBox1.Image = null;
                    }
                    else
                    {
                        this.Close ( );
                    }
                }
                else
                {
                    MessageBox.Show ("信息提交成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Close ( );
                }
            }
            else
            {
                MessageBox.Show ("信息提交失败。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void textBox1_DoubleClick ( object sender, EventArgs e )
        {
            btnBrower_Click (null, null);
        }

        private void btnBrower_Click ( object sender, EventArgs e )
        {
            if (this.openFileDialog1.ShowDialog ( ) == DialogResult.OK)
            {
                this.textBox1.Text = this.openFileDialog1.FileName;
                this.pictureBox1.ImageLocation = this.textBox1.Text;
            }
        }
    }
}
