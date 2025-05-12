# 📊 StatSnap

StatSnap is a personal WPF desktop application built using C# that calculates key statistical values from a predefined set of numbers. It quickly determines the **lowest**, **highest**, **median**, and **mode** values from a list, providing a simple and visually appealing interface for quick statistical insight.

---

## ✨ Features

* View and process a predefined list of numbers.
* Instantly calculate:

  * **Lowest Number**
  * **Highest Number**
  * **Median Value**
  * **Mode Value**
* User-friendly UI with clear, concise output.

---

## 🧮 How It Works

1. The app displays a hardcoded list of numbers (you can modify the list in the code).
2. When the user clicks **"Calculate Stats"**, the application processes the list and displays:

   * The smallest and largest numbers in the set.
   * The median, which is the middle number (or the average of the two middle numbers if the list has an even count).
   * The mode, which is the number that appears most frequently.

---

## 🛠 Tech Stack

* **Language**: C#
* **Platform**: .NET (WPF - Windows Presentation Foundation)
* **UI**: XAML

---

## 📁 File Structure

```
StatSnap/
├── MainWindow.xaml           # UI layout
├── MainWindow.xaml.cs        # Code-behind logic for calculations
├── App.xaml
├── App.xaml.cs
└── README.md
```

---

## 🧪 Sample Data

The current list of numbers being analyzed:

```
1, 4, 3, 4, 5, 7, 7, 8, 9, 10
```

You can customize this list in `MainWindow.xaml.cs` under the `CalculateStats_Click` method.

---

## 🧑‍💻 Usage

1. Open the project in Visual Studio.
2. Build and run the solution.
3. Click the **"Calculate Stats"** button to see the results.

---

## 🏁 Future Improvements

* Allow user input for dynamic number entry.
* Add support for additional statistical functions (e.g., range, standard deviation).
* Export results to a file (e.g., CSV).
* Light/dark theme toggle.

---

## 📃 License

This project is for personal and educational use.

---

