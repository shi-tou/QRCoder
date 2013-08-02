using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace YK.Controls
{
    /// <summary>
    /// �Զ���DataGridView�ؼ�
    /// </summary>
    public class XYDataGridView : System.Windows.Forms.DataGridView
    {

        #region �ػ�Column��Row

       // int _RowHeadWidth = 41;
       Color mLinearColor1 = Color.FromArgb(248, 250, 251);
        // Color mLinearColor1 = Color.FromArgb(215, 215, 215);
        Color mLinearColor2 = Color.FromArgb(196, 207, 224);
        Color mGridColor = Color.FromArgb(120, 147, 191);
        Color mBorderColor = Color.MediumBlue;
        Color mMouseInColor = Color.Orange;
        Color mHasFocusedColor = Color.DarkCyan;

        /// <summary>
        /// �ػ�Column��Row
        /// </summary>
        /// <param name="e"></param>
        protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
               // //�����Column
               // if(e.RowIndex == -1) {
               //     drawColumnAndRow(e);
               //     e.Handled = true;
               //     //�����Rowheader
               // } else if(e.ColumnIndex < 0 && e.RowIndex>=0) {
               //     drawColumnAndRow(e);
               //     _RowHeadWidth = e.CellBounds.Width;
               //     e.Handled = true;
               //}
            StringFormat StrFormat = new StringFormat();
            Rectangle Rect = new Rectangle(e.CellBounds.X - 1, e.CellBounds.Y, e.CellBounds.Width, e.CellBounds.Height - 1);
            System.Drawing.Drawing2D.LinearGradientBrush LinearGradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(Rect, mLinearColor1, mLinearColor2, System.Drawing.Drawing2D.LinearGradientMode.Vertical);
            //try
            //{
            if (e.RowIndex == -1 || e.ColumnIndex == -1)
            {
                e.Graphics.FillRectangle(LinearGradientBrush, Rect);
                e.Graphics.DrawRectangle(new Pen(mGridColor), Rect);

                e.PaintContent(e.CellBounds);
                e.Handled = true;
            }
            //}
            //catch (Exception ex)
            //{
            //}
            //finally
            //{
            //    Rect = null;
            //    StrFormat.Dispose();
            //    if (LinearGradientBrush != null)
            //    {
            //        LinearGradientBrush.Dispose();
            //    }

            //}
        }

        /// <summary>
        /// Column��RowHeader����
        /// </summary>
        /// <param name="e"></param>
        void drawColumnAndRow(DataGridViewCellPaintingEventArgs e)
        {
            // ���Ʊ���ɫ
            using (LinearGradientBrush backbrush =
                new LinearGradientBrush(e.CellBounds,
                    ProfessionalColors.MenuItemPressedGradientBegin,
                    ProfessionalColors.MenuItemPressedGradientMiddle 
                    , LinearGradientMode.Vertical)){
           
                Rectangle border = e.CellBounds;
                border.Width -= 1;
                //������Ч��
                e.Graphics.FillRectangle(backbrush, border);
                //����Column��Row��Text��Ϣ
                e.PaintContent(e.CellBounds);
                //���Ʊ߿�
                ControlPaint.DrawBorder3D(e.Graphics, e.CellBounds, Border3DStyle.Etched);

            }
        }

        #endregion


        #region �ػ�ѡ��״̬

        #region Row�ػ�ǰ����

        /// <summary>
        /// Row�ػ�ǰ����
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            base.OnRowPrePaint(e);

            //�Ƿ���ѡ��״̬
            if ((e.State & DataGridViewElementStates.Selected) ==
                        DataGridViewElementStates.Selected)
            {
                // ����ѡ������Size
                int width = this.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);//+_RowHeadWidth;
 
                Rectangle rowBounds = new Rectangle(
                  0 , e.RowBounds.Top, width,
                    e.RowBounds.Height);

                // ����ѡ�б���ɫ
                using (LinearGradientBrush backbrush =
                    new LinearGradientBrush(rowBounds,
                        Color.SkyBlue, Color.LightSteelBlue, 90.0f)) 
                        //e.InheritedRowStyle.ForeColor, 90.0f))
                {
                    e.Graphics.FillRectangle(backbrush, rowBounds);
                    e.PaintCellsContent(rowBounds);
                    e.Handled = true;
                }

            }
        }

        #endregion

        #region Row�ػ����

        /// <summary>
        /// Row�ػ����
        /// </summary>
        /// <param name="e"></param>
        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        {
            base.OnRowPostPaint(e);
            int width = this.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);// + _RowHeadWidth;
            Rectangle rowBounds = new Rectangle(
                   0, e.RowBounds.Top, width, e.RowBounds.Height);

            if (this.CurrentCellAddress.Y == e.RowIndex){
                //����ѡ�б߿�
                e.DrawFocus(rowBounds, true);
            }
        }

        #endregion

        #region Rowˢ��

        protected override void OnColumnWidthChanged(DataGridViewColumnEventArgs e)
        {
            base.OnColumnWidthChanged(e);
            if (this.CurrentRow != null)
                this.InvalidateRow(this.CurrentRow.Index);
        }

        protected override void OnScroll(ScrollEventArgs e)
        {
            base.OnScroll(e);
            if (this.CurrentRow != null)
                this.InvalidateRow(this.CurrentRow.Index);
        }

        #endregion

        #endregion

    }
}
