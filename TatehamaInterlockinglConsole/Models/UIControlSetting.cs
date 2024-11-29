﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace TatehamaInterlockingConsole.Models
{
    /// <summary>
    /// UI設定用データクラス
    /// </summary>
    public class UIControlSetting
    {
        /// <summary>
        /// 駅名称
        /// </summary>
        public string StationName { get; set; }
        /// <summary>
        /// コントロール種類
        /// </summary>
        public string ControlType { get; set; }
        /// <summary>
        /// コントロール名称
        /// </summary>
        public string UniqueName { get; set; }
        /// <summary>
        /// サーバー名称
        /// </summary>
        public string ServerName { get; set; }
        /// <summary>
        /// 親コントロール名称
        /// </summary>
        public string ParentName { get; set; }
        /// <summary>
        /// 制御条件に含む転てつ器名称
        /// </summary>
        public string PointName { get; set; }
        /// <summary>
        /// 制御条件に含む転てつ器状態
        /// (定位=True, 反位=False)
        /// </summary>
        public bool PointValue { get; set; }
        /// <summary>
        /// X座標
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Y座標
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// 親コントロールからの相対X座標
        /// </summary>
        public double RelativeX { get; set; }
        /// <summary>
        /// 親コントロールからの相対Y座標
        /// </summary>
        public double RelativeY { get; set; }
        /// <summary>
        /// 幅
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// 高さ
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// 回転角度
        /// </summary>
        public double Angle { get; set; }
        /// <summary>
        /// 回転原点X軸（0～1）
        /// </summary>
        public double AngleOriginX { get; set; }
        /// <summary>
        /// 回転原点Y軸（0～1）
        /// </summary>
        public double AngleOriginY { get; set; }
        /// <summary>
        /// 文字
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 文字フォントサイズ
        /// </summary>
        public double FontSize { get; set; }
        /// <summary>
        /// 文字背景色
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// 文字色
        /// </summary>
        public string TextColor { get; set; }
        /// <summary>
        /// クリックイベント名称
        /// </summary>
        public string ClickEventName { get; set; }
        /// <summary>
        /// ImagePathのIndexパターン
        /// </summary>
        public List<string> ImagePattern { get; set; }
        /// <summary>
        /// 文字列に置き換えたImagePathのIndexパターン
        /// </summary>
        public string ImagePatternSymbol { get; set; }
        /// <summary>
        /// ImagePathのIndex
        /// </summary>
        public int ImageIndex { get; set; }
        /// <summary>
        /// Base画像のPath
        /// </summary>
        public string BaseImagePath { get; set; }
        /// <summary>
        /// 画像のPath
        /// </summary>
        public Dictionary<int, string> ImagePaths { get; set; }
        /// <summary>
        /// 備考欄
        /// </summary>
        public string Remark { get; set; }
    }
}