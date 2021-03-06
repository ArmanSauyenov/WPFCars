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
using WpfEquipment.DAL.Model;

namespace WpfEquipments.View
{
    /// <summary>
    /// Interaction logic for PageManufactures.xaml
    /// </summary>
    public partial class PageManufactures : Page
    {
        private mcs db = new mcs();
        public PageManufactures()
        {
            InitializeComponent();

            lvManufactures.ItemsSource = db.TablesManufacturer.OrderBy(o=>o.intManufacturerID).ToList();
        }


    }
}
