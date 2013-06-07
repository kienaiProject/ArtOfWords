﻿using ModernizedAlice.ArtOfWords.BizCommon.Model.Relation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RelationDetailControlls
{
    /// <summary>
    /// ItemRelationDetailControl.xaml の相互作用ロジック
    /// </summary>
    public partial class ItemRelationDetailControl : UserControl
    {
        public ItemRelationDetailControl()
        {
            InitializeComponent();
        }
        public void BindData(Collection<ItemStoryRelationModel> data)
        {
            ItemRelationListView.ItemsSource = data;
        }
    }
}
