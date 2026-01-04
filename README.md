#  Function Point & COCOMO Estimation Tool

This project is a Windows desktop application that estimates software development effort, duration, and team size by combining **Function Point Analysis** with the **COCOMO Basic Model**.

The application translates theoretical software engineering models into a practical, executable estimation tool.

---

## Tech Stack
- Language: C#
- Framework: .NET Framework (Windows Forms)
- Platform: Windows Desktop
- IDE: Visual Studio

---

## Key Features
- Function Point (IN) calculation based on user inputs
- Automatic estimation of Lines of Code (LOC / KLOC)
- Software effort, time, and team size estimation using COCOMO
- Support for Organic, Semi-Detached, and Embedded project types
- Standalone executable with no installation required

---

## Architecture & Design

### Estimation Pipeline
The application follows a three-stage estimation workflow:

1. **Function Point Calculation**
   - Computes unadjusted function points (AIN)
   - Applies technical complexity factors to derive adjusted IN

2. **Size Estimation**
   - Converts IN to estimated LOC and KLOC
   - Uses industry-average LOC per function point

3. **COCOMO Estimation**
   - Calculates effort, development time, and average team size
   - Uses project-type–specific COCOMO constants

### Design Considerations
- Clear separation between input handling, calculation logic, and UI
- Deterministic calculations with reproducible outputs
- User-friendly interface for non-technical users

---

## Screenshots

### Application Interface
<img src="https://github.com/furkangenca/CocomoCalculator/assets/148720624/9ffee935-32da-415d-ac8e-050c75875180" width="650">

### Sample Output
<img src="https://github.com/user-attachments/assets/e3084514-10d5-407a-a0a3-c82c7fb9f39d" width="650">

---

## Setup
1. Download the executable from the Releases page
2. Run the `.exe` file (no installation required)
3. Enter project parameters and view estimation results

---

## License
This project is licensed under the MIT License.
