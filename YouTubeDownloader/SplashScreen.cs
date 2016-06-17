// Project:		    YouTubeDownloader
// Date:		    April 6, 2016
// Assignment No.:	3
// Description:	    This project takes input of youtube video url, asks user to select from available formats
//                  and selects save location and downloads it.
//                  This file is ths splash screen of the project

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTubeDownloader
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            //increment the progress bar
            progressBar1.Increment(1);
            if(progressBar1.Value == 100)
            {
                //stop the splash screen timer
                splashScreenTimer.Stop();
            }
        }
    }
}
