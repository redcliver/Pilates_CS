using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Pilates_CS
{
    class biometria
    {
        [System.Runtime.InteropServices.DllImport("SynoAPIEx.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int PSOpenDeviceEx(ref IntPtr pHandle, int nDeviceType, int iCom = 1, int iBaud = 1, int nPackageSize = 2, int iDevNum = 0);

        //[System.Runtime.InteropServices.DllImport("SynoAPIEx.dll", CallingConvention = CallingConvention.StdCall)]
        //public static extern int PSVfyPwd(IntPtr Handle,int nAddr,ref byte pPassword);
        //关闭设备
        [System.Runtime.InteropServices.DllImport("SynoAPIEx.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int PSCloseDeviceEx(IntPtr Handle);
        //验证密码
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSVfyPwd(IntPtr Handle, UInt32 nAddr, ref UInt32 pPassword);
        //获取图像数据
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSGetImage(IntPtr Handle, UInt32 nAddr);

        //上传图像数据
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSUpImage(IntPtr Handle, UInt32 nAddr, byte[] pImageData, ref int iImageLength);

        //将图像数据转为图片
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSImgData2BMP(byte[] pImgData, string pImageFile);
        //获取指纹特征值
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSGenChar(IntPtr Handle, UInt32 nAddr, int iBufferID);
        //合成模板
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSRegModule(IntPtr Handle, UInt32 nAddr);
        //保存特征值到Flash
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSStoreChar(IntPtr Handle, UInt32 nAddr, int iBufferID, int iPageID);
        //搜寻匹配指纹
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSSearch(IntPtr Handle, UInt32 nAddr, int iBufferID, int iStartPage, int iPageNum, ref int iMbAddress, ref int iscore);
        //删除当个指纹
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSDelChar(IntPtr Handle, UInt32 nAddr, int iStartPageID, int nDelPageNum);
        //获取有效指纹个数
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSTemplateNum(IntPtr Handle, UInt32 nAddr, ref int iMbNum);
        //从flash指纹库中读取一个模板到ModelBuffer
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSLoadChar(IntPtr Handle, UInt32 nAddr, int iBufferID, int iPageID);
        //将特征缓冲区中的文件上传给上位机
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSUpChar(IntPtr Handle, UInt32 nAddr, int iBufferID, byte[] pTemplet, ref int iTempletLength);

        //从上位机下载一个特征文件到特征缓冲区
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSDownChar(IntPtr Handle, UInt32 nAddr, int iBufferID, byte[] pTemplet, int iTempletLength);

        //清空指纹库
        [DllImport("SynoAPIEx.dll")]
        public static extern int PSEmpty(IntPtr Handle, UInt32 nAddr);
    }
}
