using System;
using System.Collections.Generic;
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
using Microsoft.Kinect;

namespace Plantilla
{
    /// 
    public partial class MainWindow : Window
    {
        KinectSensor miKinect;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            miKinect = KinectSensor.KinectSensors[0];
            miKinect.ColorStream.Enable();
            miKinect.DepthStream.Enable();
            miKinect.SkeletonStream.Enable();

            miKinect.ColorFrameReady += new EventHandler<ColorImageFrameReadyEventArgs>(miKinect_ColorFrameReady);
            miKinect.DepthFrameReady += new EventHandler<DepthImageFrameReadyEventArgs>(miKinect_DepthFrameReady);
            miKinect.SkeletonFrameReady += new EventHandler<SkeletonFrameReadyEventArgs>(miKinect_SkeletonFrameReady);

            miKinect.Start();
        }

        void miKinect_SkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            throw new NotImplementedException();
        }

        void miKinect_DepthFrameReady(object sender, DepthImageFrameReadyEventArgs e)
        {
            throw new NotImplementedException();
        }

        void miKinect_ColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            throw new NotImplementedException();
        }

    }
}