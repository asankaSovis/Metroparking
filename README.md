# 🚘 Metroparking
 
![Metroparking](https://user-images.githubusercontent.com/46389631/194839662-19e699b5-b7ec-4259-8cf9-1fa74e74e778.png)
> The Smart Parking System

---

**Metroparking** is a next level smart parking system that automates the process of reserving, paying and managing parking services in urban parking providers. It is an IoT based project that uses electronics, autonomous and cloud technologies to create a fully automated system to handle parking.

## ❓ Problem Identification

The main problem we identified with the existing parking systems in the country is the inefficiency of of the implementation. With this, the question arose to us; *How can we improve the effectiveness of existing parking systems?*. Running along with this problem, we built the following issues.
- Too much manual labour involved
- Have to manually find a vacant parking slot
- Payments have to be done to an attendant
- Not enough safety when it comes to handing the vehicles
- Can't book a parking space beforehand

## ❗ Our Solution

The solution we came up with is the **Metroparking** project. It initiated with the following vision in mind.

> A fully automated, online, smart parking system based on IoT and cloud technologies, capable of assisting the client

## 🎯 Objectives

- To build an automated online parking system
- To allow users to conveniently book reservations online beforehand
- To allow assisted parking for a safe and convenient experience

## ⚙️ Technologies Used

- Internet of Things (IoT)
- Cloud Storage
- Smart Autonomous System

## 🏗️ Architecture

> ![Architecture](https://user-images.githubusercontent.com/46389631/194903089-4d5731f6-81fd-4b50-a828-e6d9d8fd787f.png)
> The architecture of the entire project

## 💽 Components

### 1. Central Computer
- Server PC
- Admin Panel - C#, VIsual Studio 2019
- Central Database - MySQL
- Client and Kiosk Web Hosting - Apache 
- Router (Create a local network for testing)

### 2. Parking Space Kiosk
- Tablet PC - Android
- Connected to the network

### 3. Client Device
- Smart Phone - Any device
- Client logs into their account on our service

### 4. Parking slot controller 
- Arduino Mega
- Servo - Control Gate
- SONAR - For Safe Parking

## 🧭 Integrated Features

### 1. Central Computer
- Controls the complete ecosystem
- Hosts the web server for the client side
- Hosts the database for the system
- Allows full control for the admins
- Communicates with the sensing equipment on each slot
- Handle the kiosk displays

### 2. Parking Space Kiosk
- Allow the users to check their reservations 
- Scan the QR code sent earlier to enter the parking slot

### 3. Client Device
- Allows the users to register with our service and reserve parking slots
- The remaining time for the reserved parking slot can also be checked
- Developed from HTML, CSS, JS and PHP

### 4. Parking slot controller 
- Handles the opening and closing of slot gates
- Allows the users to safely park their car and leave the slots

## 🎢 Limitations
1. Have to fix some operational bugs.
2. Not implemented on actual parking location
3. The actual payment gateway is not implemented
4. The system is implemented for only a single slot
5. Users cannot change the booking
6. Users cannot book multiple parking slots at the same time 
7. Doesn't prevent a user from exceeding their allocated time period
8. Doesn't allow users to edit their profiles

## 🛠️ Further Improvements
1. A mobile Application
2. Implementing the system for multiple slots
3. Number plate scanning
4. Allow more flexibility in user accounts

## 📊 Demonstration

> [![Metroparking Demonstration Video](https://user-images.githubusercontent.com/46389631/195007261-abd4d400-fac9-45da-98fa-a0a12163ac2e.png)](https://youtu.be/wTZRGQGPwoQ)
> Demonstration video of the final product

` © Intelligent Technologies`

