using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Monitor.Component.DAL;
using Monitor.Component.Model;

namespace Monitor.Component.BLL
{
    public class ImageInfoManager
    {
        /// <summary>
        /// 获取图片信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetImageInfo ( int ID )
        {
            return new ImageInfoDAL ( ).GetImageInfo (ID);
        }

        /// <summary>
        /// 获取图片信息
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public DataTable GetAllImageInfo ( string condition )
        {
            if (string.IsNullOrEmpty (condition))
            {
                condition = "1=1";
            }
            return new ImageInfoDAL ( ).GetAllImageInfo (condition);
        }

        /// <summary>
        /// 保存图片信息
        /// </summary>
        /// <param name="oT_ImageInfo"></param>
        public void SaveImageInfo ( ImageInfo oT_ImageInfo, string clientIPConnection )
        {
            new ImageInfoDAL ( ).SaveImageInfo (oT_ImageInfo, clientIPConnection);

        }

        /// <summary>
        /// 保存图片信息
        /// </summary>
        /// <param name="oT_ImageInfo"></param>
        public void SaveImageInfo ( ImageInfo oT_ImageInfo )
        {
            new ImageInfoDAL ( ).SaveImageInfo (oT_ImageInfo);

        }

        /// <summary>
        /// 删除一个图片信息
        /// </summary>
        /// <param name="intID"></param>
        public static void DeleteT_ImageInfo ( int intID )
        {
            new ImageInfoDAL ( ).DeleteT_ImageInfo (intID);
        }
    }
}
