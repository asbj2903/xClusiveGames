﻿using System;
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

namespace xClusiveGames
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		string Ticked = "X";
		string Unticked = "";
		bool TickedBool = false;
		public MainWindow()
		{
			InitializeComponent();
		}

		private void BTNCheckBoxRememberMe_Click(object sender, RoutedEventArgs e)
		{
			if (TickedBool == false)
			{
				BTNCheckBoxRememberMe.Content = Ticked;
				TickedBool = true;
			}
			else
			{
				BTNCheckBoxRememberMe.Content = Unticked;
				TickedBool = false;
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			string TempAccName;
			string TempPassName;

			TempAccName = TBAccount.Text;
			TempPassName = TBPassword.Text;


		}

		private void Button_Click_1(object sender, RoutedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://google.com");
		}
	}
}
