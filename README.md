# 🛍️ Online Thrifting Clothing Store

A Windows Forms desktop application built with C# and .NET Framework 4.7.2 that simulates an online thrift store. Users can register/login, browse clothing categories, and complete a simulated checkout process.

---

## 📋 Table of Contents

- [Features](#features)
- [Tech Stack](#tech-stack)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Known Limitations](#known-limitations)

---

## ✨ Features

- **User Authentication** — Register a new account or log in with an existing one. Credentials are persisted locally in `users.txt`.
- **Category Browsing** — Browse four clothing categories: Pants, T-Shirts, Jackets, and Sweaters.
- **Checkout Form** — Enter and validate payment details including card number (16 digits), cardholder name, expiration date (MM/YY), and CVV (3 digits).
- **Form Navigation** — Seamlessly move between Login → Store → Checkout, with a Back button to return to the category menu.

---

## 🛠️ Tech Stack

- **Language:** C#
- **Framework:** .NET Framework 4.7.2
- **UI:** Windows Forms (WinForms)
- **IDE:** Visual Studio 2022
- **Data Storage:** Local flat-file (`users.txt`)

---

## 🚀 Getting Started

### Prerequisites

- Windows OS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) with the **.NET desktop development** workload installed
- .NET Framework 4.7.2 (included with Visual Studio)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/YOUR_USERNAME/online-thrifting-store.git
   cd online-thrifting-store
   ```

2. **Open the solution** in Visual Studio
   ```
   Double-click: Project2 Online Thrifiting Store.sln
   ```

3. **Build the project**
   - Press `Ctrl + Shift + B` or go to **Build → Build Solution**

4. **Run the application**
   - Press `F5` or click the green **Start** button

> ⚠️ The `users.txt` file will be created automatically on first run if it doesn't exist.

---

## 📁 Project Structure

```
Project2 Online Thrifiting Store/
├── Form1.cs                  # Login & Sign Up screen
├── Form1.Designer.cs
├── Form1.resx
├── Form2.cs                  # Category selection screen
├── Form2.Designer.cs
├── Form2.resx
├── Form3.cs                  # Checkout / payment screen
├── Form3.Designer.cs
├── Form3.resx
├── Program.cs                # Application entry point
├── App.config                # Runtime configuration (.NET 4.7.2)
├── users.txt                 # Local user credential storage
└── Project2 Online Thrifiting Store.sln
```

---

## 📖 Usage

1. **Launch the app** — the Login screen appears.
2. **Sign Up** — click "Sign Up", enter a username and password, then click Submit.
3. **Login** — click "Login", enter your credentials, then click Submit.
4. **Browse** — select a clothing category (Pants, T-Shirts, Jackets, Sweaters).
5. **Checkout** — fill in your card details and click "Place Order".
6. **Go Back** — use the Back button on the Checkout screen to return to categories.

---

## ⚠️ Known Limitations

- Passwords are stored in **plain text** in `users.txt` — not suitable for production use.
- No actual product listings or inventory system; categories are placeholders.
- Payment processing is simulated — no real transactions occur.
- Application is **Windows-only** due to WinForms dependency.

---

## 📄 License

This project is for educational purposes.
