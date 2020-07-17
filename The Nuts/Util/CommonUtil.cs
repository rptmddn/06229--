
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TheNutsVO;

namespace The_Nuts
{
    public class CommonUtil
    {
        #region comboBox 바인딩 관련
        public static void ComboBinding(ComboBox combo, List<CommonVO> list)
        {            
            combo.ValueMember = "Code";
            combo.DisplayMember = "CodeNm";
            combo.DataSource = list;
        }

        public static void ComboBinding(ComboBox combo, List<CommonVO> list, string blankText)
        {
            if (list == null)
                list = new List<CommonVO>();

            list.Insert(0, new CommonVO(blankText));
            combo.DataSource = list;
            combo.DisplayMember = "CodeNm";
            combo.ValueMember = "Code";
        }

        public static void ComboBinding<T>(ComboBox combo, List<T> list, string Code, string CodeNm)
        {
            if (list == null)
                list = new List<T>();
            
            combo.DataSource = list;
            combo.DisplayMember = CodeNm;
            combo.ValueMember = Code;
        }

        public static void ComboBinding<T>(ComboBox combo, List<T> list, string Code, string CodeNm, string blankText) where T : class, new()
        {
            if (list == null)
                list = new List<T>();

            T blankItem = new T();
            blankItem.GetType().GetProperty(CodeNm).SetValue(blankItem, blankText);
            list.Insert(0, blankItem);

            combo.DataSource = list;
            combo.DisplayMember = CodeNm;
            combo.ValueMember = Code;
        }

        public static List<CommonVO> Copy(List<CommonVO> org)
        {
            List<CommonVO> cloneList = new List<CommonVO>();
            foreach (var item in org)
            {
                cloneList.Add(new CommonVO
                {
                        Code = item.Code,
                        CodeNm = item.CodeNm  });
            }
            return cloneList;
        }
        #endregion

        public static void AddNewColumnToDataGridView(DataGridView dgv, string headerText, string dataPropertyName, bool visibility, int colWidth = 100, DataGridViewContentAlignment textAlign = DataGridViewContentAlignment.MiddleLeft)
        {
            DataGridViewTextBoxColumn gridCol = new DataGridViewTextBoxColumn();
            gridCol.HeaderText = headerText;
            gridCol.DataPropertyName = dataPropertyName;
            gridCol.Width = colWidth;
            gridCol.Visible = visibility;
            gridCol.ValueType = typeof(string);
            gridCol.ReadOnly = true;
            gridCol.DefaultCellStyle.Alignment = textAlign;
            dgv.Columns.Add(gridCol);
        }

        public static void InitSettingGridView(DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            dgv.AllowUserToAddRows = false;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
    }
}
