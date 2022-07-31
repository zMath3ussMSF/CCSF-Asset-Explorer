﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CCSF_Asset_Explorer
{
    public partial class PropertyBox : Form
    {
        CCSTab Tab;
        public PropertyBox(CCSNode node, CCSTab tab)
        {
            InitializeComponent();
            Tab = tab;

            if (Tab.frameView.Visible)
                this.Text += $"_Frame {node.Parent.Index}";
            
            Populate(node, Tab.frameView.Visible);
        }
        private void Populate(CCSNode node, bool Frame = false)
        {
            CCSF file = Tab.CCSFile;
            if (Frame == true)
            {
                propertyGrid1.SelectedObject = node.Block;
                this.Text = node.Block.GetObjectName();
            }
            else
            {

                if (node.File != null)
                {
                    propertyGrid1.SelectedObject = node.File;
                    this.Text = Path.GetFileName(node.File.FileName);
                }
                else if (node.Object != null)
                {
                    propertyGrid1.SelectedObject = node.Object;
                    this.Text = node.Object.ObjectName;
                }
                else
                {
                    propertyGrid1.SelectedObject = node.Block;
                    this.Text = node.Block.GetObjectName();
                }
                
            }
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            //Tab.frameView.BeginUpdate();
            //Tab.resourceView.BeginUpdate();

            //if (Tab.frameView.Nodes.Count > 0)
            //    Tab.frameView.Nodes.Clear();
            //Tab.resourceView.Nodes.Clear();

            //Tab.frameView.EndUpdate();
            //Tab.resourceView.EndUpdate();

            //Tab.CCSFile.ToTreeView(Tab.frameView);
            //Tab.CCSFile.ToTreeView(Tab.resourceView, true);
            //if(Tab.resourceView.Visible)


            //Console.WriteLine("Inserida causa no evento!");

        }
    }
}
