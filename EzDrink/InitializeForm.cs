using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzDrink
{
    partial class EzDrinkForm
    {
        //initialize datagridview
        private void InitializeDataGridView()
        {
            InitializeDrinkDataGridView();
            InitializeOrderDataGridView();
            InitializeDrinkAdditionDataGridView();
        }

        //initialize datagridview1
        private void InitializeDrinkDataGridView()
        {
            _presentationModel.InitializeProperties(_drinkDataGridView);
            InitializeDrinkTable();
        }

        //initialize drink table
        private void InitializeDrinkTable()
        {
            _drinkDataGridView.RowCount = _drinkModel.GetNumberOfDrinks();
            for (int count = 0; count < _drinkDataGridView.RowCount; count++)
            {
                _drinkDataGridView.Rows[count].Cells[0].Value = DRINK_DATA_GRID_VIEW_BUTTON_CLICK_NAME;
                _drinkDataGridView.Rows[count].Cells[1].Value = _drinkModel.GetDrink(count).GetName();
                _drinkDataGridView.Rows[count].Cells[COLUMN_TWO].Value = _drinkModel.GetDrink(count).GetPrice();
            }
        }

        //initialize datagridview2
        private void InitializeOrderDataGridView()
        {
            _presentationModel.InitializeProperties(_orderDataGridView);
        }

        //initialize drink addition datagridview
        private void InitializeDrinkAdditionDataGridView()
        {
            _presentationModel.InitializeProperties(_drinkAdditionDataGridView);
            _drinkAdditionDataGridView.RowCount = _drinkModel.GetNumberOfDrinkAddition();
            for (int count = 0; count < _drinkAdditionDataGridView.RowCount; count++)
            {
                _drinkAdditionDataGridView.Rows[count].Cells[0].Value = DRINK_ADDITION_DATA_GRID_VIEW_BUTTON_CLICK_NAME;
                _drinkAdditionDataGridView.Rows[count].Cells[1].Value = _drinkModel.GetDrinkAddition(count).GetName();
                _drinkAdditionDataGridView.Rows[count].Cells[COLUMN_TWO].Value = _drinkModel.GetDrinkAddition(count).GetPrice();
            }
        }
    }
}
