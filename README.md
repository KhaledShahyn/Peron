# Peron App – Real Estate Rental Platform (Backend)

This repository contains the **backend implementation** of **Peron**, a real estate rental mobile application built as part of our **graduation project**.

The backend is developed using **.NET** and is responsible for managing users, properties, booking operations, and agent communication.

---

## 📌 Project Overview

**Peron** is a mobile app that allows users to:
- Browse available apartments and properties for rent
- View listings by neighborhood
- Contact agents and request apartment viewings
- Chat with agents in real-time
- Access account details and payment instructions

This backend handles the API logic, database integration, authentication, and communication services used by both the **Flutter mobile app** and **Angular admin dashboard**.

---

## 🛠️ Technologies Used

- **.NET 9** (Web API)
- **Entity Framework Core** (EF Core)
- **SignalR** for real-time chat
- **SQL Server** for database
- **JWT Authentication** for secure login and roles
- **RESTful API architecture**

---

## 🚀 Getting Started (for development)

### Prerequisites:
- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server or LocalDB

### To run locally:
```bash
git clone https://github.com/KhaledShahyn/Peron.git
cd Peron
dotnet restore
dotnet ef database update
dotnet run
