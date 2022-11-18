﻿
using System.ComponentModel;

namespace Hot_tours.Models
{
    public enum Direction
    {
        /// <summary>
        /// Крым
        /// </summary>
        [Description("Крым")]
        Crimea,
        /// <summary>
        /// Египет
        /// </summary>
        [Description("Египет")]
        Egypt,
        /// <summary>
        /// Турция
        /// </summary>
        Turkey,
        /// <summary>
        /// ОАЭ
        /// </summary>
        UAE,
        /// <summary>
        /// Тунис
        /// </summary>
        Tunisia
    }
}
