# Simulately

Simulately is a package that consists of Three simulation systems from different ideas.
- [x] Multi-Queue Simulation.
- [x] Newspaper Seller Simulation.
- [x] Inventory Simulation. 

# Prerequisites

1. Install Visual Studio version 2013 or higher
2. Install .Net Framework 4.5.1 or higher
3. C# Programming Language

***

## 1) Multi-Queue Simulation

Multi-Queue Simulation is a full simulation desktop system that simulates customer service for multi-servers operations and calculate servers/system Performance Measurements.

### Features: 
- Calculate Servers/System Performance measurements.
- Visualize servers state using Charts `Busy` , `Idle`.
- Automation Testing with some test cases.
- Select Server Selection Method `Highest Priority` , `Random` , `Least Utilization`.
- Select System Stopping Criteria `Number Of Customers` , `Simulation End Time`.
- Loading input from text file with specific format.


### Working Screenshots:


<details>

  <summary> Valid System </summary>

<p>

### 1.Home Screen

![Home Screen](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/1.png)

</p>

<p>

### 2.Loading Inputs From Text File

![CustomLoadFileWindow](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/2.png)


![CustomLoadFileWindow Dialog](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/3.png)

</p>


<p>

### 3.Manual Inputs

![4](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/4.png)
  
  
![5](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/5.png)


![6](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/6.png)


![7](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/7.png)

</p>


<p>

### 4.Simulation System

![8](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/8.png)

</p>


<p>

### 5.System Performance Measurements

![9](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/9.png)

</p>


<p>

### 3.Servers State Charts

![10](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/10.png)


![11](Screenshots/1%29%20MultiQueueSimulation/Valid%20system/11.png)

</p>


</details>


<details>

  <summary> Invalid Inputs </summary>

<p>

### 1.Invalid Input File Format

- Missing Number of Servers

![1](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/1.png)

- Reading Invalid Format

![2](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/2.png)

- Invalid Format Error Message

![3](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/3.png)

</p>

  
<p>

### 2.Invalid Manual inputs

- There must be at least 2 servers to simulate

![4](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/4.png)

- There must be at least 2 customers OR 2 clock to simulate

![5](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/5.png)

- Sum of Probabilities must be Equal 1 

![6](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/6.png)

![7](Screenshots/1%29%20MultiQueueSimulation/InValid%20system/7.png)

</p>


</details>

<!--- ############################################################################################################################## --->

***

## 2) Newspaper Seller Simulation

Newspaper Seller Simulation is a full simulation desktop system that simulates newspaper seller operations

in different days `Good`, `Fair`, `Poor` such as:
- Daily Profit.
- Lost Profit from Excess Demand.
- Salvage from Scale of Scrap. 

System Performance Measurements such as:
- Total Sales Revenue.
- Total Cost of Newspapers.
- Total Lost Profit from Excess Demand.
- Total Salvage from sale of Scrap papers.
- Net Profit.
- Number of days having excess demand.
- Number of days having unsold papers.

### Working Screenshots:

<details>

  <summary> Valid System</summary>

<p>

### 1.Loading Inputs From Text File

![1](Screenshots/2%29%20NewspaperSellerSimulation/Valid/1.png)
  
</p>


<p>

### 2.Manual Inputs

![2](Screenshots/2%29%20NewspaperSellerSimulation/Valid/2.png)

![3](Screenshots/2%29%20NewspaperSellerSimulation/Valid/3.png)
  
</p>

  
<p>

### 3.Simulation System

![4](Screenshots/2%29%20NewspaperSellerSimulation/Valid/4.png)

</p>
  
  
<p>

### 4.System Performance Measurements

![5](Screenshots/2%29%20NewspaperSellerSimulation/Valid/5.png)

</p>

</details>


<details>

  <summary> Invalid Inputs </summary>

<p>

### 1.Invalid Manual Inputs

- All Fields must be Filled

!![1](Screenshots/2%29%20NewspaperSellerSimulation/Invalid/1.png)
  
- Sum of Probabilities must be Equal 1 

![2](Screenshots/2%29%20NewspaperSellerSimulation/Invalid/2.png)

</p>

</details>

<!--- ############################################################################################################################## --->

*** 

## 3) Inventory Simulation

Inventory Simulation is a full simulation desktop system that simulate refrigerators inventory operations such as:
- Refrigerators inventory has `M` order up to level.
- Making order with currently demand after `N` days.
- it can take the shortage quantity in consedration.

System Performance Measurements such as:
- Ending Inventory Average 
- Shortage Quantity Average 

### Working Screenshots:

<details>

  <summary> Valid System</summary>

<p>

### 1.Loading Inputs From Text File

![1](Screenshots/3%29%20InventorySimulation/Valid/1.png)
  
</p>

  
<p>

### 2.Simulation System

![2](Screenshots/3%29%20InventorySimulation/Valid/2.png)

</p>

</details>


<details>

  <summary> Invalid Inputs </summary>

<p>

- Reading Invalid Format

![1](Screenshots/3%29%20InventorySimulation/Invalid/1.png)

</p>

</details>

<!--- ############################################################################################################################## --->

***

### References

- [System Performance Measurements](MultiQueueSimulation/MultiQueueSimulation/Assets/performance_mesures.png) 
- [.Net Framework 4.5.1](https://www.microsoft.com/ar-sa/download/details.aspx?id=40779)
- [Visual studio](https://visualstudio.microsoft.com/downloads/)

#### Copyrights
- Kareem S. Fathy - Kareem S. Ragab - Abanoub A. Azaab - Nada M. Abdelhamed - Nada S. Anies
- KAN Org.
- University of Ain Shams, Egypt
