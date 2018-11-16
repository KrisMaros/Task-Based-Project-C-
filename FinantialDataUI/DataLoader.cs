using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Collections.Concurrent;


namespace FinantialDataUI
{
    class DataLoader
    {
        public string storeCodesFile { get; set; }
        public string storeDataFolder { get; set; }        

        //public static string storeCodesFile = "C:/Users/Krzychu-x/Desktop/Task-Base/StoreCodes.csv";        
        //public string storeDataFolder = "C:/Users/Krzychu-x/Desktop/Task-Base/StoreData";

        public ConcurrentDictionary<string, Store> stores = new ConcurrentDictionary<string, Store>();
        public ConcurrentDictionary<string, string> suppliers = new ConcurrentDictionary<string, string>();
        public ConcurrentDictionary<string, string> supplierType = new ConcurrentDictionary<string, string>();
        public ConcurrentQueue<Order> orders = new ConcurrentQueue<Order>();

        public double LoadData()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            if (storeCodesFile != null && storeDataFolder != null)
            {
                string[] storeCodesData = File.ReadAllLines(storeCodesFile);
                foreach (var storeData in storeCodesData)
                {
                    string[] storeDataSplit = storeData.Split(',');
                    if (!stores.ContainsKey(storeDataSplit[0]))
                        stores.TryAdd(storeDataSplit[0], new Store { StoreCode = storeDataSplit[0], StoreLocation = storeDataSplit[1] });
                }

                string[] fileNames = Directory.GetFiles(storeDataFolder);
                Parallel.ForEach(fileNames, filePath =>
                {
                    string fileNameExt = Path.GetFileName(filePath);
                    string fileName = Path.GetFileNameWithoutExtension(filePath);

                    string[] fileNameSplit = fileName.Split('_');
                    Store store = stores[fileNameSplit[0]];
                    Date date = new Date { Week = Convert.ToInt32(fileNameSplit[1]), Year = Convert.ToInt32(fileNameSplit[2]) };

                    string[] orderData = File.ReadAllLines(storeDataFolder + @"\" + fileNameExt);
                    foreach (var orderInfo in orderData)
                    {
                        string[] orderSplit = orderInfo.Split(',');                       

                        Order order = new Order
                        {
                            Store = store,
                            Date = date,
                            SupplierName = orderSplit[0],
                            SupplierType = orderSplit[1],
                            Cost = Convert.ToDouble(orderSplit[2])
                        };
                        orders.Enqueue(order);
                        if (!suppliers.ContainsKey(orderSplit[0]))
                        {
                            suppliers.TryAdd(orderSplit[0], orderSplit[1]);
                        }
                        if (!supplierType.ContainsKey(orderSplit[1]))
                        {
                            supplierType.TryAdd(orderSplit[1], orderSplit[0]);
                        }
                    }
                });
                stopWatch.Stop();
                return stopWatch.Elapsed.TotalSeconds;
            }
            return 0;
        }
            
    }
}

