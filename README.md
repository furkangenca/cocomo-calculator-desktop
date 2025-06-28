# 🧮 COCOMO Calculator (Windows Desktop App)

**COCOMO Calculator** is a Windows desktop application built with **C# (.NET Framework)** to implement the **COCOMO (Constructive Cost Model)** — a well-known algorithmic model used to estimate **cost**, **effort**, and **development time** for software projects.

> 🛠️ Developed using **WinForms** in Visual Studio  
> 📦 Download the executable from the [Releases](https://github.com/furkangenca/cocomo-calculator-desktop/releases) section.

---

## 🖼️ Application Preview

<p align="center">
  <img src="https://github.com/furkangenca/CocomoCalculator/assets/148720624/9ffee935-32da-415d-ac8e-050c75875180" width="650">
</p>

---

## ⚙️ How It Works

The application estimates software development parameters in **three steps** using the COCOMO model:

### 1️⃣ Enter Measurement Parameters

Specify counts for inputs, outputs, files, and interfaces. Each is multiplied by its respective weight factor to compute a **Function Point** count.

### 2️⃣ Answer Complexity Questions

Eight yes/no technical complexity questions determine the **effort adjustment factor**.

### 3️⃣ Select Project Type

Choose one of the three COCOMO project types:

- **Organic** — Small, simple systems  
- **Semi-Detached** — Intermediate complexity  
- **Embedded** — Large, tightly constrained systems

The app will then calculate:

- 🧠 Estimated Effort (person-months)  
- 🕒 Development Time (months)  
- 👥 Recommended Team Size

---

## 🚀 How to Run

1. Go to the [Releases](https://github.com/furkangenca/cocomo-calculator-desktop/releases) section
2. Download the latest `.exe` file
3. Double-click to launch — no installation required

> 💡 This is a standalone Windows application. No setup or dependencies needed.

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
