using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Model;
using System.IO;

namespace View
{
    /// <summary>
    /// Основная форма
    /// </summary>
    public partial class FigureForm : Form
    {
        /// <summary>
        /// Словарь типов
        /// </summary>
        private Dictionary<int, Type> _listViewFigure = new Dictionary<int, Type>
        {
            [0] = typeof(Model.Circle),
            [1] = typeof(Model.Triangle),
            [2] = typeof(Model.Rectangle),
        };

        /// <summary>
        /// Список фигур
        /// </summary>
        private List<FigureBase> _figureList;

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FigureForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _formLoad(object sender, EventArgs e)
        {
            var figureList = new List<FigureBase>();
            _figureList = figureList;
        }

        /// <summary>
        /// Выбор фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _listViewType_SelectedIndexChange(object sender, EventArgs e)
        {
            if (listViewType.SelectedItems.Count >= 1)
            {
                int firstIndex = listViewType.SelectedIndices[0];
                dataGridView.Rows.Clear();
                dataGridView.ColumnCount = 4;
                dataGridView.Columns[0].Name = "ID";
                dataGridView.Columns[1].Name = "a";
                dataGridView.Columns[2].Name = "b";
                dataGridView.Columns[3].Name = "Area";
                var type = _listViewFigure[firstIndex];
                for (int i = 0; i < _figureList.Count; i++)
                {
                    if (type != _figureList[i].GetType()) continue;

                    string[] info = _figureList[i].GetInfo().Split(new char[] { ';' });
                    dataGridView.Rows.Add(i + 1, info[0], info[1], info[2]);
                }
            }
        }
        /// <summary>
        /// Удаляем элемент из списка
        /// </summary>
        /// <param name="sender"></param>   
        /// <param name="e"></param>
        private void ButtonRemoveFigure_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewType.SelectedItems.Count >= 1)
                {
                    int firstIndex = listViewType.SelectedIndices[0];
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        int index = dataGridView.Rows.IndexOf(row);
                        _figureList.RemoveAt(index);
                        dataGridView.Rows.Remove(row);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Список пуст");
            }
        }
        /// <summary>
        /// Поиск строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonFind_Click(object sender, EventArgs e)
        {
            FindFigureForm newForm = new FindFigureForm();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                var condition = newForm.Area;
                for (int i = 0; i < dataGridView.RowCount - 1; i++)
                {
                    dataGridView.Rows[i].Selected = false;
                    var formattedValue = dataGridView[3, i].FormattedValue.ToString();
                    switch (newForm.Condition)
                    {
                        case (ConditionType.More):
                            if (Convert.ToDouble(formattedValue) > condition)
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                            break;

                        case (ConditionType.Less):
                            if (Convert.ToDouble(formattedValue) < condition)
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                            break;

                        case (ConditionType.Equally):
                            if (Convert.ToDouble(formattedValue) == condition)
                            {
                                dataGridView.Rows[i].Selected = true;
                            }
                            break;
                    }
                }
            }
        }

        /// <summary>
		/// Добавление фигуры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonAddFigure_Click(object sender, EventArgs e)
        {
            AddFigureForm newForm = new AddFigureForm();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                FigureBase figure = newForm.Figure;
                _figureList.Add(figure);
                MessageBox.Show("Фигура добавлена!");
                if (figure is Model.Circle)
                {
                    listViewType.Items[0].Selected = true;
                }
                else if (figure is Model.Triangle)
                {
                    listViewType.Items[1].Selected = true;
                }
                else
                {
                    listViewType.Items[2].Selected = true;
                }
                listViewType.Select();
            }
        }
        /// <summary>
		/// Сохранение листа
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonSave_Click(object sender, EventArgs e)
        {
            var info = String.Empty;
            var type = String.Empty;
            for (int i = 0; i < _figureList.Count; i++)
            {
                if (_figureList[i] is Model.Circle)
                {
                    type = "Circle;";
                }
                if (_figureList[i] is Model.Triangle)
                {
                    type = "Triangle;";
                }
                if (_figureList[i] is Model.Rectangle)
                {
                    type = "Rectangle;";
                }
                info += type + _figureList[i].GetInfo() + "\n";
            }
            File.WriteAllText(Directory.GetCurrentDirectory() + "\\lb4.csv", info);
            MessageBox.Show("Файл сохранен!");
        }
        /// <summary>
		/// Загрузка данных
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ButtonDownload_Click(object sender, EventArgs e)
        {
            try
            {                
                using (StreamReader file_csv = new StreamReader(Directory.GetCurrentDirectory() + "\\lb4.csv"))
                {
                    string line;
                    FigureBase figure = null;
                    while ((line = file_csv.ReadLine()) != null)
                    {
                        string[] parts = line.Split(';');
                        if (parts[0] == "Circle")
                        {
                            figure = new Model.Circle(Convert.ToInt32(parts[1]));
                        }
                        if (parts[1] == "Triangle")
                        {
                            figure = new Model.Triangle(Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]));
                        }
                        if (parts[2] == "Rectangle")
                        {
                            figure = new Model.Rectangle(Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2])); ;
                        }
                        _figureList.Add(figure);
                    }
                    listViewType.Items[0].Selected = true;
                    MessageBox.Show("Данные загружены!");
                }
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Не корректные данные!");
            }
        }
    }
}
