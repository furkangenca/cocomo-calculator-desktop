# 🧮 COCOMO Calculator (Windows Desktop App)

This project is a Windows desktop application built to implement the **COCOMO (Constructive Cost Model)** — a well-known algorithmic model used to estimate **cost**, **manpower**, and **development time** for software projects.

> ✅ Includes executable `.exe` file for direct use  
> 🛠️ Developed with Visual Studio (.NET)

---

## 🖼️ Application Preview

<p align="center">
  <img src="https://github.com/furkangenca/CocomoCalculator/assets/148720624/9ffee935-32da-415d-ac8e-050c75875180" width="650">
</p>

---

## ⚙️ How It Works

The COCOMO model uses software project parameters to estimate development effort.  
The process consists of **three simple steps**:

---

### 📌 Step 1: Enter Measurement Parameters

You will need to count elements of your project such as inputs, outputs, and queries, and multiply them by their weight factors.

| Measurement Parameter       | Count | Weight Factor |
|-----------------------------|--------|----------------|
| User Inputs                 | 10     | 3              |
| User Outputs                | 15     | 4              |
| User Inquiries              | 5      | 3              |
| Internal Logical Files      | 2      | 7              |
| External Interface Files    | 1      | 5              |

> Multiply and sum all rows to compute your **Function Point count**.

---

### 🧠 Step 2: Answer Technical Complexity Questions

There are 8 yes/no questions assessing aspects like performance requirements, data communication, and system configuration. Each answer affects your **effort adjustment factor**.

---

### 🗂️ Step 3: Select Project Class

Choose one of the following based on the nature of your software:

- **Organic** – Small, familiar systems developed in a stable environment  
- **Semi-Detached** – Medium complexity, partially familiar teams  
- **Embedded** – Complex systems with tight hardware/software constraints

The tool will then calculate:

- **Estimated Effort (person-months)**
- **Development Time (months)**
- **Required Team Size**

---

## 🚀 How to Run

1. Download the latest release from the repository (`CocomoCalculator.exe`)
2. Double-click to launch the application
3. Fill in the required fields and calculate results instantly

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
