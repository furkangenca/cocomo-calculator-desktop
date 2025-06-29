# 🧮 Function Point + COCOMO Calculator (Windows Desktop App)

**COCOMO Calculator** is a Windows desktop application that estimates software development **effort**, **duration**, and **team size** by combining two models:

- **Function Point Analysis (IN)**
- **COCOMO Basic Model**

Developed in **C# (.NET Framework)** using Windows Forms.

> 📦 Download the `.exe` directly from the [Releases](https://github.com/furkangenca/cocomo-calculator-desktop/releases) page.  
> ⚙️ No installation required. Runs as a standalone Windows application.



---

## 🧠 How It Works

The app follows a 3-stage estimation flow:

### 1️⃣ Function Point Calculation (IN)

You provide:
- A list of **measurement counts** (e.g. number of inputs, outputs, interfaces…)
- A matching list of **weight factors** for each

The app computes **AIN (Unadjusted Function Points)** using:

```
AIN = ∑ (Measurement[i] × Weight[i])
```

Then it evaluates 8 complexity-related factors (0–5 scale):

> e.g. *Does the app require backup/recovery?*  
> *Are there distributed operations?*  
> *Is performance critical?* etc.

These are summed as the **Technical Complexity Factor (TKF)**, and IN is calculated as:

```
IN = AIN × (0.65 + 0.01 × TKF)
```

### 2️⃣ Source Code Size Estimation

Estimated **Lines of Code (LOC)** are calculated based on:

```
LOC = IN × 30  
KLOC = LOC / 1000
```

(Assumes average 30 LOC per Function Point)

### 3️⃣ COCOMO Estimation

Based on selected **project type**, the app applies COCOMO's basic model:

| Type | Input Code | Description        |
|------|------------|--------------------|
| 1    | Organic     | Simple, small project with experienced team |
| 2    | Semi-Detached | Medium-size, mixed-experience |
| 3    | Embedded    | Complex, constrained system |

COCOMO Formulas:

```
Effort (K) = a × (KLOC)^b  
Time   (T) = c × (K)^d  
Avg. Team Size = Effort / Time
```

Constants (a, b, c, d) vary based on project type.

---

## 🖼️ App Preview

<p align="center">
  <img src="https://github.com/furkangenca/CocomoCalculator/assets/148720624/9ffee935-32da-415d-ac8e-050c75875180" width="650">
</p>


### 📤 Output Preview

Once you enter the inputs and hit the **"Cocomo Sonucunu Hesapla"** button, the application displays all calculated results:

- AIN (Unadjusted Function Points)
- TKF (Technical Complexity Score)
- IN (Adjusted Function Points)
- Estimated LOC
- KLOC

Example output:

<p align="center">
  <img src="https://github.com/user-attachments/assets/e3084514-10d5-407a-a0a3-c82c7fb9f39d" width="650">
</p>

## ✅ Sample Input Format

Measurement Parameters (space-separated):  
```
3 5 2 1 0
```

Weight Factors (space-separated):  
```
3 4 3 7 5
```

Technical Questions (each from 0 to 5):  
```
1. Does it require backup/recovery?  
2. Is communication needed?  
3. Are operations distributed?  
4. Is performance critical?  
... (total of 8 questions)
```

Project Type:  
```
1 → Organic  
2 → Semi-Detached  
3 → Embedded
```

---

## 🚀 How to Run

1. Download `.exe` from [Releases](https://github.com/furkangenca/cocomo-calculator-desktop/releases)
2. Double-click and run — no installation or extra setup required

> ⚠️ Windows only. Requires .NET Framework (already present on most systems)

---

## 🛠️ Tech Stack

- Language: C#
- Framework: .NET Framework (WinForms)
- IDE: Visual Studio
- No external dependencies

---

## 📄 License

This project is licensed under the [MIT License](LICENSE).
