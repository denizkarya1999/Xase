using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_bueno_vista
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = "About Xase";
            this.labelProductName.Text = "Xase Database Program for Developers Without Borders Studio";
            this.labelVersion.Text = "Version " + AssemblyVersion + " - Bueno Vista";
            this.labelCopyright.Text = "2021 © Developers Without Limits Studio. All rights are reserved.";
            this.labelCompanyName.Text = "Released in August 2021";
            this.textBoxDescription.Text = AssemblyDescription;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void About_Load(object sender, EventArgs e)
        {
            // Set the description
            textBoxDescription.Text = @"Contributors
****************************************************
Studio Lead and Full Stack Developer: Deniz K Acikbas
Database Developer: Mohammad Mukahhal

Software and Tools
****************************************************
IDE: Microsoft Visual Studio 2019
Framework: Microsoft .NET
Type: Windows Forms
Programming Language: C#
Database Language: MySQL
Database Type: Local Database

Contact Information
****************************************************
Phone: +1 (734) 660-8867
E-Mail: dacikbas@umich.edu
Community Server: https://discord.com/invite/2NYKwNVc

Apply to DWL Studio
****************************************************
Link: https://docs.google.com/forms/d/e/1FAIpQLSc35mrpzrQbeLi93HGoV5HfpCL7RqUxwORkU6C7bMOCaVAimA/viewform?usp=sf_link";
        }
    }
    }
