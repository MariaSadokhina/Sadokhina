using Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace View
{
    /// <summary>
    /// Форма добавления фигуры
    /// </summary>
    public partial class AddFigureForm : Form
    {
        /// <summary>
        /// Словарь фигур
        /// </summary>		
        private Dictionary<FigureType, string> _figureKey =
            new Dictionary<FigureType, string>
            {
                [FigureType.Circle] = "Circle",
                [FigureType.Triangle] = "Triangle",
                [FigureType.Rectangle] = "Rectangle",
            };

        /// <summary>
        /// Получение FigureBase
        /// </summary>
        public FigureBase Figure
        {
            get; private set;
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public AddFigureForm()
        {
            InitializeComponent();
            Shown += AddFigureForm_Shown;
        }

        /// <summary>
		/// Открытие формы добавления фигуры
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void AddFigureForm_Shown(object sender, EventArgs e)
        {
            comboBoxType.Items.Add(_figureKey[FigureType.Circle]);
            comboBoxType.Items.Add(_figureKey[FigureType.Triangle]);
            comboBoxType.Items.Add(_figureKey[FigureType.Rectangle]);

            if (comboBoxType.Text == _figureKey[FigureType.Circle])
            {
                maskedTextBox1.Enabled = true;
            }
            else if (comboBoxType.Text == _figureKey[FigureType.Triangle])
            {
                maskedTextBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
            }
            else if (comboBoxType.Text == _figureKey[FigureType.Rectangle])
            {
                maskedTextBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
            }
        }

        /// <summary>
        /// Активация спец. полей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>	
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maskedTextBox1.Enabled = false;
            maskedTextBox2.Enabled = false;
            maskedTextBox3.Enabled = false;
            
            if (comboBoxType.Text == _figureKey[FigureType.Circle])
            {
                maskedTextBox1.Enabled = true;
            }
            else
            {
                maskedTextBox2.Enabled = true;
                maskedTextBox3.Enabled = true;
            }
        }

        /// <summary>
		/// Закрыть форму
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Добавление фигуры
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>		
        private void ButtonOk_Click(object sender, EventArgs e)
        {
            FigureBase figure = null;
            try
            {
                if (comboBoxType.Text == _figureKey[FigureType.Circle])
                {
                    figure = new Circle(GetCorrect(Convert.ToDouble, maskedTextBox1.Text));
                }

                if (comboBoxType.Text == _figureKey[FigureType.Triangle])
                {
                    label2.Text = "Triangle Base:";
                    label3.Text = "Height:";
                    figure = new Triangle(GetCorrect(Convert.ToDouble, maskedTextBox2.Text),
                            GetCorrect(Convert.ToDouble, maskedTextBox3.Text));
                }
                
                if (comboBoxType.Text == _figureKey[FigureType.Rectangle])
                {
                    label2.Text = "Width:";
                    label3.Text = "Length:";
                    figure = new Rectangle(GetCorrect(Convert.ToDouble, maskedTextBox2.Text),
                            GetCorrect(Convert.ToDouble, maskedTextBox3.Text));
                }

                Figure = figure;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Не корректные данные!");
            }
        }

        /// <summary>
        /// Проверка на корректность ввода
        /// </summary>
        /// <typeparam name="T">Требуемый тип</typeparam>
        /// <param name="convert">Параметр</param>
        /// <param name="text">Входная строка</param>
        /// <returns></returns>
        public static T GetCorrect<T>(Func<string, T> convert, string text)
        {
            try
            {
                return convert.Invoke(text);
            }
            catch (FormatException)
            {
                return default;
            }
        }
        /// <summary>
        /// Создать рандомную фигуру
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>		
        private void ButtonRandom_Click(object sender, EventArgs e)
        {
            maskedTextBox1.Text = maskedTextBox2.Text = maskedTextBox3.Text = " ";
            Random random = new Random();
            comboBoxType.SelectedIndex = random.Next(0, 3);
            
            if (comboBoxType.Text == _figureKey[FigureType.Circle])
            {
                maskedTextBox1.Text = Convert.ToString(random.Next(1, 50));
            }

            if (comboBoxType.Text == _figureKey[FigureType.Triangle])
            {
                label2.Text = "Triangle Base:";
                label3.Text = "Height:";
                maskedTextBox2.Text = Convert.ToString(random.Next(1, 50));
                maskedTextBox3.Text = Convert.ToString(random.Next(1, 50));
            }

            if (comboBoxType.Text == _figureKey[FigureType.Rectangle])
            {
                label2.Text = "Width:";
                label3.Text = "Length:";
                maskedTextBox2.Text = Convert.ToString(random.Next(1, 50));
                maskedTextBox3.Text = Convert.ToString(random.Next(1, 50));
            }
        }

    }
}
