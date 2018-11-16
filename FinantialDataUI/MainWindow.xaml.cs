using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WinForms = System.Windows.Forms;

namespace FinantialDataUI

{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stopwatch stopWatch = new Stopwatch();
        DataLoader d = new DataLoader();       

        public MainWindow()
        {
            InitializeComponent();            
        }

        public Task RunUiTask(Action action)
        {
            var task = Task.Factory.StartNew(() =>
            {
                Dispatcher.Invoke(DispatcherPriority.Background, action);
            });
            return task;
        }

        private void totalCostOfAllOrders(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                foreach (var order in d.orders)
                {                   
                     totalCost = totalCost + order.Cost;                    
                }

                String formated = totalCost.ToString("0.00");
                txtView.Text +=  "Total cost of all orders: " + formated + "\n";

                 stopWatch.Stop();
                 txtView.Text += "Total cost loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfAllOrdersForStore(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                String store = storeB.Text;

                foreach (var order in d.orders)
                {                    
                     if (order.Store.StoreCode.Equals(store))
                     {
                         totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of all orders for store code "+store+" is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost store loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfOrderInWeek(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                int week = Convert.ToInt32(weekB.Text);

                foreach (var order in d.orders)
                {                    
                     if (order.Date.Week == week)
                     {
                          totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of orders in week "+week+" for all stores: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost week all stores loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfOrderInWeekSingleStore(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();

                String store = storeB.Text;
                int week = Convert.ToInt32(weekB.Text);

                foreach (var order in d.orders)
                {                   
                     if (order.Date.Week == week && order.Store.StoreCode.Equals(store))
                     {
                            totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of orders in week single store " + week + " for store code " + store + " is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost week single store loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfAllOrdersToSupplier(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                String supplier = sNameB.Text;

                foreach (var order in d.orders)
                {                    
                     if (order.SupplierName.Equals(supplier))
                     {
                         totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of all orders to a supplier " + supplier + ", is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost all orders for supplier loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfAllOrdersToSupplierType(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                String supplierType = sTypeB.Text;

                foreach (var order in d.orders)
                {                   
                     if (order.SupplierType.Equals(supplierType))
                     {
                          totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of all orders to a supplier type " + supplierType + ", is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost all suppliers loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfOrdersInWeekForSupplierType(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                String supplierType = sTypeB.Text;
                int week = Convert.ToInt32(weekB.Text);

                foreach (var order in d.orders)
                {                  
                     if (order.Date.Week == week && order.SupplierType.Equals(supplierType))
                     {
                          totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of orders in week " + week + ", for supplier type " + supplierType + ", is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost supplier type loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfOrderForSuplierTypeForStore(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                String supplierType = sTypeB.Text;
                String store = storeB.Text;

                foreach (var order in d.orders)
                {                 
                      if (order.Store.StoreCode.Equals(store) && order.SupplierType.Equals(supplierType))
                      {
                          totalCost += order.Cost;
                      }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of orders for supplier type " + supplierType + ", for a store code " + store + ", is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost supplier type store loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void totalCostOfOrderInWeekForSupplierTypeForStore(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                double totalCost = 0;
                stopWatch.Reset();
                stopWatch.Start();
                String supplierType = sTypeB.Text;
                String store = storeB.Text;
                int week = Convert.ToInt32(weekB.Text);

                foreach (var order in d.orders)
                {                    
                     if (order.Date.Week == week && order.Store.StoreCode.Equals(store) && order.SupplierType.Equals(supplierType))
                     {
                         totalCost += order.Cost;
                     }                    
                }
                String formated = totalCost.ToString("0.00");
                txtView.Text += "Total cost of orders in week " + week + ", for supplier type " + supplierType + ", for a store code " + store + ", is: " + formated + "\n";

                stopWatch.Stop();
                txtView.Text += "Total cost week supplier type store loading time: " + stopWatch.Elapsed.TotalSeconds + "\n";
            });
        }

        private void storeCodesFileLoader(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.DefaultExt = ".csv";
                ofd.Filter = "Store codes (.csv)|*.csv";
                if(ofd.ShowDialog()==true)
                {
                    d.storeCodesFile = ofd.FileName;
                    textBox4.Text = d.storeCodesFile;
                    var number = d.LoadData();

                    if (number > 0)
                    {
                        txtView.Text += "Files loaded successfully: " + number + "\n";
                    }
                    else
                    {
                        txtView.Text += "Path of the files is missing\n";
                    }                    
                }
            });
        }

        private void fileDataLoader(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                String folderPath ="";
                WinForms.FolderBrowserDialog folderDialog = new WinForms.FolderBrowserDialog();
                folderDialog.ShowNewFolderButton = false;
                folderDialog.SelectedPath = System.AppDomain.CurrentDomain.BaseDirectory;
                WinForms.DialogResult result = folderDialog.ShowDialog();

                if(result == WinForms.DialogResult.OK)
                {
                    folderPath = folderDialog.SelectedPath;
                    textBox5.Text = folderPath;
                    d.storeDataFolder = folderPath;
                    var number = d.LoadData();

                    if (number>0)
                    {
                        txtView.Text += "Files loaded successfully: " + number + "\n";
                    }
                    else
                    {
                        txtView.Text += "Path of the files is missing\n";
                    }                    
                }
                //DirectoryInfo folder = new DirectoryInfo(folderPath);
            });
        }

        private void allStoresList(object sender, RoutedEventArgs e)
        {           
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                int count = 0;
                foreach (var s in d.stores)
                //Parallel.ForEach(d.stores, s =>
               {
                  txtView.Text += "Store code: " + s.Key + "   \tStore location: " + s.Value.StoreLocation +"\n";
                  count++;
               }/*);*/
               txtView.Text += "Stores number: " + count;
        
             });
        }

        private void allSuppliersTypesList(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                int count = 0;
                foreach (var s in d.supplierType)
                {
                    txtView.Text += "Supplier type: " + s.Key + "\n";
                    count++;
                }
                txtView.Text += "Supplier types number: " + count;
            });
        }

        private void allSuppliersNamesList(object sender, RoutedEventArgs e)
        {
            var task = RunUiTask(() =>
            {
                txtView.Text = "";
                int count = 0;
                foreach (var s in d.suppliers)
                {
                    txtView.Text += "Supplier name: " + s.Key + "\n";
                    count++;
                }
                txtView.Text += "Suppliers number: " + count;
            });
        }
    }
}
