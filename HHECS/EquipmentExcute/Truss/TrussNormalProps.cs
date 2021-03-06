﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HHECS.EquipmentExcute.Truss
{
    /// <summary>
    /// 桁车属性列表 对应版本8.4
    /// </summary>
    public enum TrussNormalProps
    {
        #region 通用属性
        /// <summary>
        /// 桁车编号
        /// </summary>
        Number,

        /// <summary>
        /// 操作模式
        /// </summary>
        OperationModel,

        /// <summary>
        /// 心跳
        /// </summary>
        HeartBeat,

        /// <summary>
        /// 水平测距
        /// </summary>
        HorizontalDistance,

        /// <summary>
        /// 起升测距
        /// </summary>
        VerticalDistance,

        /// <summary>
        /// 货叉1伸叉测距
        /// </summary>
        Fork1Distance,

        /// <summary>
        /// 货叉2伸叉测距
        /// </summary>
        Fork2Distance,

        /// <summary>
        /// 当前列
        /// </summary>
        CurrentDistance,

        /// <summary>
        /// 当前层
        /// </summary>
        CurrentLayer,

        /// <summary>
        /// 当前抓手位置，也就是当前站台
        /// </summary>
        CurrentTongs,

        /// <summary>
        /// 当前出/入口
        /// </summary>
        CurrentStation,

        /// <summary>
        /// 桁车总故障,0-无故障； 1-桁车总故障
        /// 空出、重入、取货错等任务性质的错误不会报故障
        /// </summary>
        TotalError,
        /// <summary>
        /// 兼容模式 0-正常模式；1-兼容模式（兼容另一台桁车任务）	
        /// </summary>
        CompatibleMode,
        #endregion

        #region 货叉1

        /// <summary>
        /// 货叉 1 任务状态： 1-待机； 2-任务执行中； 3-任务完成； 4-任务中断（出 错，空出，满入）； 5-下发任务错误
        /// </summary>
        Fork1TaskExcuteStatus,

        /// <summary>
        /// 货叉 任务标志：0-无任务，1-机械手取货，2-机械手放货，3-机械手行走， 5重新分配入库地址, 6删除任务,10任务完成
        /// </summary>
        Fork1TaskType,

        /// <summary>
        /// 货叉1总故障
        /// 空出、重入、取货错等任务性质的错误不会报故障
        /// </summary>
        Fork1TotalError,

        /// <summary>
        /// 0-无错误； 1-货叉 1 任务错误
        /// </summary>
        Fork1TaskError,

        /// <summary>
        /// 货叉1，0-无货； 1-货叉 1 有货
        /// </summary>
        Fork1HasPallet,

        /// <summary>
        /// 货叉1，0-在低位； 1-货叉 1 在高位
        /// </summary>
        Fork1Center,

        /// <summary>
        /// 0-无满入； 1-货叉 1 满入
        /// </summary>
        Fork1DoubleIn,

        /// <summary>
        /// 0-无空出； 1-货叉 1 空出
        /// </summary>
        Fork1EmptyOut,

        /// <summary>
        /// 0-无故障； 1-取货任务错误（双伸位）
        /// </summary>
        Fork1GetError,

        /// <summary>
        /// 货叉1 任务号
        /// </summary>
        Fork1TaskNo,

        #endregion

        #region 货叉2

        /// <summary>
        /// 货叉 2 任务状态： 1-待机； 2-任务执行中； 3-任务完成； 4-任务中断（出 错，空出，满入）； 5-下发任务错误
        /// </summary>
        Fork2TaskExcuteStatus,

        /// <summary>
        /// 货叉 2 任务类型： 0-无任务， 1-库内取货， 2-库内放货， 3-库外入库， 4 库外出库
        /// </summary>
        Fork2TaskType,

        /// <summary>
        /// 货叉2总故障
        /// 空出、重入、取货错等任务性质的错误不会报故障
        /// </summary>
        Fork2TotalError,

        /// <summary>
        /// 0-无错误； 1-货叉 1 任务错误
        /// </summary>
        Fork2TaskError,

        /// <summary>
        /// 货叉2，0-无货； 1-货叉 1 有货
        /// </summary>
        Fork2HasPallet,

        /// <summary>
        /// 货叉2，0-不在中心； 1-货叉 1 在中心
        /// </summary>
        Fork2Center,

        /// <summary>
        /// 0-无满入； 1-货叉 1 满入
        /// </summary>
        Fork2DoubleIn,

        /// <summary>
        /// 0-无空出； 1-货叉 1 空出
        /// </summary>
        Fork2EmptyOut,

        /// <summary>
        /// 0-无故障； 1-取货任务错误（双伸位）
        /// </summary>
        Fork2GetError,

        /// <summary>
        /// 货叉2 任务号
        /// </summary>
        Fork2TaskNo,

        #endregion

        #region 转轨相关

        /// <summary>
        /// 拓展模式  用于转轨桁车 0：正常  1：转轨模式
        /// </summary>
        ExpendMode,

        /// <summary>
        /// 拓展模式  最小距离
        /// </summary>
        ManageSmallDistance,

        /// <summary>
        /// 拓展模式  最大距离
        /// </summary>
        ManageBigDistance, 

        #endregion



        #region 行走报警

        /// <summary>
        /// 是否行走变频器通讯故障
        /// </summary>
        RunningUuivertorConnectAlarm,

        /// <summary>
        /// 是否行走变频器报警
        /// </summary>
        RunningUuivertorAlarm,

        /// <summary>
        /// 行走轴运行超时
        /// </summary>
        RunningUuivertorTimeOut,

        /// <summary>
        /// 0-无故障； 1-行走轴测距设备故障
        /// </summary>
        RunningUuivertorRangingError,

        /// <summary>
        /// 0-无故障； 1-行走轴断路器故障
        /// </summary>
        RunningUuivertorBreakerError,


        /// <summary>
        /// 0-无故障； 1-行走轴超出前限位
        /// </summary>
        RunningUuivertorFrontOut,

        /// <summary>
        /// 0-无故障； 1-行走轴超出后限位
        /// </summary>
        RunningUuivertorBehindOut,

        /// <summary>
        /// 0-无故障； 1-行走轴未准备就绪
        /// </summary>
        RunningUuivertorReady,

        /// <summary>
        /// 0-无故障； 1-外部故障
        /// </summary>
        RunningUuivertorOutError,

        /// <summary>
        /// 行走轴故障代码（非监控）
        /// </summary>
        RunningUuivertorErrorCode,

        #endregion

        #region 升降报警

        /// <summary>
        /// 是否升降变频器通讯报警
        /// </summary>
        RaisingUuivertorConnectAlarm,

        /// <summary>
        /// 是否升降变频器报警
        /// </summary>
        RaisingUuivertorAlarm,

        /// <summary>
        /// 升降轴运行超时
        /// </summary>
        RaisingUuivertorTimeOut,

        /// <summary>
        /// 0-无故障； 1-升降轴测距设备故障
        /// </summary>
        RaisingUuivertorRangingError,

        /// <summary>
        /// 0-无故障； 1-升降轴断路器故障
        /// </summary>
        RaisingUuivertorBreakerError,

        /// <summary>
        /// 0-无故障； 1-升降轴超出上限位
        /// </summary>
        RaisingUuivertorUpperOut,

        /// <summary>
        /// 0-无故障； 1-升降轴超出下限位
        /// </summary>
        RaisingUuivertorUnderOut,

        ///<summary>
        ///0-无故障； 1-升降轴未准备就绪
        /// </summary>
        RaisingUuivertorNotReady,

        /// <summary>
        /// 0-无故障； 1-升降外部故障
        /// </summary>
        RaisingUuivertorOutError,

        /// <summary>
        /// 0-无故障； 1-升降松绳故障
        /// </summary>
        RaisingUuivertorRope,

        /// <summary>
        /// 升降故障代码（非监控）
        /// </summary>
        RaisingUuivertorErrorCode,

        #endregion

        #region 货叉1报警


        /// <summary>
        /// 0-无超时； 1-货叉左伸出超时
        /// </summary>
        Fork1LeftForkOutTimeout,

        /// <summary>
        /// 0-无超时； 1-货叉右伸出超时
        /// </summary>
        Fork1RightForkOutTimeout,

        /// <summary>
        /// 0-无超时； 1-货叉左缩回超时
        /// </summary>
        Fork1LeftForkInTimeout,

        /// <summary>
        /// 0-无超时； 1-货叉右缩回超时
        /// </summary>
        Fork1RightForkInTimeout,

        /// <summary>
        /// 货叉1_是否左侧外形超限
        /// </summary>
        Fork1PalletLeftOut,

        /// <summary>
        /// 货叉1_是否右侧外形超限
        /// </summary>
        Fork1PalletRightOut,

        /// <summary>
        /// 货叉1_是否货物前超
        /// </summary>
        Fork1PalletFrontOut,

        /// <summary>
        /// 货叉1_是否货物后超
        /// </summary>
        Fork1PalletBehindOut,

        /// <summary>
        /// 货叉1_超高1
        /// </summary>
        Fork1OverHeight1,

        /// <summary>
        /// 货叉1_超高2
        /// </summary>
        Fork1OverHeight2,

        /// <summary>
        /// 货叉1_超高3
        /// </summary>
        Fork1OverHeight3,

        /// <summary>
        /// 货叉1_货物超高
        /// </summary>
        Fork1OverHeight,

        /// <summary>
        /// 货叉1_是否左侧极限报警
        /// </summary>
        Fork1LeftLimitAlarm,

        /// <summary>
        /// 货叉1_是否右侧极限报警
        /// </summary>
        Fork1RightLimitAlarm,

        /// <summary>
        /// 货叉1_货叉变频器故障
        /// </summary>
        Fork1ForkUuivertor,

        /// <summary>
        /// 货叉1_货叉断路器/接触器故障
        /// </summary>
        Fork1ForkBreakerOrCocontactor,

        /// <summary>
        /// 货叉1_是否货物检测传感器故障
        /// </summary>
        Fork1GoodsInspectionSensor,

        /// <summary>
        /// 货叉1_是否货叉定位传感器故障
        /// </summary>
        Fork1ForkAlignmentSensor,

        /// <summary>
        /// 货叉1_是否运行方向错误
        /// </summary>
        Fork1DirectionError,

        /// <summary>
        /// 0-无故障； 1-X 轴、 Y 轴、 货叉执行动作错误
        /// </summary>
        Fork1XYForkExcute,

        /// <summary>
        /// 货叉1_是否设定值错误
        /// </summary>
        Fork1SetValueError,

        /// <summary>
        /// 0-无故障； 1-货叉伸出超过设定值
        /// </summary>
        Fork1ForkOutLimit,

        /// <summary>
        /// 0-无故障； 1-货叉缩回超过设定值
        /// </summary>
        Fork1ForkInLimit,

        /// <summary>
        /// 货叉1故障代码（非监控）
        /// </summary>
        Fork1ErrorCode,

        #endregion

        #region 货叉2报警


        /// <summary>
        /// 0-无超时； 1-货叉左伸出超时
        /// </summary>
        Fork2LeftForkOutTimeout,

        /// <summary>
        /// 0-无超时； 1-货叉右伸出超时
        /// </summary>
        Fork2RightForkOutTimeout,

        /// <summary>
        /// 0-无超时； 1-货叉左缩回超时
        /// </summary>
        Fork2LeftForkInTimeout,

        /// <summary>
        /// 0-无超时； 1-货叉右缩回超时
        /// </summary>
        Fork2RightForkInTimeout,

        /// <summary>
        /// 货叉2_是否左侧外形超限
        /// </summary>
        Fork2PalletLeftOut,

        /// <summary>
        /// 货叉2_是否右侧外形超限
        /// </summary>
        Fork2PalletRightOut,

        /// <summary>
        /// 货叉2_是否货物前超
        /// </summary>
        Fork2PalletFrontOut,

        /// <summary>
        /// 货叉2_是否货物后超
        /// </summary>
        Fork2PalletBehindOut,

        /// <summary>
        /// 货叉2_超高1
        /// </summary>
        Fork2OverHeight1,

        /// <summary>
        /// 货叉2_超高2
        /// </summary>
        Fork2OverHeight2,

        /// <summary>
        /// 货叉2_超高3
        /// </summary>
        Fork2OverHeight3,

        /// <summary>
        /// 货叉2_货物超高
        /// </summary>
        Fork2OverHeight,

        /// <summary>
        /// 货叉2_是否左侧极限报警
        /// </summary>
        Fork2LeftLimitAlarm,

        /// <summary>
        /// 货叉2_是否右侧极限报警
        /// </summary>
        Fork2RightLimitAlarm,

        /// <summary>
        /// 货叉2_货叉变频器故障
        /// </summary>
        Fork2ForkUuivertor,

        /// <summary>
        /// 货叉2_货叉断路器/接触器故障
        /// </summary>
        Fork2ForkBreakerOrCocontactor,

        /// <summary>
        /// 货叉2_是否货物检测传感器故障
        /// </summary>
        Fork2GoodsInspectionSensor,

        /// <summary>
        /// 货叉2_是否货叉定位传感器故障
        /// </summary>
        Fork2ForkAlignmentSensor,

        /// <summary>
        /// 货叉2_是否运行方向错误
        /// </summary>
        Fork2DirectionError,

        /// <summary>
        /// 0-无故障； 1-X 轴、 Y 轴、 货叉执行动作错误
        /// </summary>
        Fork2XYForkExcute,

        /// <summary>
        /// 货叉2_是否设定值错误
        /// </summary>
        Fork2SetValueError,

        /// <summary>
        /// 0-无故障； 1-货叉伸出超过设定值
        /// </summary>
        Fork2ForkOutLimit,

        /// <summary>
        /// 0-无故障； 1-货叉缩回超过设定值
        /// </summary>
        Fork2ForkInLimit,

        /// <summary>
        /// 货叉2故障代码（非监控）
        /// </summary>
        Fork2ErrorCode,

        #endregion

        #region 安全报警

        /// <summary>
        /// 主接触器断开
        /// </summary>
        MainCocontactorInterrupt,

        /// <summary>
        /// 0-无急停； 1-操作盒急停被按下
        /// </summary>
        OperationBoxE_StopPress,

        /// <summary>
        /// 0-无急停； 1-车载控制柜急停被按下
        /// </summary>
        CarE_StopPress,

        /// <summary>
        /// 0-无故障； 1-红外通信故障
        /// </summary>
        InfraredError,

        /// <summary>
        /// 0-无故障； 1-前安全门被打开
        /// </summary>
        FrontSafetyDoorBreakdown,

        /// <summary>
        /// 0-无故障； 1-后安全门被打开
        /// </summary>
        BehindSafetyDoorBreakdown,


        #endregion

        #region Fork1TaskError

        /// <summary>
        /// 货叉1 0-无错误； 1-WCS 下发取货任务时，货叉有货
        /// </summary>
        Fork1PickWhenPalletOnError,

        /// <summary>
        /// 货叉1 0-无错误； 1-WCS 下发放货任务时，货叉无货
        /// </summary>
        Fork1PutWhenPalletEmptyError,

        /// <summary>
        /// 货叉1 0-无错误； 1-WCS 下发任务时，任务排号错误
        /// </summary>
        Fork1RowError,

        /// <summary>
        /// 货叉1 0-无错误； 1-WCS 下发任务时，任务层数错误
        /// </summary>
        Fork1LayerError,

        /// <summary>
        /// 货叉1 0-无错误； 1-WCS 下发任务时，任务列数错误
        /// </summary>
        Fork1ColumnError,

        /// <summary>
        /// 货叉1 0-无错误； 1-WCS 下发任务时，任务出入口错误
        /// </summary>
        Fork1StaionError,

        /// <summary>
        /// 货叉1 0-无错误； 1-库内放货，货物高度与货架高度不匹配
        /// </summary>
        Fork1HeightError,

        #endregion

        #region Fork2TaskError

        /// <summary>
        /// 货叉2 0-无错误； 1-WCS 下发取货任务时，货叉有货
        /// </summary>
        Fork2PickWhenPalletOnError,

        /// <summary>
        /// 货叉2 0-无错误； 1-WCS 下发放货任务时，货叉无货
        /// </summary>
        Fork2PutWhenPalletEmptyError,

        /// <summary>
        /// 货叉2 0-无错误； 1-WCS 下发任务时，任务排号错误
        /// </summary>
        Fork2RowError,

        /// <summary>
        /// 货叉2 0-无错误； 1-WCS 下发任务时，任务层数错误
        /// </summary>
        Fork2LayerError,

        /// <summary>
        /// 货叉2 0-无错误； 1-WCS 下发任务时，任务列数错误
        /// </summary>
        Fork2ColumnError,

        /// <summary>
        /// 货叉2 0-无错误； 1-WCS 下发任务时，任务出入口错误
        /// </summary>
        Fork2StatioinError,

        /// <summary>
        /// 货叉2 0-无错误； 1-库内放货，货物高度与货架高度不匹配
        /// </summary>
        Fork2HeightError,

        #endregion

        #region WCS

        /// <summary>
        /// 货叉动作类型
        /// 0无，1=1号货叉，2=2号货叉，3=同时动作
        /// </summary>
        WCSForkAction,

        /// <summary>
        /// 任务标志：
        /// 0-无任务，1-机械手取货，2-机械手放货，
        /// 3-机械手行走， 5重新分配放货地址,
        /// 6删除任务,10任务完成
        /// </summary>
        WCSTaskFlag,

        /// <summary>
        /// 心跳
        /// </summary>
        WCSHeartBeat,

        /// <summary>
        /// 产品ID
        /// </summary>
        WCSProductId,

        /// <summary>
        /// 目的站台ID
        /// </summary>
        WCSStationId,

        /// <summary>
        /// 列
        /// </summary>
        WCSLine,

        /// <summary>
        /// 层
        /// </summary>
        WCSLayer,

        /// <summary>
        /// 任务号
        /// </summary>
        WCSTaskNo,


        #endregion



    }
}
