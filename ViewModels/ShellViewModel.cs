using Caliburn.Micro;
using Coco_Master.Views;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coco_Master.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        
        public void LoadHome()
        {
            ActivateItemAsync(new HomeViewModel());
        }

        public void LoadEmployees()
        {
            ActivateItemAsync(new EmployeesViewModel());
        }

        public void LoadCoconutBuyers()
        {
            ActivateItemAsync(new CoconutBuyersViewModel());
        }

        public void LoadHuskBuyers()
        {
            ActivateItemAsync(new HuskBuyersViewModel());
        }

        public void LoadSuppliers()
        {
            ActivateItemAsync(new SuppliersViewModel());
        }

        public void LoadStocks()
        {
            ActivateItemAsync(new StocksViewModel());
        }

        public void LoadVehicles()
        {
            ActivateItemAsync(new VehiclesViewModel());
        }

       

    }

}
