using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HslCommunication;
using HslCommunication.Core;
using System.Windows.Forms;
namespace DELTARobot_Demo
{
    public class DemoUtils
    {
        public static void BulkReadRenderResult(HslCommunication.Core.IReadWriteNet readWrite, TextBox addTextBox, TextBox lengthTextBox, TextBox resultTextBox)
        {
            try
            {
                OperateResult<byte[]> read = readWrite.Read(addTextBox.Text, ushort.Parse(lengthTextBox.Text));
                if (read.IsSuccess)
                {
                    resultTextBox.Text = "Result：" + HslCommunication.BasicFramework.SoftBasic.ByteToHexString(read.Content);
                }
                else
                {
                    MessageBox.Show("Read Failed：" + read.ToMessageShowString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Read Failed：" + ex.Message);
            }
        }
        public static readonly string IpAddressInputWrong = "IpAddress input wrong";
        public static readonly string PortInputWrong = "Port input wrong";
        public static readonly string SlotInputWrong = "Slot input wrong";
        public static readonly string BaudRateInputWrong = "Baud rate input wrong";
        public static readonly string DataBitsInputWrong = "Data bit input wrong";
        public static readonly string StopBitInputWrong = "Stop bit input wrong";
    }

}
