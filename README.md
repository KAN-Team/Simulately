# Simulately

Simulately is a package that consists of Three simulation systems from different ideas.
- [x] Multi-Queue Simulation.
- [x] Newspaper Seller Simulation.
- [x] Inventory Simulation. 

# Prerequisites

1. Install Visual Studio version 2013 or higher
2. Install .Net Framework 4.5.1 or higher
3. C# Programming Language


## 1) Multi-Queue Simulation

Multi-Queue Simulation is a full simulation desktop system that simulate customer service for multi-servers operations and calculate servers/system Performance Measurements.

### Features: 
- Calculate Servers/System Performance measurements.
- Visualize servers state using Charts `Busy` , `Idle`.
- Automation Testing with some test cases.
- Select Server Selection Method `Highest Priority` , `Random` , `Least Utilization`.
- Select System Stopping Criteria `Number Of Customers` , `Simulation End Time`.
- Loading input from text file with specific format.


### Working Screenshots:


<details>

  <summary> Valid System</summary>

<p>

### 1.Home Screen

![1](https://user-images.githubusercontent.com/52586356/140431913-8f2b3527-623a-463b-acbe-cf339c481b90.png)

</p>

<p>


### 2.Loading Input From Text File

![2](https://user-images.githubusercontent.com/52586356/140432020-e3b666d8-94cd-45cf-8126-842d9d3863e0.png)


![3](https://user-images.githubusercontent.com/52586356/140432064-f3789b40-5f40-4cc4-8bfe-f6ec892582be.png)


</p>


<p>

### 3.Manual Input

![4](https://user-images.githubusercontent.com/52586356/140432146-e5f3fb8b-adf0-4e42-91e4-a4fca150f0b5.png)


![5](https://user-images.githubusercontent.com/52586356/140432122-d68d23c0-fbfe-4824-ab1b-55da830d724e.png)


![6](https://user-images.githubusercontent.com/52586356/140432165-310c9e76-28f6-4e7c-b633-02f70d4e5e9e.png)


![7](https://user-images.githubusercontent.com/52586356/140432236-888000b0-8153-4dcf-a9e6-88bffc7b86d4.png)

</p>


<p>

### 4.Simulation System

![8](https://user-images.githubusercontent.com/52586356/140432253-86bc7e27-1436-4885-a7ab-92e82d1e2341.png)

</p>


<p>

### 5.System Performance Measurements

![9](https://user-images.githubusercontent.com/52586356/140432356-1adc88e3-df1e-4d8f-b619-a9166000d55f.png)


</p>


<p>

### 3.Servers State Charts

![10](https://user-images.githubusercontent.com/52586356/140432401-55169e42-79d1-42cf-91ac-91d83a1fcef0.png)


![11](https://user-images.githubusercontent.com/52586356/140432409-2d18a993-87f4-41b1-9bc8-5f06a581d07c.png)


</p>


</details>


<details>

  <summary> Invalid Inputs</summary>

<p>

### 1.Invalid input file Formate 


- missing number of servers

![12](https://user-images.githubusercontent.com/52586356/140434041-dd97db46-015b-486f-883d-85c552d05b3d.png)

- choosing in-valid format

![13](https://user-images.githubusercontent.com/52586356/140434153-13759788-9de4-471c-b669-10d4e114d0cb.png)

- Valid format Warning Message

![14](https://user-images.githubusercontent.com/52586356/140434212-e73fd644-bdfb-4a83-aecc-8d1812b7bc78.png)


</p>



<p>

### 2.Invalid Manual input

- There must be at least 2 servers to simulate.

![15](https://user-images.githubusercontent.com/52586356/140434277-b98ce9c9-1407-4f0b-b22a-1649a0761ce4.png)

- There must be at least 2 customers OR 2 clock to simulate

![16](https://user-images.githubusercontent.com/52586356/140434711-6c2d79a5-8684-44b4-8e84-c90bfbac1fe5.png)

- sum of Probability must be equal 1 

![17](https://user-images.githubusercontent.com/52586356/140434814-4618fb94-7b21-471d-869e-20273838559a.png)

![18](https://user-images.githubusercontent.com/52586356/140434832-cebae250-5e7e-440c-8763-c56ab55633ff.png)


</p>


</details>


## 2) Newspaper Seller Simulation

Newspaper Seller Simulation is a full simulation desktop system that simulate newspaper seller operations

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

### 1.Home Screen

![1](https://user-images.githubusercontent.com/52586356/140431913-8f2b3527-623a-463b-acbe-cf339c481b90.png)

</p>

<p>


### 2.Loading Input From Text File

![2](https://user-images.githubusercontent.com/52586356/140432020-e3b666d8-94cd-45cf-8126-842d9d3863e0.png)


![3](https://user-images.githubusercontent.com/52586356/148279268-6f20a8f3-6158-494a-b265-df3e9a694f7b.png)

  

</p>


<p>

### 3.Manual Input

![4](https://user-images.githubusercontent.com/52586356/148279697-56f6d1bc-5bc7-4244-8f6a-0e6721dacb8f.png)


![5](https://user-images.githubusercontent.com/52586356/148279798-4ffff0d0-4ce6-4400-a95c-6fda8326be7b.png)

  
</p>

<p>

### 4.Simulation System

![6](https://user-images.githubusercontent.com/52586356/148280187-9b4a90a5-652a-45c3-a72a-948d94cefc0f.png)

</p>
  
<p>

### 5.System Performance Measurements

![7](https://user-images.githubusercontent.com/52586356/148280231-38fe28f9-4d2f-4d8b-b402-be3ee36f6a14.png)

</p>


</details>



<details>

  <summary> Invalid Inputs</summary>


<p>

### 1.Invalid Manual input

- Sum of Probability must be equal 1 

![1](https://user-images.githubusercontent.com/52586356/148281692-5108502a-5b69-4a80-81aa-95c4ff0a9a5a.png)

- Must Fill all fields

![1](https://user-images.githubusercontent.com/52586356/148281788-69e57405-7a59-4688-b3ca-f4b3d18d2798.png)

</p>

</details>


## 3) Inventory Simulation

Inventory Simulation is a full simulation desktop system that simulate refrigerators inventory operations such as:
- Refrigerators inventory has `M` order up to level.
- Making order with currently demand after `N` days.
- it can take the shortage quantity in consedration.

System Performance Measurements such as:
- Ending Inventory Average 
- Shortage Quantity Average 




### Working Screenshots:


# References

- [System Performance Measurements](MultiQueueSimulation/MultiQueueSimulation/Assets/performance_mesures.png) 
 
- [.Net Framework 4.5.1](https://www.microsoft.com/ar-sa/download/details.aspx?id=40779)

- [Visual studio](https://visualstudio.microsoft.com/downloads/)