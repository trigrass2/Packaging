using System;
using System.Collections.Generic;
using System.Text;

//多用结构体，少用数组

namespace Packaging
{
    class TxtData
    {


        /// <summary>
        /// 为系统建立4个机器人配置信息
        /// </summary>
        public static SysConfig[] RobotCfg = new SysConfig[4];

        /// <summary>
        /// 绑定当前机器人序号
        /// </summary>
        public static string[] RobotIndex = new string[] { "1", "2", "3", "4" };


        /// <summary>
        /// 每个界面的机械人序列号
        /// </summary>
        public static string[] ScreenRobotIndex = new string[100];



        public static string[] DIRemark = new string[]
        {
            "机器人复位","机器人启动","机器人暂停","机器人停止","货盘1清零","货盘2清零","货盘3清零","货盘4清零"
        
        };
        public static string[] DORemark = new string[]
        {
            "传送带1触发", "传送带2触发", "传送带3触发", "传送带4触发", "传送带1启停", "传送带2启停", "传送带3启停", "传送带4启停",
            "机器人报警","机器人已停止","机器人已复位","机器人已启动","机器人已暂停"     
        
        };
        public static string[] AIRemark = new string[]
        {
           // "机器人复位", "机器人启动", "机器人暂停", "机器人停止", "货盘1清零", "货盘2清零", "货盘3清零", "货盘4清零"
                   
        
        };

        public static string[] AORemark = new string[]
        {
            "传送带1调速", "传送带2调速", "传送带3调速", "传送带4调速"

        };


                


        /// <summary>
        /// 系统配置中每个机器人的配置信息
        /// </summary>
        public struct SysConfig
        {

            public bool IsServer;
            public bool IsConnected;
            public string Cs8cIp;
            public string Cs8cProg;



        }







        /// <summary>
        /// 下位机配置文件
        /// </summary>
        public struct CS8CConfigure
        {

            //public static bool BigFileMode = false;
            //public static bool TeachToolCaiEnable = false;//public static bool MoveBackEnable = false;
            //public static bool BoxCarEnable = false;
            //public static bool Axis7Enable = false;
            //public static bool StepMoveEnable = false;
            //public static bool WeldEnable = false;

            public static bool[] EnableItem = new bool[8];
            public static double HomeSpeed = 0;

            public static double StepLength = 0;





            public static double[] Home = new double[6];
            public static double[] Tool = new double[6];
            public static double[] Cornerdata = new double[6];
            public static double[] ExtAxisData = new double[6];
            public static double[] Ext8AxisData = new double[6];
            public static double[] Sync7Axis = new double[6];
            public static double[] Sync8Axis = new double[6];
            public static double[] PresetData = new double[6];
            public static double[] IODelay = new double[6];
            public static double[] BoxCar = new double[6];


            public static bool ViewPackaging;

        }

        /// <summary>
        /// 产品文件
        /// </summary>
        public struct Recipe
        {
            public static string[] TrajTypeName;

            public static string RecipeName;

            public static int TotalTraj;

            public static string[] TrajName;
            public static int[] TrajType;

            public static bool[] TrajByPass;
            public static int[,] TrajPointCount;
            public static bool[][] bAppro;
            public static bool[][] bMoveC;
            public static bool[][] bLeave;

            public static double[][,] pAppro;
            public static double[][,] pCut;
            public static double[][,] pMoveC;
            public static double[][,] pLeave;

            public static double[][,] mAppro;
            public static double[][,] mLeave;

            public static double[][,] mCut;


            public static double[] RecipeFrame;

            public static double[] RecipeOffset;

            public static double[,] TrajFrame;

            public static double[,] TrajOffset;

            public static double[,] Array;
            public static double[,] DownLead;
            public static double[,] WorkPlace;

            public static double[,] Delay;
            public static string AdjustRecipe;


        }

        /// <summary>
        /// 上下位机相互交换
        /// </summary>
        public struct DataBase
        {

            public static string ControllerTemp;
            public static bool SoapStaus;
            public static bool SoapAbort;
            public static int InterfaceType = -1;

            public static double RobotSpeed;

            public static int ToolMode = -1;
            public static bool IsHome = false;
            public static bool Upload;

            public static bool AirOn;

            public static bool FollowOn;
            public static bool LaserOn;
            public static bool PowerOn;

            public static int ProductCount;

            public static int WorkPlaceCount;

            public static int WorkPlaceIndex;

            public static int[] WorkPlaceProductCount;

            public static int CycleIndex;

            public static int CycleCount;

            public static double CycleTime;

            public static string[] ProductName;

            public static double ID;
            public static int TrajIndex;
            public static int PointType;

            public static double Version;

            public static double[] CurrentJoint;
            public static double[] CurrentPoint;

            public static double[] Home;
            public static double[] Tool;

            public static string ValVersion = "";
            public static string RobotType = "";

            public static int[] PresetData = new int[5];
            public static string Custom;


        }
        /// <summary>
        /// 配置文件
        /// </summary>
        public struct XMLConfigure
        {
            public static string IpAddress = "127.0.0.1";
            // public static string Port;
            public static string ToolCode;

            public static string RegCode;

            public static bool AutoLogin = false;

            public static string RestrictCode;
            public static int SoftWareUsedDay;
            public static int CanUsedDay;
            public static bool Reged = false;
            public static bool OverTime = false;
            public static int LeftUsedDay;
            public static string[] TimeResCodes = new string[] { "01Packaging".ToUpper(), "02val3pg".ToUpper(), "03soappg".ToUpper(), "06france".ToUpper(), "09pzhong".ToUpper(),
            "12staubl".ToUpper(), "18develp".ToUpper(), "24roboti".ToUpper(), "36weiken".ToUpper() ,"00yyeprg".ToUpper()};
            public static int[] Days = new int[] { 30, 60, 90, 180, 270, 360, 540, 720, 1080, int.MaxValue };
            public static int PopeDom = 0;
            public static bool Login = false;
            public static string User = "";
            public static string Password = "";

        }




        public struct PublicData
        {
            //不同的工位对应不同的产品
            public static string[][] RecipeName;
            public static string[] TriggleModeText = new string[] { "按钮触发单工位", "按钮触发单周期", "按钮触发多周期", "无需按钮触发", "按钮触发排队", "用户自定义" };
            public static int TriggleMode = 0;
            public static int CycleCount = 1;
            public static int WorkPlaceCount = 1;
            //数据库中保存的工艺名称
            public static string[] PresetName;
            public static bool FtpLog = false;


            //2013.10.30  需要对这个进行修改
            //public static string[] ProductName=new string[4];
            //public static bool[][] TrajByPass=new bool[4][];
            //public static string[] MatchPresetName = new string[4] { "StaubliPreset", "StaubliPreset", "StaubliPreset", "StaubliPreset"};

            public static string[][] ProductName = new string[10][];
            public static bool[][][] TrajByPass = new bool[10][][];
            public static string[][] MatchPresetName = new string[10][];
            //每个工位的个数
            public static int[] ProductCount = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };



            //
            public static int ErrorCode = 0;
            public static int ErrorLine = 0;
            public static bool[,] ScreenEnable = new bool[6, 20];
            public static string[] Customs;
            public static string[] Cs8cScreen = new string[] { "", "手动回零", "手动对齐", "编辑工艺", "编辑动作", "编辑产品", "远程生产", "选项配置", "退出程序", "空闲等待", 
                "示教坐标系", "示教偏差", "外部轴", "生产界面", "示教工具", "示教安全点", "", "", "", "", "", "", "", "", "", "", "" };

            public static int[] DeleteTrajIndex;


        }








    }
}
