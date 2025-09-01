# Cashier Application

A simple C# Windows Forms Application that simulates a cashier system with support for discounts, user login, and payment computation.

# 📌 Features

User Login System

Cashier accounts with username and password validation.

Displays cashier’s full name and department on successful login.

Item Management

Input item name, price, quantity, and discount.

Calculates total price with or without discounts.

Payment Handling

Accepts payment from the customer.

Automatically computes change.

GUI Forms

Login form (frmLoginAccount)

Main cashier form (Form1)

Registration form (register)

# 🗂 Project Structure

ItemNameSpace

Item – Base class for items (name, price, quantity, total price).

DiscountedItem – Inherits from Item, applies discount, and handles payment + change.

UserAccountNameSpace

UserAccount – Represents a generic user with login validation.

Cashier – Extends UserAccount with department details.

CashierApplication

Form1 – Main cashier form (handles items, payment, and menu actions).

frmLoginAccount – Login window for validating cashier credentials.

register – A form for registering user details (e.g., DOB).

Program.cs – Entry point; ensures login happens before accessing the main form.

# ⚙️ How It Works

On startup, the Login Form is shown.

Default cashier credentials (from code):

Username: cashier101

Password: MaryAngelaGolagat

After successful login, the Cashier Form is displayed.

Enter item details: name, price, quantity, and discount.

Click Compute → displays the total amount (with discount applied).

Enter the Payment amount and click Submit → shows the change.

# 🖼 Example Flow

Item: Apple

Price: 20

Quantity: 3

Discount: 10%

Total Price: (20 - (20 × 0.10)) × 3 = 54

If payment entered = 100 → Change = 46

# 🚀 Getting Started

Clone the repository:

git clone https://github.com/your-username/cashier-application.git


Open the project in Visual Studio.

Build and run the project (F5).

# ✅ Requirements

.NET Framework / .NET 6+

Visual Studio 2022 (recommended)
