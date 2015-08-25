using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Packaging
{
    public partial class UC_Monitor : UserControl
    {
      //  TxtData.TpRobot tp;
        string[] Wm = new string[] { "", "手动", "测试", "自动", "远程", "","","","","","","","" };
        public UC_Monitor()
        {
            InitializeComponent();
        }

        //   public TPControl1( )
        //{
        //    InitializeComponent();
        //}

        //public void RefreshData(TxtData.TpRobot t)
        //{

        //    LL_IP.Text = "IP:" + t.IpAddress;
        //    LL_Com1.Text = "通讯:" + (t.SoapStaus ? "正常" : "异常");
        //    LL_Com1.ForeColor = t.SoapStaus ? Color.Black : Color.Red;
        //    LL_Prog1.Text = "程序运行:" + (t.ProgRun ? "正常" : "异常");
        //    LL_Prog1.ForeColor = t.ProgRun ? Color.Black : Color.Red;
        //    if (t._nWorkMode > 0 && t._nWorkMode <=4)
        //    {
        //        LL_WM1.Text = "工作模式:" + Wm[t._nWorkMode];
        //    }

        //    LL_EMO.Text = "急停按钮:" + (t._bEmerStop ? "激活" : "正常");
        //    LL_EMO.ForeColor =t._bEmerStop ? Color.Red: Color.Black;

        //    LL_CT1.Text = "控制器温度:" + t.ControllerTemp;
        //    LL_Power1.Text = "手臂电源:" + (t._bIsPowered ? "上电" : "下电");

        //    LL_nTrackErr.Text = "跟踪超限次数:" + t._nTrackErr.ToString();
        //    LL_nCntPartsDone.Text = "已完成数量:" + t._nCntPartsDone.ToString();
        //    ll_nCntTransfered.Text = "已向后传递数量" + t._nCntTransfered.ToString();
        //    LL_nCurCapacity.Text = "当前产能" + t._nCurCapacity.ToString();
        //    ll_nAveCapacity.Text = "平均产能:" + t._nAveCapacity.ToString();

        //    if (t._nOmacStat>0 &&t._nOmacStat<12)
        //    {
        //        ll_nOmacStat.Text = "机器人当前状态:"+TxtData.PublicData.ToolStatus[(int)t._nOmacStat];
        //    }

        //    LL_nConvCurSpeed.ForeColor=((t._nConvCurSpeed > 500))?Color.Red:Color.Black;
        //    LL_nConvCurSpeed.Text = "传送带速度:" +((int) t._nConvCurSpeed).ToString() + "mm/s";



        //    if (t.Joint != null && t.Joint.Length >= 4)
        //    {
        //        LL_j1.Text = "j1:" + t.Joint[0].ToString("0.000");
        //        LL_j2.Text = "j2:" + t.Joint[1].ToString("0.000");
        //        LL_j3.Text = "j3:" + (t.Joint[2]*17.452).ToString("0.000");
        //        LL_j4.Text = "j4:" + t.Joint[3].ToString("0.000");

        //        if (t.JointMin != null && t.JointMax != null && t.JointMax.Length >= 4 && t.JointMin.Length >= 4)
        //        {
        //             //ll_axis.Text = "eok";


        //            if (t.Joint[0] < t.JointMin[0] || t.Joint[0] > t.JointMax[0])
        //            {
        //                LL_j1.ForeColor = Color.Red;
        //            }
        //            else
        //            {
        //                LL_j1.ForeColor = Color.Black;
        //            }

        //            if (t.Joint[1] < t.JointMin[1] || t.Joint[1] > t.JointMax[1])
        //            {
        //                LL_j2.ForeColor = Color.Red;
        //            }
        //            else
        //            {
        //                LL_j2.ForeColor = Color.Black;
        //            }


        //            if ((t.Joint[2] * 17.452) < t.JointMin[2] || (t.Joint[2] * 17.452) > t.JointMax[2])
        //            {
        //                LL_j3.ForeColor = Color.Red;
        //            }
        //            else
        //            {
        //                LL_j3.ForeColor = Color.Black;
        //            }


        //            if (t.Joint[3] < t.JointMin[3] || t.Joint[3] > t.JointMax[3])
        //            {
        //                LL_j4.ForeColor = Color.Red;
        //            }
        //            else
        //            {
        //                LL_j4.ForeColor = Color.Black;
        //            }

        //        }
        //        else
        //        {
        //            //ll_axis.Text = "error";
        //        }
        //    }


        //}

        private void timer_Refresh_Tick(object sender, EventArgs e)
        {
             



        }




    }
}



