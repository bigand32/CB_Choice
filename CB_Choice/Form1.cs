using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CB_Choice
{
    public partial class Form1 : Form
    {
        string[] SList = new string[]{"김밥", "샐러드김밥", "야채김밥",
            "소고기김밥" ,"계란김밥", "라볶이"};
        string orgStr = ""; // 선택 결과 저장
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <this.SList.Length; i++)
            {
                this.cbList.Items.Add(SList[i]);
            }
            if(cbList.Items.Count > 0) {
            this.cbList.SelectedIndex = 0;
            }
            this.orgStr = lblResult.Text;
 

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.txtList.Text != "")
            {
                this.cbList.Items.Add(this.txtList.Text);
                MessageBox.Show("아이템을 추가하였습니다.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("아이템을 입력해주세요.", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtList.Focus();
            }
            this.txtList.Text = "";

        }

        private void cbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbList.Text != "")
            {
                this.lblResult.Text = orgStr + this.cbList.Text;
            }

        }
    }
}
