using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TD_LTE上行干扰分析系统
{
    /// <summary>
    ///设置窗体的控件大小自适应窗体的大小
    ///author：yang
    /// </summary>
     class AutomaticSize  
    {
        //设定程序中可能要用到的用以存储初始数据的动态数组及相关私有变量


        //用以存储窗体中所有的控件名称
        private ArrayList InitialCrl = new ArrayList();

        //用以存储窗体中所有的控件原始位置
        private ArrayList CrlLocationX = new ArrayList();

        //用以存储窗体中所有的控件原始位置

        private ArrayList CrlLocationY = new ArrayList();

        //用以存储窗体中所有的控件原始的水平尺寸

        private ArrayList CrlSizeWidth = new ArrayList();

        //用以存储窗体中所有的控件原始的垂直尺寸
        private ArrayList CrlSizeHeight = new ArrayList();

        private int FormSizeWidth;//用以存储窗体原始的水平尺寸
        private int FormSizeHeight;//用以存储窗体原始的垂直尺寸

        private double FormSizeChangedX;//用以存储相关父窗体/容器的水平变化量
        private double FormSizeChangedY;//用以存储相关父窗体/容器的垂直变化量

        //为防止递归遍历控件时产生混乱，专门设定一个全局计数器
        private int Wcounter = 0;

        public void GetAllCrlLocation(Control CrlContainer)
        {
            //获得并存储窗体中各控件的初始位置
            foreach (Control iCrl in CrlContainer.Controls)
            {

                if (iCrl.Controls.Count > 0)
                    GetAllCrlLocation(iCrl);
                InitialCrl.Add(iCrl);
                CrlLocationX.Add(iCrl.Location.X);
                CrlLocationY.Add(iCrl.Location.Y);
            }
        }
        public void GetAllCrlSize(Control CrlContainer)
        {
            //获得并存储窗体中各控件的初始尺寸
            foreach (Control iCrl in CrlContainer.Controls)
            {
                if (iCrl.Controls.Count > 0)
                    GetAllCrlSize(iCrl);
                CrlSizeWidth.Add(iCrl.Width);
                CrlSizeHeight.Add(iCrl.Height);
            }
        }

        public void GetInitialFormSize(Form f)//获得并存储窗体的初始尺寸
        {
            FormSizeWidth = f.Size.Width;
            FormSizeHeight = f.Size.Height;
        }
        public void sizechange(Form f)
        {
            Wcounter = 0;
            int counter = 0;
            if (f.Size.Width < FormSizeWidth || f.Size.Height < FormSizeHeight)
            {
                //如果窗体的大小在改变过程中小于窗体尺寸的初始值，则窗体中的各个控件自
                //动重置为初始尺寸，且窗体自动添加滚动条
                foreach (Control iniCrl in InitialCrl)
                {
                    iniCrl.Width = (int)CrlSizeWidth[counter];
                    iniCrl.Height = (int)CrlSizeHeight[counter];
                    Point point = new Point();
                    point.X = (int)CrlLocationX[counter];
                    point.Y = (int)CrlLocationY[counter];
                    iniCrl.Bounds = new Rectangle(point, iniCrl.Size);
                    counter++;
                }
                f.AutoScroll = true;
            }
            else
            //否则，重新设定窗体中所有控件的大小（窗体内所有控件的大小随窗体大小的变化而变化）
            {
                f.AutoScroll = false;
                ResetAllCrlState(f,f);
            }
        
        }

        public void ResetAllCrlState(Control CrlContainer,Form f)
        {
            //重新设定窗体中各控件的状态（在与原状态的对比中计算而来）
            FormSizeChangedX = (double)f.Size.Width / (double)FormSizeWidth;
            FormSizeChangedY = (double)f.Size.Height / (double)FormSizeHeight;

            foreach (Control kCrl in CrlContainer.Controls)
            {

                //string name = kCrl.Name.ToString();
                //MessageBox.Show(name);
                // MessageBox.Show(Wcounter.ToString());

                if (kCrl.Controls.Count > 0)
                {
                    ResetAllCrlState(kCrl,f);
                }
                if (Wcounter >= CrlLocationX.Count)
                    return;
                Point point = new Point();
                point.X = (int)((int)CrlLocationX[Wcounter] * FormSizeChangedX);
                point.Y = (int)((int)CrlLocationY[Wcounter] * FormSizeChangedY);
                kCrl.Width = (int)((int)CrlSizeWidth[Wcounter] * FormSizeChangedX);
                kCrl.Height = (int)((int)CrlSizeHeight[Wcounter] * FormSizeChangedY);
                kCrl.Bounds = new Rectangle(point, kCrl.Size);
                Wcounter++;
                // MessageBox.Show(Wcounter.ToString());
            }
        }
    }  
}  

