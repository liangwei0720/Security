using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monitor.Component.Model
{
    public class Students
    {


        /// <summary>
        /// The guStudentID
        /// </summary>
        public Guid StudentID
        {
            get;
            set;
        }

        /// <summary>
        /// The guRoomID
        /// </summary>
        public Guid RoomID
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcStudentNumber
        /// </summary>
        public string StudentNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcStudentName
        /// </summary>
        public string StudentName
        {
            get;
            set;
        }

        /// <summary>
        /// The vbinImage
        /// </summary>
        public byte[] Image
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcMobile
        /// </summary>
        public string Mobile
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcRemark
        /// </summary>
        public string Remark
        {
            get;
            set;
        }

        /// <summary>
        /// The dtAddDate
        /// </summary>
        public DateTime AddDate
        {
            get;
            set;
        }

        /// <summary>
        /// The iCardNumber
        /// </summary>
        public int CardNumber
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcCardPwd
        /// </summary>
        public string CardPwd
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcClassName
        /// </summary>
        public string ClassName
        {
            get;
            set;
        }

        /// <summary>
        /// The iSchoolYear
        /// </summary>
        public int SchoolYear
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcSpecialty
        /// </summary>
        public string Specialty
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcFacultyName
        /// </summary>
        public string FacultyName
        {
            get;
            set;
        }

        /// <summary>
        /// The nvcStartSchoolYear
        /// </summary>
        public string StartSchoolYear
        {
            get;
            set;
        }

        /// <summary>
        /// The iGender
        /// </summary>
        public int Gender
        {
            get;
            set;
        }

        public int StudentIndex
        {
            get;
            set;
        }
        public string DormAndRoom
        {
            get;
            set;
        }

    }
}
