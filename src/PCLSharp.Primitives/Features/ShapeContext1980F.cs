﻿using System.Runtime.InteropServices;

namespace PCLSharp.Primitives.Features
{
    /// <summary>
    /// 3DSC描述子
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public readonly struct ShapeContext1980F
    {
        /// <summary>
        /// 创建3DSC描述子构造器
        /// </summary>
        /// <param name="rf">RF</param>
        /// <param name="features">特征向量</param>
        public ShapeContext1980F(float[] rf, float[] features)
            : this()
        {
            this.RF = rf;
            this.Features = features;
        }

        /// <summary>
        /// RF
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 9)]
        public readonly float[] RF;

        /// <summary>
        /// 特征向量
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1980)]
        public readonly float[] Features;
    }
}
