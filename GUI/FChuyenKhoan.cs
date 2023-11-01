using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using DTO;

namespace GUI
{
    public partial class FChuyenKhoan : Form
    {
        public static string soTien = string.Empty;
        public static bool checkChuyenKhoan = false;    
        public FChuyenKhoan()
        {
            InitializeComponent();

        }

        public FChuyenKhoan(string t)
        {
            InitializeComponent();
            soTien = t;
        }

        private void FChuyenKhoan_Load(object sender, EventArgs e)
        {
            try
            {
                using (WebClient client1 = new WebClient())
                {
                    var htmlData = client1.DownloadData("https://api.vietqr.io/v2/banks");
                    var bankRawJson = Encoding.UTF8.GetString(htmlData);
                    var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);
                }
                var apiRequest = new ApiRequest();
                apiRequest.acqId = Convert.ToInt32("970436");
                apiRequest.accountNo = long.Parse("9869178006");
                apiRequest.accountName = "Tran Tu Dat";
                apiRequest.amount = Convert.ToInt32(soTien);// so tien
                apiRequest.format = "text";
                apiRequest.template = "compact2";
                var jsonRequest = JsonConvert.SerializeObject(apiRequest);
                // use restsharp for request api.
                var client = new RestClient("https://api.vietqr.io/v2/generate");
                var request = new RestRequest();

                request.Method = Method.Post;
                request.AddHeader("Accept", "application/json");

                request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

                var response = client.Execute<ApiResponse>(request);
                var content = response.Content;
                var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


                var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
                pictureBox1.Image = image;
            }
            catch
            {
                MessageBox.Show("Kiểm Tra kết nối mạng");
            }
            

        }

        private void btn_ThanhCong_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Xác nhận thanh toán thành công?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Xử lý kết quả khi người dùng nhấn nút Yes hoặc No
            if (result == DialogResult.Yes)
            {
                checkChuyenKhoan = true;
                this.Close();
            }
        }

        public bool getCheckChuyenKhoan()
        {
            return checkChuyenKhoan;
        }

        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {

        }
    }
}
