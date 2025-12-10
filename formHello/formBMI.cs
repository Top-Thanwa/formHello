using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formHello
{
    public partial class formBMI : Form
    {
        public formBMI()
        {
            InitializeComponent();
        }

        private void formBMI_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            MessageBox.Show("Program BMI", "Welcome to");
        }

        private void btnOK_MouseHover(object sender, EventArgs e)
        {
            btnOK.BackColor = Color.DimGray;
            btnOK.ForeColor = Color.White;
        }

        private void btnOK_MouseLeave(object sender, EventArgs e)
        {
            btnOK.BackColor = SystemColors.Control;
            btnOK.ForeColor = SystemColors.ControlText;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            int weight = 0;
            double height = 0.0, cm = 0.0;
            double bmi = 0.0;
            string result = "";

            //เช็ก error และ คำนวณ
            if (int.TryParse(txtWeight.Text, out weight) && double.TryParse(txtHeight.Text, out cm))
            {
                height = cm / 100;
                bmi = weight / (height * height);
                lblResult.Text = string.Format("{0:F2}", bmi);

                //แปลผล
                if (bmi < 18.6)
                {
                    lblResult1.Text = string.Format("น้ำหนักน้อยกว่าปกติก็ไม่ค่อยดี หากคุณสูงมากแต่น้ำหนักน้อยเกินไป " +
                        "อาจเสี่ยงต่อการได้รับสารอาหารไม่เพียงพอหรือได้รับพลังงานไม่เพียงพอ ส่งผลให้ร่างกายอ่อนเพลียง่าย " +
                        "การรับประทานอาหารให้เพียงพอ และการออกกำลังกายเพื่อเสริมสร้างกล้ามเนื้อสามารถช่วยเพิ่มค่า BMI " +
                        "ให้อยู่ในเกณฑ์ปกติได้");
                }
                else if (bmi < 25)
                {
                    lblResult1.Text = string.Format("น้ำหนักที่เหมาะสมสำหรับคนไทยคือค่า BMI ระหว่าง 18.5-24 " +
                        "จัดอยู่ในเกณฑ์ปกติ ห่างไกลโรคที่เกิดจากความอ้วน และมีความเสี่ยงต่อการเกิดโรคต่าง ๆ น้อยที่สุด " +
                        "ควรพยายามรักษาระดับค่า BMI ให้อยู่ในระดับนี้ให้นานที่สุด และควรตรวจสุขภาพทุกปี");
                }
                else if (bmi < 30)
                {
                    lblResult1.Text = string.Format("อ้วนในระดับหนึ่ง ถึงแม้จะไม่ถึงเกณฑ์ที่ถือว่าอ้วนมาก ๆ " +
                        "แต่ก็ยังมีความเสี่ยงต่อการเกิดโรคที่มากับความอ้วนได้เช่นกัน ทั้งโรคเบาหวาน และความดันโลหิตสูง " +
                        "ควรปรับพฤติกรรมการทานอาหาร ออกกำลังกาย และตรวจสุขภาพ");
                }
                else
                {
                    lblResult1.Text = string.Format("ค่อนข้างอันตราย เสี่ยงต่อการเกิดโรคร้ายแรงที่แฝงมากับความอ้วน " +
                        "หากค่า BMI อยู่ในระดับนี้ จะต้องปรับพฤติกรรมการทานอาหาร และควรเริ่มออกกำลังกาย " +
                        "และหากเลขยิ่งสูงกว่า 40.0 ยิ่งแสดงถึงความอ้วนที่มากขึ้น ควรไปตรวจสุขภาพ และปรึกษาแพทย์");
                }
            }
            else
            {
                MessageBox.Show("ลองอีกครั้ง", "ข้อมูลผิดพลาด");
            }

        }
    }
}
