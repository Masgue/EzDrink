using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    class PresentationModel
    {
        private DrinkModel _drinkModel;
        private bool _normalSugarButtonEnabled;
        private bool _halfSugarButtonEnabled;
        private bool _lessSugarButtonEnabled;
        private bool _noSugarButtonEnabled;
        private bool _normalIceButtonEnabled;
        private bool _hotButtonEnabled;
        private bool _lessIceButtonEnabled;
        private bool _noIceButtonEnabled;
        private bool _payButtonEnabled;
        private bool _drinkAddButtonOneEnabled;
        private bool _drinkAddButtonTwoEnabled;
        private bool _drinkAddButtonThreeEnabled;
        private bool _drinkAddButtonFourEnabled;
        private const string TOTAL_PRICE = "總價：";
        private const string COIN = "元";
        private const string ORDER_DATA_GRID_VIEW_BUTTON_CLICK_NAME = "刪除";
        private const int COLUMN_TWO = 2;
        private const int COLUMN_THREE = 3;
        private const int COLUMN_FOUR = 4;
        private const int COLUMN_FIVE = 5;

        //default constructor
        public PresentationModel()
        {
            _drinkModel = new DrinkModel();
        }

        //get drink model
        public DrinkModel GetDrinkModel()
        {
            return _drinkModel;
        }

        //pay button is enabled or not
        public bool IsEnabledPayButton(int rowCount)
        {
            if (rowCount != 0)
                _payButtonEnabled = _drinkModel.IsNotEmpty();
            return _payButtonEnabled;
        }

        //normal sugar button is enabled or not
        public bool IsEnabledNormalSugarButton()
        {
            return _normalSugarButtonEnabled;
        }

        //half sugar button is enabled or not
        public bool IsEnabledHalfSugarButton()
        {
            return _halfSugarButtonEnabled;
        }

        //less sugar button is enabled or not
        public bool IsEnabledLessSugarButton()
        {
            return _lessSugarButtonEnabled;
        }

        //no sugar button is enabled or not
        public bool IsEnabledNoSugarButton()
        {
            return _noSugarButtonEnabled;
        }

        //normal ice button is enabled or not
        public bool IsEnabledNormalIceButton()
        {
            return _normalIceButtonEnabled;
        }

        //hot button is enabled or not
        public bool IsEnabledHotButton()
        {
            return _hotButtonEnabled;
        }

        //less ice button is enabled or not
        public bool IsEnabledLessIceButton()
        {
            return _lessIceButtonEnabled;
        }

        //no ice button is enabled or not
        public bool IsEnabledNoIceButton()
        {
            return _noIceButtonEnabled;
        }

        //set pay button
        public void SetPayButton(bool state)
        {
            _payButtonEnabled = state;
        }

        //drink add button is enabled or not
        public bool IsEnabledAddButton(int rowIndex)
        {
            if (rowIndex == 0)
                return _drinkAddButtonOneEnabled;
            else if (rowIndex == 1)
                return _drinkAddButtonTwoEnabled;
            else if (rowIndex == COLUMN_TWO)
                return _drinkAddButtonThreeEnabled;
            else
                return _drinkAddButtonFourEnabled;
        }

        //set all button
        public void SetAllButton(bool state)
        {
            _drinkAddButtonOneEnabled = state;
            _drinkAddButtonTwoEnabled = state;
            _drinkAddButtonThreeEnabled = state;
            _drinkAddButtonFourEnabled = state;
            _normalSugarButtonEnabled = state;
            _halfSugarButtonEnabled = state;
            _lessSugarButtonEnabled = state;
            _noSugarButtonEnabled = state;
            _normalIceButtonEnabled = state;
            _hotButtonEnabled = state;
            _lessIceButtonEnabled = state;
            _noIceButtonEnabled = state;
            _payButtonEnabled = state;
        }

        //initialize properties
        public void InitializeProperties(DataGridView dataGridView)
        {
            dataGridView.RowHeadersVisible = false;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.Azure;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //update order table
        public void UpdateOrder(DataGridView orderDataGridView, Label label)
        {
            orderDataGridView.RowCount = _drinkModel.GetNumberOfOrderDrinks();
            for (int count = 0; count < orderDataGridView.RowCount; count++)
            {
                orderDataGridView.Rows[count].Cells[0].Value = _drinkModel.GetOrderDrink(count).GetDrinkName();
                orderDataGridView.Rows[count].Cells[1].Value = _drinkModel.GetOrderDrink(count).GetDrinkPrice();
                orderDataGridView.Rows[count].Cells[COLUMN_TWO].Value = _drinkModel.GetOrderDrink(count).GetDrinkSugar();
                orderDataGridView.Rows[count].Cells[COLUMN_THREE].Value = _drinkModel.GetOrderDrink(count).GetDrinkTemperature();
                orderDataGridView.Rows[count].Cells[COLUMN_FOUR].Value = _drinkModel.UpdateAdditionInOrderTable(count);
                orderDataGridView.Rows[count].Cells[COLUMN_FIVE].Value = ORDER_DATA_GRID_VIEW_BUTTON_CLICK_NAME;
            }
            label.Text = (TOTAL_PRICE + _drinkModel.GetTotalPrice().ToString() + COIN);
        }

        //update drink addition
        public void SetAddButton(int rowIndex, bool state)
        {
            if (rowIndex == 0)
                _drinkAddButtonOneEnabled = state;
            else if (rowIndex == 1)
                _drinkAddButtonTwoEnabled = state;
            else if (rowIndex == COLUMN_TWO)
                _drinkAddButtonThreeEnabled = state;
            else if (rowIndex == COLUMN_THREE)
                _drinkAddButtonFourEnabled = state;
        }

        //change addition button state
        public void ChangeDrinkAdditionButtonState(int orderRowIndex)
        {
            for (int count = 0; count < COLUMN_FOUR; count++)
            {
                if (_drinkModel.CheckAdditionInOrderList(orderRowIndex, count))
                {
                    SetAddButton(count, false);
                }
                else
                {
                    SetAddButton(count, true);
                }
            }
        }

        //click drink data grid view
        public void ClickDrinkDataGridView(int rowIndex, DataGridView orderDataGridView, Label label)
        {
            _drinkModel.UpdateDrinkInOrderDataGridView(rowIndex);
            orderDataGridView.RowCount = _drinkModel.GetNumberOfOrderDrinks();
            UpdateOrder(orderDataGridView, label);
            orderDataGridView.CurrentCell = orderDataGridView.Rows[orderDataGridView.RowCount - 1].Cells[0];
            SetAllButton(true);
        }
    }
}
