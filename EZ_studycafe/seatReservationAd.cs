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
    public partial class seatReservationAd : Form
    {
        string connectionString = "User Id=scott; Password=tiger; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME =xe) ) );";

        public seatReservationAd()
        {
            InitializeComponent();
            LoadSeatData();
        }

        private void LoadSeatData()
        {
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = @"
            SELECT 
                S.SEAT_ID AS ""좌석 번호"",
                SC.CATEGORY_NAME AS ""좌석명"",
                S.SEAT_STATUS AS ""좌석상태"",
                CASE WHEN S.SEAT_STATUS = '사용중' THEN U.NAME ELSE NULL END AS ""사용자명"",
                CASE WHEN S.SEAT_STATUS = '사용중' THEN SR.RENTAL_DURATION ELSE NULL END AS ""대여시간"",
                CASE WHEN S.SEAT_STATUS = '사용중' THEN SR.RENTAL_START ELSE NULL END AS ""시작 시간""
            FROM SEAT S
            LEFT JOIN SEAT_CATEGORY SC
                ON S.CATEGORY_ID = SC.CATEGORY_ID
            LEFT JOIN (
                SELECT 
                    SEAT_ID, USER_ID, RENTAL_DURATION, RENTAL_START,
                    ROW_NUMBER() OVER (PARTITION BY SEAT_ID ORDER BY RENTAL_START DESC) AS RN 
                FROM SEAT_RENTAL
            ) SR 
                ON S.SEAT_ID = SR.SEAT_ID AND SR.RN = 1
            LEFT JOIN ""USER"" U 
                ON SR.USER_ID = U.USER_ID
            ORDER BY CAST(S.SEAT_ID AS NUMBER)"; // 좌석 번호를 숫자로 변환하여 오름차순 정렬

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        DataTable seatTable = new DataTable();
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            adapter.Fill(seatTable);
                        }

                        seatReserDataGridView.DataSource = seatTable.Rows.Count > 0 ? seatTable : null;

                        // DataGridView 컬럼 크기 설정
                        seatReserDataGridView.Columns["좌석 번호"].Width = 80;  // 좌석 번호 (두 자리 숫자 정도)
                        seatReserDataGridView.Columns["대여시간"].Width = 80;   // 대여시간 (두 자리 숫자 정도)
                        seatReserDataGridView.Columns["좌석명"].Width = 90;     // 좌석명 (한글 3글자 정도)
                        seatReserDataGridView.Columns["좌석상태"].Width = 100;
                        seatReserDataGridView.Columns["사용자명"].Width = 90;
                        seatReserDataGridView.Columns["시작 시간"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // 나머지 컬럼
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"좌석 데이터를 불러오는데 실패했습니다: {ex.Message}", "오류");
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
