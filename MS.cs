using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication.Profinet;
using HslCommunication;
using HslCommunication.ModBus;
using System.Threading;

namespace DELTARobot_Demo.MS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }        
        private void Form1_Load(object sender, EventArgs e)//初始化加载程序
        {
            //关闭断线按钮
            stop_ConstantRead.Enabled = false;
            //跨线程，使得多线程的modbus读取数值能够被写入窗体，后续改为更安全的方式
            //System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        #region 定义区
        //创建新对象 DELTARobotClient
        private ModbusTcpNet DELTARobotClient = null;
        //新线程threadRead
        private System.Threading.Thread threadRead;
        //不懂原理,线程休眠时间
        private int timeSleep = 100;
        //plc读取状态
        private bool isReadPlc = false;
        #endregion
        private void connect_btn_Click(object sender, EventArgs e)//modbustcp连接
        {
            // 连接
            if (!System.Net.IPAddress.TryParse(IpAddress.Text, out System.Net.IPAddress address))
            {
                MessageBox.Show(DemoUtils.IpAddressInputWrong);
                return;
            }


            if (!int.TryParse(PortNum.Text, out int port))
            {
                MessageBox.Show(DemoUtils.PortInputWrong);
                return;
            }


            if (!byte.TryParse(stationNum.Text, out byte station))
            {
                MessageBox.Show("Station input is wrong！");
                return;
            }

            DELTARobotClient?.ConnectClose();
            DELTARobotClient = new ModbusTcpNet(IpAddress.Text, port, station);
            DELTARobotClient.AddressStartWithZero = checkBox1.Checked;



            comboBox1_SelectedIndexChanged(null, new EventArgs());  // 设置数据服务
            DELTARobotClient.IsStringReverse = checkBox3.Checked;

            try
            {
                OperateResult connect = DELTARobotClient.ConnectServer();
                if (connect.IsSuccess)
                {
                    MessageBox.Show(HslCommunication.StringResources.Language.ConnectedSuccess);
                    disconnect_btn.Enabled = true;
                    connect_btn.Enabled = false;
                }
                else
                {
                    MessageBox.Show(HslCommunication.StringResources.Language.ConnectedFailed + connect.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)//ABCD排列顺序选择
        {
            if (DELTARobotClient != null)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0: DELTARobotClient.DataFormat = HslCommunication.Core.DataFormat.ABCD; break;
                    case 1: DELTARobotClient.DataFormat = HslCommunication.Core.DataFormat.BADC; break;
                    case 2: DELTARobotClient.DataFormat = HslCommunication.Core.DataFormat.CDAB; break;
                    case 3: DELTARobotClient.DataFormat = HslCommunication.Core.DataFormat.DCBA; break;
                    default: break;
                }
            }
        }
        #region 批量读取
        private void batchRead_Click(object sender, EventArgs e)
        {
            DemoUtils.BulkReadRenderResult(DELTARobotClient, textBox6, textBox9, textBox10);
        }
        #endregion
        private void disconnect_btn_Click(object sender, EventArgs e)//modbustcp断开连接
        {
            // 断开连接
            DELTARobotClient.ConnectClose();
            disconnect_btn.Enabled = false;
            connect_btn.Enabled = true;
        }

        #region 实时读写
        private void constantRW_Click(object sender, EventArgs e)//开始多线程读取
        {
            //关闭连线按钮
            constantRW.Enabled = false;
            //打开断线按钮
            stop_ConstantRead.Enabled = true;
            //读取旗标
            isReadPlc = true;
            //创建新线程
            threadRead = new Thread(ThreadReadRobot);
            //将线程设定为后台线程
            threadRead.IsBackground = true;
            //启动该线程，执行方法ThreadReadRobot到最后多线程会在GC中销毁
            threadRead.Start();

        }
        private void threadReadFun()
        {
            textBox17.Text = textBox17.Text + DELTARobotClient.ReadFloat("1").Content;
        }
        private void stop_ConstantRead_Click(object sender, EventArgs e)//停止多线程读取
        {
            //打开连线按钮
            constantRW.Enabled = true;
            //关闭断线按钮
            stop_ConstantRead.Enabled = false;
            //读取旗标
            isReadPlc = false;
            //停止多线程
            threadRead?.Abort();
        }
        private void ThreadReadRobot()//多线程读取方法
        {
            while (isReadPlc)
            {
                Thread.Sleep(timeSleep);
                if(isReadPlc)
                {
                    this.Invoke(new Action(() =>
                    {
                        threadReadFun();
                    }));
                }
            }
        }
        ///

        #endregion

        
    }
}
