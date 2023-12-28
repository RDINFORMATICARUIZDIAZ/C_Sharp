﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MICRUD.Logica
{
    public class Bases
    {
        private static readonly object SontStyle;

        public static void DiseñoDtv(ref DataGridView Listado)
        {
            Listado.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.AllCells;
            Listado.BackgroundColor = Color.FromArgb(29,29,29) ;
            Listado.EnableHeadersVisualStyles = false;
            Listado.BorderStyle = BorderStyle.None ;
            Listado.CellBorderStyle= DataGridViewCellBorderStyle.None ;
            Listado.ColumnHeadersBorderStyle= DataGridViewHeaderBorderStyle.None ;
            Listado.RowHeadersVisible= false ;

            DataGridViewCellStyle cabecera = new DataGridViewCellStyle();
            cabecera.BackColor = Color.FromArgb(29, 29, 29); 
            cabecera.ForeColor = Color.White; 
            cabecera.Font = new Font("Segoe UI", 10,FontStyle.Bold);
            Listado.ColumnHeadersDefaultCellStyle = cabecera;

        }
        public static void DiseñoDtvEliminar(ref DataGridView Listado) 
        {
            foreach (DataGridViewRow row in Listado.Rows)
            {
                string Estado;
                    Estado = row.Cells["Estado"].Value.ToString();
                if (Estado == "ELIMINADO")
                {
                    row.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Strikeout | FontStyle.Bold);
                    row.DefaultCellStyle.ForeColor = Color.FromArgb(255,128,128);
                }
            }

        }
        public static object Decimales(TextBox CajaTexto,KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = System.Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator[0];
            }

            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.' && (~CajaTexto.Text.IndexOf("."))!= 0)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (e.KeyChar == ',')
            {
                e.Handled = false;
            }
            else 
            { 
                e.Handled = true;
            }
            return null;

        }

        public enum DateInterval
        {
            Day,
            DayOfYear,
            Hour,
            Minute,
            Month,
            Quarter,
            Second,
            Weekday,
            WeekOfYear,
            Year
        }
        public static long DateDiff(DateInterval IntervalType,DateTime dateOne,DateTime datetwo)
        {
            switch (IntervalType)
            {
                case DateInterval.Day:
                case DateInterval.DayOfYear:
                    TimeSpan spanForDays = datetwo - dateOne;
                    return (long)spanForDays.TotalDays;
                case DateInterval.Hour:
                    TimeSpan spanForHours = datetwo - dateOne;
                    return (long)spanForHours.TotalHours;
                case DateInterval.Minute:
                    TimeSpan spanForMinutes= datetwo - dateOne;
                    return (long)spanForMinutes.TotalMinutes;
                case DateInterval.Month:
                    return ((datetwo.Year - dateOne.Year) * 12) + (datetwo.Month - dateOne.Month);
                case DateInterval.Quarter:
                    long dateOneQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    long dateTwoQuarter = (long)Math.Ceiling(dateOne.Month / 3.0);
                    return (4 * (datetwo.Year - dateOne.Year)) * dateTwoQuarter - dateOneQuarter;
                case DateInterval.Second:
                    TimeSpan spanForSeconds = datetwo - dateOne;
                    return (long)spanForSeconds.TotalSeconds;
                case DateInterval.Weekday:
                    TimeSpan spanForWeekYear = datetwo - dateOne;
                    return (long)(spanForWeekYear.TotalDays / 7.0);
                case DateInterval.WeekOfYear:
                    DateTime dateOneModified = dateOne;
                    DateTime dateTwoMOdified = datetwo;
                    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateTwoMOdified=dateTwoMOdified.AddDays(-1);

                    }
                    while (dateOneModified.DayOfWeek != DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek)
                    {
                        dateOneModified=dateOneModified.AddDays(-1);

                    }
                    TimeSpan spanForWeekOfYear = dateOneModified - dateOneModified;
                    return (long)(spanForWeekOfYear.TotalDays / 7.0);
                case DateInterval.Year:
                    return datetwo.Year - dateOne.Year;
                default:
                    return 0;


            }
        }
    }
}
