using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBookTask1
{
    public partial class Form1 : Form
    {
        Lesson lesson = new Lesson();
            Student Elgun = new Student
            {
                FullName = "Abbasguliyev Elgun Fiday",
                LastMyStatSeen = "23.03.21",
            };
            Student Amin = new Student
            {
                FullName = "Aliyev Amin Allahyar",
                LastMyStatSeen = "23.03.21"
            };
            Student Ayxan = new Student
            {
                FullName = "Axundov Ayxan Aqil",
                LastMyStatSeen = "24.03.21"
            };
            Student Arifali = new Student
            {
                FullName = "Bagirli Arifali Azad",
                LastMyStatSeen = "26.03.21"
            };
            Student Zaur = new Student
            {
                FullName = "Ceferov Zaur Ceyhun",
                LastMyStatSeen = "21.03.21"
            };
            Student Mehrac = new Student
            {
                FullName = "Latifli Mehrac Ilham",
                LastMyStatSeen = "20.03.21",
            };
            Student Metin = new Student
            {
                FullName = "Rzayev Matin Ramazan",
                LastMyStatSeen = "22.03.21"
            };
            Student Rasul = new Student
            {
                FullName = "Osmanli Rasul Farhad",
                LastMyStatSeen = "24.03.21"
            };
        public Form1()
        {
            InitializeComponent();
            ElgunUc.StudentFullNameLbl.Text = Elgun.FullName;
            ElgunUc.LastSeenLbl.Text = Elgun.LastMyStatSeen;
            AminUc.StudentFullNameLbl.Text = Amin.FullName;
            AminUc.LastSeenLbl.Text = Amin.LastMyStatSeen;
            AyxanUc.StudentFullNameLbl.Text = Ayxan.FullName;
            AyxanUc.LastSeenLbl.Text = Ayxan.LastMyStatSeen;
            ArifaliUc.StudentFullNameLbl.Text = Arifali.FullName;
            ArifaliUc.LastSeenLbl.Text = Arifali.LastMyStatSeen;
            ZaurUc.StudentFullNameLbl.Text = Zaur.FullName;
            ZaurUc.LastSeenLbl.Text = Zaur.LastMyStatSeen;
            RasulUc.StudentFullNameLbl.Text = Rasul.FullName;
            RasulUc.LastSeenLbl.Text = Rasul.LastMyStatSeen;
            MatinUc.StudentFullNameLbl.Text = Metin.FullName;
            MatinUc.LastSeenLbl.Text = Metin.LastMyStatSeen;
            MehracUc.LastSeenLbl.Text = Mehrac.LastMyStatSeen;
            MehracUc.StudentFullNameLbl.Text = Mehrac.FullName;
        }
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void guna2ImageButton1_Click_2(object sender, EventArgs e)
        {
            SubjectRtxtbx.Visible = true;
            SaveSubjectBtn.Visible = true;
            DeleteSubjectBtn.Visible = true;
        }
        private void DeleteSubjectBtn_Click(object sender, EventArgs e)
        {
            SubjectRtxtbx.Text = "";
            SubjectRtxtbx.Visible = false;
            SaveSubjectBtn.Visible = false;
            DeleteSubjectBtn.Visible = false;
            MessageBox.Show("Description not stored");
        }
        private void SaveSubjectBtn_Click(object sender, EventArgs e)
        {
            lesson.Subject = SubjectRtxtbx.Text;
            MessageBox.Show("Description has created sucsessfully");
            SubjectRtxtbx.Visible = false;
            SaveSubjectBtn.Visible = false;
            DeleteSubjectBtn.Visible = false;
        }
        private void AlternateTutorRbtn_CheckedChanged(object sender, EventArgs e)
        {
            lesson.Tutor = AlternateTutorLbl.Text;
        }

        private void MainTutorRbtn_CheckedChanged(object sender, EventArgs e)
        {
            lesson.Tutor = MainTutorLbl.Text;

        }

        private void saveAllChangesBtn_Click(object sender, EventArgs e)
        {
            //json
        }

        private void ElgunUc_Load(object sender, EventArgs e)
        {

        }

        private void guna2CustomRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Elgun.Attendance = "Arrived On Time";
            Amin.Attendance = "Arrived On Time";
            Ayxan.Attendance = "Arrived On Time";
            Arifali.Attendance = "Arrived On Time";
            Zaur.Attendance = "Arrived On Time";
            Mehrac.Attendance = "Arrived On Time";
            Metin.Attendance = "Arrived On Time";
            Rasul.Attendance = "Arrived On Time";

        }
        //int scroll = 0;
        //private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        //{
        //    if (scroll == vScrollBar1.Value)
        //    {

        //        guna2GradientPanel2.Location = new Point(guna2GradientPanel2.Location.X, guna2GradientPanel2.Location.Y + 4);
        //    }
        //    else if (scroll < vScrollBar1.Value)
        //    {
        //        guna2GradientPanel2.Location = new Point(guna2GradientPanel2.Location.X, guna2GradientPanel2.Location.Y - 4);
        //    }
        //    else if (scroll > vScrollBar1.Value)
        //    {
        //        guna2GradientPanel2.Location = new Point(guna2GradientPanel2.Location.X, guna2GradientPanel2.Location.Y + 4);
        //    }
        //    scroll = vScrollBar1.Value;
        //}
    }
}
