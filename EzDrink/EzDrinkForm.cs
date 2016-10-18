using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzDrink
{
    public partial class EzDrinkForm : Form
    {
        private PresentationModel _presentationModel;
        private DrinkModel _drinkModel;
        private const int SELECT_CHOOSE_BUTTON_POSITION = 0;
        private const int SELECT_DELETE_BUTTON_POSITION = 5;
        private const int COLUMN_TWO = 2;
        private const string DRINK_DATA_GRID_VIEW_BUTTON_CLICK_NAME = "選擇";
        private const string ORDER_DATA_GRID_VIEW_BUTTON_CLICK_NAME = "刪除";
        private const string DRINK_ADDITION_DATA_GRID_VIEW_BUTTON_CLICK_NAME = "選擇";
        private const string TOTAL_PRICE = "總價：";
        private const string COIN = "元";

        //constructor
        public EzDrinkForm()
        {
            InitializeComponent();
            this.MinimumSize = new Size(this.Size.Width, this.Size.Height);
            _presentationModel = new PresentationModel();
            _drinkModel = _presentationModel.GetDrinkModel();
            InitializeDataGridView();
            _presentationModel.SetAllButton(false);
            UpdateButtonState();
        }

        //exit program when click Exit
        private void ClickExitToolStripMenuItem(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //find the position clicked and do ClickButton
        private void ClickDrinkDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _drinkDataGridView.RowCount)
            {
                if (e.ColumnIndex == SELECT_CHOOSE_BUTTON_POSITION)
                {
                    _presentationModel.ClickDrinkDataGridView(e.RowIndex, _orderDataGridView, _label);
                    UpdateButtonState();
                }
            }
        }

        //click drink addition datagridview
        private void ClickDrinkAdditionDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _drinkAdditionDataGridView.RowCount)
            {
                if ((e.ColumnIndex == SELECT_CHOOSE_BUTTON_POSITION) && _presentationModel.IsEnabledAddButton(e.RowIndex))
                {
                    _drinkModel.UpdateDrinkAdditionInOrderDataGridView(e.RowIndex, this._orderDataGridView.SelectedRows[0].Index);
                }
                _presentationModel.UpdateOrder(_orderDataGridView, _label);
                _presentationModel.SetAddButton(e.RowIndex, false);
                UpdateButtonState();
            }
        }

        //click order datagridview
        private void ClickOrderDataGridViewCellContent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < _orderDataGridView.RowCount)
            {
                if (e.ColumnIndex == SELECT_DELETE_BUTTON_POSITION)
                {
                    _drinkModel.UpdateOrderDrinkInOrderDataGridView(e.RowIndex);
                    _presentationModel.UpdateOrder(_orderDataGridView, _label);
                    UpdateButtonState();
                }
            }
        }

        //order data grid view row changed
        private void OrderDataGridViewRowChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Index >= 0 && e.Row.Index < _orderDataGridView.RowCount)
            {
                _presentationModel.ChangeDrinkAdditionButtonState(e.Row.Index);
                if (_orderDataGridView.RowCount == 1)
                    _presentationModel.SetAllButton(false);
                UpdateButtonState();
            }
        }

        //click normal sugar
        private void ClickNormalSugarButton(object sender, EventArgs e)
        {
            Sugar sugar = Sugar.Normal;
            UpdateSugar(sugar);
        }

        //click half sugar
        private void ClickHalfSugarButton(object sender, EventArgs e)
        {
            Sugar sugar = Sugar.Half;
            UpdateSugar(sugar);
        }
        
        //click less sugar
        private void ClickLessSugarButton(object sender, EventArgs e)
        {
            Sugar sugar = Sugar.Less;
            UpdateSugar(sugar);
        }

        //click no sugar
        private void ClickNoSugarButton(object sender, EventArgs e)
        {
            Sugar sugar = Sugar.No;
            UpdateSugar(sugar);
        }

        //click normal ice
        private void ClickNormalIceButton(object sender, EventArgs e)
        {
            Temperature temperature = Temperature.Normal;
            UpdateTemperature(temperature);
        }

        //click hot
        private void ClickHotButton(object sender, EventArgs e)
        {
            Temperature temperature = Temperature.Hot;
            UpdateTemperature(temperature);
        }

        //click less ice
        private void ClickLessIceButton(object sender, EventArgs e)
        {
            Temperature temperature = Temperature.Less;
            UpdateTemperature(temperature);
        }

        //click no ice
        private void ClickNoIceButton(object sender, EventArgs e)
        {
            Temperature temperature = Temperature.No;
            UpdateTemperature(temperature);
        }

        //click pay
        private void ClickPayButton(object sender, EventArgs e)
        {
            _drinkModel.ClickPayButton();
            _presentationModel.UpdateOrder(_orderDataGridView, _label);
            _presentationModel.SetAllButton(false);
            UpdateButtonState();
        }

        //update sugar
        private void UpdateSugar(Sugar sugar)
        {
            _drinkModel.ClickSugarButton(sugar, this._orderDataGridView.SelectedRows[0].Index);
            _presentationModel.UpdateOrder(_orderDataGridView, _label);
            UpdateButtonState();
        }

        //update temperature
        private void UpdateTemperature(Temperature temperature)
        {
            _drinkModel.ClickTemperatureButton(temperature, this._orderDataGridView.SelectedRows[0].Index);
            _presentationModel.UpdateOrder(_orderDataGridView, _label);
            UpdateButtonState();
        }

        //update button state
        private void UpdateButtonState()
        {
            DataGridViewDisableButtonCell cell;

            _payButton.Enabled = _presentationModel.IsEnabledPayButton(_orderDataGridView.RowCount);
            _normalSugarButton.Enabled = _presentationModel.IsEnabledNormalSugarButton();
            _halfSugarButton.Enabled = _presentationModel.IsEnabledHalfSugarButton();
            _lessSugarButton.Enabled = _presentationModel.IsEnabledLessSugarButton();
            _noSugarButton.Enabled = _presentationModel.IsEnabledNoSugarButton();
            _normalIceButton.Enabled = _presentationModel.IsEnabledNormalIceButton();
            _hotButton.Enabled = _presentationModel.IsEnabledHotButton();
            _lessIceButton.Enabled = _presentationModel.IsEnabledLessIceButton();
            _noIceButton.Enabled = _presentationModel.IsEnabledNoIceButton();
            for (int count = 0; count < _drinkAdditionDataGridView.RowCount; count++)
            {
                cell = (DataGridViewDisableButtonCell)_drinkAdditionDataGridView.Rows[count].Cells[0];
                cell.Enabled = _presentationModel.IsEnabledAddButton(count);
            }
            _drinkAdditionDataGridView.Refresh();
        }
    }
}
