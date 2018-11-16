# Task-Based-Project-C#
Aplikacja wykorzystująca Task Parallel Library (TPL) do optymalizacji szybkości działania kodu.

Description

You are required to develop, demonstrate, and show improvements to an application making use of the Task Parallel Library (TPL). 

Project criteria

Spur Ltd are a company that consists of 100 convenience stores in various locations around the UK. The have a modern Point of Sale system however their Supply Ordering system is a little out dated and they feel parts of their ordering process can be improved. Currently stores make orders with their suppliers independently of each other, this causes an issue for the finances team at Spur Headquarters as they find it very hard to collect all the information for the supplier orders made from the independent stores.
Each independent store generates numerous .csv files (1 a week) that contain the data for all the orders they make. The finances team would like a fast and responsive system that will allow them to analyse the data sent from the stores.
Spur Ltd are happy for you to experiment with solutions around this but have suggested that the use of the Task Parallel library would be beneficial as they believe it will impact the efficiency of the algorithm most effectively.
The finance team already have a method of receiving the files from the stores, they get placed into a central folder which they hope this new application will be able to read from. You will be supplied with 2 years of historical order data for each of the 100 stores to help you test your solution.

Minimum Requirements

• An easy to use command line interface.

• All features should be calculated when the option is selected, not at initial load. This will allow the data sets to be updated and the calculations rerun without reopening the application. Spur's technical team would like the UI to continue being responsive during these calculations.

• Have the flexibility to point the application to a certain folder on a PC to find the .csv files.

• List all stores, suppliers and supplier types.

• Allow the Finances team to find the following data:

  o The total cost of all orders available in the supplied data

  o The total cost of all orders for a single store

  o The total cost of orders in a week for all stores

  o The total cost of orders in a week for a single store

  o The total cost of all orders to a supplier

  o The cost of all orders from a supplier type

  o The cost of orders in a week for a supplier type

  o The cost of orders for a supplier type for a store

  o The cost of orders in a week for a supplier type for a store

Advanced Requirements

• A Graphical User Interface using WinForms or WPF
• Other features the developer feels suitable may also be rewarded

Data File Specification

StoreCodes.csv lists all stores and their corresponding Store Codes. File naming format: [Store Code]_[Week Number]_[Year].csv
File naming example: STA1_1_2013.csv
(Stafford Store for Week 1 of 2013)
File CSV format: [Supplier Name],[Supplier Type],[Cost of Order] File CSV Example: Heinz,Beauty,103.53

As mentioned above, Spur also require documentation to be produced that details the design of the application. This should include information as to how the system has been designed with appropriate diagrams and detailed technical discussion around the system architecture and parallel programming concepts that have been applied in this system.

Spur technical team are also interested in the documentation of any performance related improvements and the expected speedup that can be achieved using the Task Parallel Library. Performance testing as well as an evaluation of the results would be very beneficial to the Spur Technical Team. You may wish to run tests of your application running sequentially to achieve accurate results.
