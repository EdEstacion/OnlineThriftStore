# 🛍️ Online Thrifting Clothing Store

A Windows Forms desktop application built with C# and .NET Framework 4.7.2 that simulates an online thrift store. Users can register/login, browse clothing categories, and complete a simulated checkout process.


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


## ⚠️ Known Limitations

- Passwords are stored in **plain text** in `users.txt` — not suitable for production use.
- No actual product listings or inventory system; categories are placeholders.
- Payment processing is simulated — no real transactions occur.
- Application is **Windows-only** due to WinForms dependency.

---

## 📄 License

This project is for educational purposes.
