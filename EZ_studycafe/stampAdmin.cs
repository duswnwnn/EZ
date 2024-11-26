using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace EZ_studycafe
{
    public partial class stampAdmin : Form
    {
        // Label 필드로 변경
        private Label userNameLabel;
        private int currentStampCount;

        // 데이터베이스 연결 문자열
        private string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";

        public stampAdmin(string userName, int stampCount)
        {
            InitializeComponent();

            // 전달받은 데이터 저장 및 라벨 업데이트
            this.currentStampCount = stampCount;

            // userNameLabel은 Form Designer에서 생성된 Label 컨트롤입니다.
            userNameLabel.Text = $"{userName} 님";
            nowStamp.Text = $"{stampCount} 개";
        }

        // 추가 버튼 클릭
        private void addBtn_Click(object sender, EventArgs e)
        {
            UpdateStampCount(true);
        }

        // 삭제 버튼 클릭
        private void delBtn_Click(object sender, EventArgs e)
        {
            UpdateStampCount(false);
        }

        // 스탬프 업데이트 처리
        private void UpdateStampCount(bool isAdd)
        {
            if (!int.TryParse(stampTextBox.Text, out int input))
            {
                MessageBox.Show("유효한 숫자를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (input < 0)
            {
                MessageBox.Show("0 이상의 숫자를 입력해주세요.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int newStampCount = isAdd ? currentStampCount + input : currentStampCount - input;
            if (newStampCount < 0)
            {
                newStampCount = 0;
            }

            try
            {
                using (OracleConnection conn = new OracleConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE \"USER\" SET STAMP_COUNT = :newStampCount WHERE NAME = :userName";
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        cmd.Parameters.Add(new OracleParameter("newStampCount", newStampCount));
                        cmd.Parameters.Add(new OracleParameter("userName", userNameLabel.Text.Replace(" 님", ""))); // 이름에서 " 님" 제거
                        cmd.ExecuteNonQuery();
                    }
                }

                currentStampCount = newStampCount;
                nowStamp.Text = $"{newStampCount} 개";
                MessageBox.Show("스탬프가 성공적으로 업데이트되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"스탬프 업데이트 중 오류 발생: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 뒤로가기 버튼
        private void backStamp_Click(object sender, EventArgs e)
        {
            this.Close(); // 현재 폼 닫기
        }
    }
}
