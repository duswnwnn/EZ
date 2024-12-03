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
    public partial class seatAdmin : Form
    {
        private OracleConnection conn;

        public seatAdmin()
        {
            InitializeComponent();
            // 데이터베이스 연결 초기화
            conn = new OracleConnection("User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );");
            LoadSeatData();
        }

        private void LoadSeatData()
        {
            try
            {
                // 연결 상태 확인 후 Open
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query = @"
                    SELECT S.SEAT_ID AS 좌석번호, SC.CATEGORY_NAME AS 좌석분류
                    FROM SEAT S
                    JOIN SEAT_CATEGORY SC ON S.CATEGORY_ID = SC.CATEGORY_ID";
                OracleDataAdapter adapter = new OracleDataAdapter(query, conn);
                DataTable seatTable = new DataTable();
                adapter.Fill(seatTable);

                seatAdminDataGridView.DataSource = seatTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터를 불러오는 중 오류 발생: {ex.Message}");
            }
            finally
            {
                // 연결 상태 확인 후 Close
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void seatAdminDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // 유효한 행 클릭
            {
                DataGridViewRow row = seatAdminDataGridView.Rows[e.RowIndex];
                seatNumber.Text = row.Cells["좌석번호"].Value.ToString();
                seatCategory.Text = row.Cells["좌석분류"].Value.ToString();
            }
        }

        private void seatModificationBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seatNumber.Text) || string.IsNullOrEmpty(seatCategory.Text))
            {
                MessageBox.Show("좌석 번호와 분류를 입력하세요.");
                return;
            }

            try
            {
                // 연결 상태 확인 후 Open
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string updateQuery = @"
                    UPDATE SEAT 
                    SET CATEGORY_ID = (SELECT CATEGORY_ID FROM SEAT_CATEGORY WHERE CATEGORY_NAME = :CategoryName)
                    WHERE SEAT_ID = :SeatID";

                using (OracleCommand cmd = new OracleCommand(updateQuery, conn))
                {
                    cmd.Parameters.Add(":CategoryName", seatCategory.Text);
                    cmd.Parameters.Add(":SeatID", seatNumber.Text);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("수정이 완료되었습니다.");
                        LoadSeatData(); // 데이터 다시 로드
                    }
                    else
                    {
                        MessageBox.Show("수정에 실패했습니다. 입력값을 확인하세요.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"수정 중 오류 발생: {ex.Message}");
            }
            finally
            {
                // 연결 상태 확인 후 Close
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        private void sseatSearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string query;
                if (string.IsNullOrEmpty(textBox3.Text)) // 검색어가 없으면 전체 출력
                {
                    query = @"
                SELECT S.SEAT_ID AS 좌석번호, SC.CATEGORY_NAME AS 좌석분류
                FROM SEAT S
                JOIN SEAT_CATEGORY SC ON S.CATEGORY_ID = SC.CATEGORY_ID";
                }
                else // 검색어가 있으면 조건부 출력
                {
                    query = @"
                SELECT S.SEAT_ID AS 좌석번호, SC.CATEGORY_NAME AS 좌석분류
                FROM SEAT S
                JOIN SEAT_CATEGORY SC ON S.CATEGORY_ID = SC.CATEGORY_ID
                WHERE S.SEAT_ID LIKE :SearchText
                   OR SC.CATEGORY_NAME LIKE :SearchText";
                }

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    if (!string.IsNullOrEmpty(textBox3.Text)) // 검색어가 있으면 파라미터 추가
                    {
                        cmd.Parameters.Add(":SearchText", $"%{textBox3.Text}%");
                    }

                    OracleDataAdapter adapter = new OracleDataAdapter(cmd);
                    DataTable seatTable = new DataTable();
                    adapter.Fill(seatTable);

                    seatAdminDataGridView.DataSource = seatTable; // 결과 출력
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"검색 중 오류 발생: {ex.Message}");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void backSeat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            admin showadmin = new admin();
            showadmin.ShowDialog();
        }
    }
}