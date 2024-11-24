﻿using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using System.Collections.Generic;
using TatehamaInterlockinglConsole.Models;
using TatehamaInterlockinglConsole.Utilities;
using System.Globalization;
using TatehamaInterlockinglConsole.Handlers;

namespace TatehamaInterlockinglConsole.Factories
{
    public static class TextBlockFactory
    {
        /// <summary>
        /// TextBlockコントロール作成処理
        /// </summary>
        /// <param name="setting"></param>
        /// <returns></returns>
        public static Grid CreateTextBlockControl(UIControlSetting setting, List<UIControlSetting> allSettings, bool clickEvent = true)
        {
            // Gridの作成
            var grid = new Grid
            {
                Width = setting.Width,
                Height = setting.Height,
                Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString(setting.BackgroundColor)),
                UseLayoutRounding = true
            };

            // TextBlockの作成
            var textBlock = new TextBlock
            {
                Text = setting.Text,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center,
                FontSize = setting.FontSize,
                Foreground = new SolidColorBrush((Color)ColorConverter.ConvertFromString(setting.TextColor)),
                Padding = new Thickness(0), // 微調整
                SnapsToDevicePixels = true
            };

            // 親コントロールが設定されている場合は、相対座標に変換
            PositionUtilities.SetPosition(grid, setting, allSettings);

            // イベントが設定されている場合は、イベントをアタッチ
            if (setting.ClickEventName != string.Empty)
            {
                // クリックイベントが不要なら設定しない
                if (!clickEvent)
                {
                    grid.IsHitTestVisible = false;
                }
                new TextBlockHandler().AttachTextBlockClick(grid, setting.ClickEventName);
            }

            // GridにTextBlockを追加
            grid.Children.Add(textBlock);

            // サイズ変更イベントを登録
            grid.SizeChanged += (s, e) =>
            {
                AdjustTextWidth(textBlock, grid.ActualWidth);
            };

            return grid;
        }

        private static void AdjustTextWidth(TextBlock textBlock, double availableWidth)
        {
            // フォーマットされたテキストの幅を計算
            var formattedText = new FormattedText(
                textBlock.Text,
                CultureInfo.CurrentCulture,
                FlowDirection.LeftToRight,
                new Typeface(textBlock.FontFamily, textBlock.FontStyle, textBlock.FontWeight, textBlock.FontStretch),
                textBlock.FontSize,
                Brushes.Black,
                VisualTreeHelper.GetDpi(textBlock).PixelsPerDip);

            double textWidth = formattedText.Width;

            // テキスト幅がGrid幅を超えた場合、スケールを調整
            if (textWidth > availableWidth)
            {
                double scale = availableWidth / textWidth;
                textBlock.LayoutTransform = new ScaleTransform(scale, 1); // 横幅のみスケールダウン
            }
            else
            {
                textBlock.LayoutTransform = Transform.Identity; // 元のスケールにリセット
            }
        }
    }
}