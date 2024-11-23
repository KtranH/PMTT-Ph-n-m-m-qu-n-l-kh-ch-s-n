using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.TaiNguyen_GUI
{
    public class XuLy_LoaiPhong
    {
        public LOAIPHONG_BLL db = new LOAIPHONG_BLL();
        public R2 R2 = new R2();
        //-----------------------------------------------------------------------------------------------------
        //Lấy ảnh từ R2
        public static async Task<Image> DownloadImageAsync(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var respone = await client.GetAsync(url);
                    if (respone.IsSuccessStatusCode)
                    {
                        using (var stream = await respone.Content.ReadAsStreamAsync())
                        {
                            Image image = Image.FromStream(stream);
                            Bitmap bitmap = new Bitmap(150, 150);
                            using (Graphics g = Graphics.FromImage(bitmap))
                            {
                                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                g.DrawImage(image, 0, 0, 150, 150);
                            }
                            return bitmap;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
            return null;
        }
        //-----------------------------------------------------------------------------------------------------
        //-----------------------------------------------------------------------------------------------------
        //Xử lý tải ảnh và thêm ảnh vào R2 và database
        public async void uploadImage(int ID, string nameCate)
        {
            int count = db.GetCountLoaiPhong(ID);
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                openFileDialog.Multiselect = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    List<string> selectedFiles = openFileDialog.FileNames.ToList();

                    foreach (string item in selectedFiles)
                    {
                        String linkImage = await R2.UploadImageToR2(item, nameCate, count);
                        HINHLOAIPHONG newHinh = new HINHLOAIPHONG();
                        newHinh.HINH = linkImage;
                        newHinh.LOAIPHONG_ID = ID;
                        db.AddHinhLoaiPhong(newHinh);
                        count++;
                    }
                    MessageBox.Show("Thêm ảnh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        //-----------------------------------------------------------------------------------------------------

    }
}
