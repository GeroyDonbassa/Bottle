using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Bottle.UI
{
    /// <summary>
    /// Основная форма.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Соединитель с КОМПАС-3D.
        /// </summary>
        private readonly KompasConnector _kompasConnector;

        /// <summary>
        /// Словарь, хранящий старые значения.
        /// </summary>
        private readonly Dictionary<TextBox, string> _oldValues;

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="kompasConnector">Соединитель с КОМПАС-3D.</param>
        public MainForm(KompasConnector kompasConnector)
        {
            _kompasConnector = kompasConnector;
            _oldValues = new Dictionary<TextBox, string>();
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик ошибок кнопки "Очистить".
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            LengthFullBottleTextBox.Text = "";
            BaseLengthTextBox.Text = "";
            BottleneckLengthTextBox.Text = "";
            BaseDiameterTextBox.Text = "";
            BottleneckDiameterTextBox.Text = "";
        }

        /// <summary>
        /// Обработчик ошибок кнопки "Запустить".
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы.</param>
        private void StartKompasButton_Click(object sender, EventArgs e)
        {
            try
            {
                _kompasConnector.Start();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Открытие КОМПАС-3D", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Обработчик ошибок кнопки "Закрыть".
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы.</param>
        private void CloseKompasButton_Click(object sender, EventArgs e)
        {
            _kompasConnector.Close();
        }

        /// <summary>
        /// Обработчик ошибок кнопки "Построить".
        /// </summary>
        /// <param name="sender">Отправитель</param>
        /// <param name="e">Аргументы.</param>
        private void BuildButton_Click(object sender, EventArgs e)
        {
            try
            {
                var baseDiameter = double.Parse(BaseDiameterTextBox.Text);
                var baseLength = double.Parse(BaseLengthTextBox.Text);
                var bottleneckDiameter = double.Parse(BottleneckDiameterTextBox.Text);
                var bottleneckLength = double.Parse(BottleneckLengthTextBox.Text);
                var lengthFullBottle = double.Parse(LengthFullBottleTextBox.Text);

                var bottleParameters = new BottleParameters(baseDiameter, baseLength, bottleneckDiameter,
                    bottleneckLength, lengthFullBottle);

                var document3D = _kompasConnector.CreateDocument3D();

                var bottleBuilder = new BottleBuilder(document3D, bottleParameters);

                bottleBuilder.BuildBottle();
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show(ex.Message, "Построение бутылки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Построение бутылки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Событие изменения текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            var textBox = (TextBox)sender;

            if (!CheckDoubleString(textBox.Text))
                textBox.Text = _oldValues[textBox];

            _oldValues[textBox] = textBox.Text;
        }

        /// <summary>
        /// Проверяет строку на соответствие формату double.
        /// </summary>
        /// <param name="doubleString">Строка.</param>
        /// <returns>Указывает, соответствует ли строка формату double.</returns>
        private static bool CheckDoubleString(string doubleString)
        {
            if (double.TryParse(doubleString, out _))
                return true;

            if (doubleString.LastOrDefault().ToString() ==
                CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator &&
                doubleString.Count(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator.First().Equals) <=
                1)
                return true;

            if (string.IsNullOrWhiteSpace(doubleString))
                return true;

            return false;
        }

        /// <summary>
        /// Получает число типа double из строки соответствующего формата.
        /// </summary>
        /// <param name="doubleString">Строка с числом в формате double.</param>
        /// <returns>Число.</returns>
        private static double GetDoubleFromString(string doubleString)
        {
            if (string.IsNullOrWhiteSpace(doubleString))
                doubleString = "0";

            if (doubleString.LastOrDefault().ToString() ==
                CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator)
                doubleString = doubleString.Substring(0, doubleString.Length);

            return double.Parse(doubleString);
        }
    }
}