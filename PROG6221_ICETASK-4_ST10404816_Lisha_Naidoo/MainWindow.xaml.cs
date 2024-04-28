using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PROG6221_ICETASK_4_ST10404816_Lisha_Naidoo
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			//ICE TASK 4

			InitializeComponent();

			Grid mainGrid = new Grid();
			this.Content = mainGrid;

			//StackPanel
			StackPanel stackPanel = new StackPanel();
			mainGrid.Children.Add(stackPanel);

			//Name
			TextBlock nameTextBlock = new TextBlock { Text = "Name:" };
			TextBox nameTextBox = new TextBox();
			stackPanel.Children.Add(nameTextBlock);
			stackPanel.Children.Add(nameTextBox);

			//Ingredients
			TextBlock ingredientsTextBlock = new TextBlock { Text = "Ingredients:" };
			TextBox ingredientsTextBox = new TextBox();
			stackPanel.Children.Add(ingredientsTextBlock);
			stackPanel.Children.Add(ingredientsTextBox);

			//Instructions
			TextBlock instructionsTextBlock = new TextBlock { Text = "Instructions:" };
			TextBox instructionsTextBox = new TextBox();
			stackPanel.Children.Add(instructionsTextBlock);
			stackPanel.Children.Add(instructionsTextBox);

			//Button controls
			Button addRecipeButton = new Button { Content = "Add Recipe" };
			Button clearButton = new Button { Content = "Clear" };
			stackPanel.Children.Add(addRecipeButton);
			stackPanel.Children.Add(clearButton);

			//Adds a Border 
			Border border = new Border();
			//border.Child = stackPanel;
			mainGrid.Children.Add(border);
		}
	}
}

/*** References ***/

/*
 * Troelsen, A. and Japikse, P. 2021. Pro C# 9 with .NET 5: Foundational Principles and Practices in Programming. 10th ed. New York: Apress
 */
