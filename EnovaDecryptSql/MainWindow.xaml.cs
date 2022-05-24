using EnovaDecryptSql.Models;
using EnovaDecryptSql.Properties;
using Soneta.Business.App;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EnovaDecryptSql
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ListaBazDanychCB.ItemsSource = Settings.Default.ListyBazDanych;
            if (ListaBazDanychCB.Text != String.Empty)
                InitDatabases();
            DatabasesDG.ItemsSource = Databases;
        }

        private void InitDatabases()
        {
            DatabasesDG.ItemsSource = Databases = XMLParser.Parse(ListaBazDanychCB.Text);
        }

        private List<DatabaseCollectionMsSqlDatabase> Databases { get; set; }

        private void PasswordLeftButtonDownHandler(object sender, MouseButtonEventArgs e)
        {

            DataGridCell cell = sender as DataGridCell;
            DatabaseCollectionMsSqlDatabase database = cell.DataContext as DatabaseCollectionMsSqlDatabase;
            string haslo = database.Password.TrimStart('=');
            string decrypted = Coder.Decrypt(haslo, database.Key);

            database.ShowedPassword = decrypted;
        }

        private void PasswordLeftButtonUpHandler(object sender, MouseButtonEventArgs e)
        {
            DataGridCell cell = sender as DataGridCell;
            DatabaseCollectionMsSqlDatabase database = cell.DataContext as DatabaseCollectionMsSqlDatabase;
            database.ShowedPassword = "********";
        }

        private void OperatorPasswordLeftButtonDownHandler(object sender, MouseButtonEventArgs e)
        {

            DataGridCell cell = sender as DataGridCell;
            DatabaseCollectionMsSqlDatabase database = cell.DataContext as DatabaseCollectionMsSqlDatabase;
            string haslo = database.OperatorPassword?.TrimStart('=');
            string decrypted = Coder.Decrypt(haslo, database.Key);

            database.ShowedOperatorPassword = decrypted;
        }

        private void OperatorPasswordLeftButtonUpHandler(object sender, MouseButtonEventArgs e)
        {
            DataGridCell cell = sender as DataGridCell;
            DatabaseCollectionMsSqlDatabase database = cell.DataContext as DatabaseCollectionMsSqlDatabase;
            database.ShowedOperatorPassword = "********";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Settings.Default.ListyBazDanych.Contains(ListaBazDanychCB.Text))
            {
                Settings.Default.ListyBazDanych.Add(ListaBazDanychCB.Text);
                Settings.Default.Save();
                ListaBazDanychCB.ItemsSource = Settings.Default.ListyBazDanych;
            }
            InitDatabases();
        }
    }
}
