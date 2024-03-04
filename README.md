# Fault Reporting System Software
The system fulfills the function of managing fault reports, it is intended to be multipurpose, so it can be used both to manage faults of an ISP as well as technical support in any area. It consists of two parts, one section for clients to generate a report and another for administrators to review.

### Graphic interface
The project is created with C# using WPF, the layout of the windows is therefore created using XAML.

To achieve the effect of inserting the views inside the main window (**/WPF/MainWindow.xaml**), two special classes are used:

  - **/Core/RelayCommand.cs**

  - **/Core/ObservableObject.cs**.

The Views shown in **/WPF/MainWindow.xaml** are found in the */MVVM/View/* folder, for each of them there is a class that represents it in the folder
*/MVVM/ViewModel/*.
This ViewModel layout connects the *view.xaml* to its respective *viewModel.cs* class and allows the **/MVVM/Model/mainViewModel.cs/** class to achieve the desired effect.
With this design, fluidity is achieved in the effect of changing views by pressing buttons in the right menu without having to open a new window.

In the Themes folder are the resource dictionaries to apply custom styles to window objects (buttons, text boxes, etc.)

### Classes
In the */src/* folder are the main classes of the project, which fulfill the function of managing data reflected in the database, in addition to
implement functions that perform validations.
